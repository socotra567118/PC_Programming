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
            this.ball = new System.Windows.Forms.PictureBox();
            this.isSlow = new System.Windows.Forms.RadioButton();
            this.isFast = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(0, 0);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // isSlow
            // 
            this.isSlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isSlow.AutoSize = true;
            this.isSlow.Location = new System.Drawing.Point(696, 12);
            this.isSlow.Name = "isSlow";
            this.isSlow.Size = new System.Drawing.Size(92, 28);
            this.isSlow.TabIndex = 2;
            this.isSlow.TabStop = true;
            this.isSlow.Text = "Slow";
            this.isSlow.UseVisualStyleBackColor = true;
            // 
            // isFast
            // 
            this.isFast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isFast.AutoSize = true;
            this.isFast.Location = new System.Drawing.Point(696, 46);
            this.isFast.Name = "isFast";
            this.isFast.Size = new System.Drawing.Size(85, 28);
            this.isFast.TabIndex = 3;
            this.isFast.TabStop = true;
            this.isFast.Text = "Fast";
            this.isFast.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isFast);
            this.Controls.Add(this.isSlow);
            this.Controls.Add(this.ball);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.RadioButton isSlow;
        private System.Windows.Forms.RadioButton isFast;
    }
}

