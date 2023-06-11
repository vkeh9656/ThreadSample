﻿namespace ThreadSample
{
    partial class SubForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pbarPlayer = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(75, 12);
            this.lblPlayerName.TabIndex = 0;
            this.lblPlayerName.Text = "PlayerName";
            // 
            // pbarPlayer
            // 
            this.pbarPlayer.Location = new System.Drawing.Point(11, 32);
            this.pbarPlayer.Name = "pbarPlayer";
            this.pbarPlayer.Size = new System.Drawing.Size(347, 18);
            this.pbarPlayer.TabIndex = 1;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(234, 9);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(113, 12);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "진행 상황 표시 : 0%";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(148, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "중단";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 62);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.pbarPlayer);
            this.Controls.Add(this.lblPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SubForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.ProgressBar pbarPlayer;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnStop;
    }
}