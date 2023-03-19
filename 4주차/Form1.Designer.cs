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
            this.DrawButton = new System.Windows.Forms.Button();
            this.GraphicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(949, 12);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(223, 99);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "Draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // GraphicBox
            // 
            this.GraphicBox.Location = new System.Drawing.Point(12, 12);
            this.GraphicBox.Name = "GraphicBox";
            this.GraphicBox.Size = new System.Drawing.Size(931, 758);
            this.GraphicBox.TabIndex = 1;
            this.GraphicBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 782);
            this.Controls.Add(this.GraphicBox);
            this.Controls.Add(this.DrawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GraphicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.PictureBox GraphicBox;
    }
}

