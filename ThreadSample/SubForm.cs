using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadSample
{
    public partial class SubForm : Form
    {
        public delegate int deleMessage(object sender, string strResult); // delegate 선언
        public event deleMessage eventDeleMessage;

        string _strPlayerName = string.Empty;
        public string StrPlayerName { get => _strPlayerName; set => _strPlayerName = value; }
        
        Thread _thread = null;

        bool _bThreadStop = false; // Thread Stop을 위한 Flag
        

        public SubForm()
        {
            InitializeComponent();
        }

        public SubForm(string strPlayerName)
        {
            InitializeComponent();

            lblPlayerName.Text = StrPlayerName = strPlayerName;
        }

        public void ThreadOn()
        {
            //// Thread 생성 case 1
            //_thread = new Thread(new ThreadStart(Run)); // ThreadStart Delegate 타입 객체를 생성 후 함수를 넘김

            // Thread 생성 case 2 : delegate 없이 컴파일러가 delegate 객체를 추론해서 생성해주는 케이스
            _thread = new Thread(Run);

            //// Thread 생성 case 3 : 익명 메서드
            //_thread = new Thread(delegate() { _thread.Start(); });

            _thread.Start();
        }

        private void Run()
        {
            try
            {
                // UI Control이 자기가 만든 Thread가 아닌, 새로 생성한 Thread에서 접근할 경우(지금의 경우 new Thread(Run)), Cross Thread가 발생

                // Cross Thread Error를 무시해버리는 Config => Thread 충돌에 대한 예외 처리를 무시(Cross Thread), 그래서 사용 비추천
                // CheckForIllegalCrossThreadCalls = false;

                int ivar = 0;
                Random rd = new Random();

                while (pbarPlayer.Value < 100 && !_bThreadStop)
                {
                    if (this.InvokeRequired) // 요청한 Thread가 현재 Main Thread에 있는 Control을 액세스 할 수 있는지 확인
                    {
                        this.Invoke(new Action(delegate ()
                        {//함수 값 (컨트롤 사용할때만 잠시 넣어줄 것임)
                            ivar = rd.Next(1, 11);
                            pbarPlayer.Value = (pbarPlayer.Value + ivar > 100) ?
                                pbarPlayer.Value = 100 :
                                pbarPlayer.Value = pbarPlayer.Value + ivar;

                            lblProgress.Text = string.Format("진행 상황 표시 : {0}%", pbarPlayer.Value);

                            this.Refresh();
                        }));
                    }

                    Thread.Sleep(300);
                }
                if (_bThreadStop)
                {
                    eventDeleMessage(this, "중단 (Thread Stop)");
                }
                else
                {
                    eventDeleMessage(this, "완료 (Thread Complete)");
                }
            }
            catch(ThreadInterruptedException exInterrupt) 
            {
                exInterrupt.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(_thread.IsAlive) _bThreadStop = true;
        }

        public void ThreadAbort() // 바깥에서 끌때도 종료할 수 있도록 접근제한자를 public으로 둠.
        {
            if(_thread.IsAlive) // Thread가 동작중일 경우
            {
                _thread.Abort(); // Thread를 강제 종료
            }
        }

        public void ThreadJoin()
        {
            if(_thread.IsAlive)
            {
                bool bThreadEnd = _thread.Join(3000); // Join : 중단시키고 대기하기
            }
        }

        public void ThreadInterrupt()
        {
            if(_thread.IsAlive)
            {
                _thread.Interrupt();
            }
        }
    }
}
