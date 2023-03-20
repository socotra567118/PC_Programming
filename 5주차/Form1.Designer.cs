namespace _19100041_DaeheonKim
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.DotArea = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.RealRatio = new System.Windows.Forms.Label();
            this.InCount = new System.Windows.Forms.Label();
            this.OutCount = new System.Windows.Forms.Label();
            this.MonteRatio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DotArea)).BeginInit();
            this.SuspendLayout();
            // 
            // DotArea
            // 
            this.DotArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DotArea.Location = new System.Drawing.Point(12, 12);
            this.DotArea.Name = "DotArea";
            this.DotArea.Size = new System.Drawing.Size(1086, 917);
            this.DotArea.TabIndex = 0;
            this.DotArea.TabStop = false;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(1104, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(169, 86);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RealRatio
            // 
            this.RealRatio.AutoSize = true;
            this.RealRatio.Location = new System.Drawing.Point(1104, 101);
            this.RealRatio.Name = "RealRatio";
            this.RealRatio.Size = new System.Drawing.Size(0, 24);
            this.RealRatio.TabIndex = 2;
            // 
            // InCount
            // 
            this.InCount.AutoSize = true;
            this.InCount.Location = new System.Drawing.Point(1104, 125);
            this.InCount.Name = "InCount";
            this.InCount.Size = new System.Drawing.Size(23, 24);
            this.InCount.TabIndex = 3;
            this.InCount.Text = "0";
            // 
            // OutCount
            // 
            this.OutCount.AutoSize = true;
            this.OutCount.Location = new System.Drawing.Point(1104, 149);
            this.OutCount.Name = "OutCount";
            this.OutCount.Size = new System.Drawing.Size(23, 24);
            this.OutCount.TabIndex = 4;
            this.OutCount.Text = "0";
            // 
            // MonteRatio
            // 
            this.MonteRatio.AutoSize = true;
            this.MonteRatio.Location = new System.Drawing.Point(1104, 173);
            this.MonteRatio.Name = "MonteRatio";
            this.MonteRatio.Size = new System.Drawing.Size(23, 24);
            this.MonteRatio.TabIndex = 5;
            this.MonteRatio.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 941);
            this.Controls.Add(this.MonteRatio);
            this.Controls.Add(this.OutCount);
            this.Controls.Add(this.InCount);
            this.Controls.Add(this.RealRatio);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DotArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DotArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DotArea;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label RealRatio;
        private System.Windows.Forms.Label InCount;
        private System.Windows.Forms.Label OutCount;
        private System.Windows.Forms.Label MonteRatio;
    }
}

