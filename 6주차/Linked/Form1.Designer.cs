namespace Linked
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
            this.btnMake = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrepend = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(24, 22);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(100, 71);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(170, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 71);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrepend
            // 
            this.btnPrepend.Location = new System.Drawing.Point(24, 99);
            this.btnPrepend.Name = "btnPrepend";
            this.btnPrepend.Size = new System.Drawing.Size(100, 71);
            this.btnPrepend.TabIndex = 2;
            this.btnPrepend.Text = "Prepend";
            this.btnPrepend.UseVisualStyleBackColor = true;
            this.btnPrepend.Click += new System.EventHandler(this.btnPrepend_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(24, 176);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(100, 71);
            this.btnAppend.TabIndex = 3;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 268);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnPrepend);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnMake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrepend;
        private System.Windows.Forms.Button btnAppend;
    }
}

