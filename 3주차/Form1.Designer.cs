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
            this.toBitBtn = new System.Windows.Forms.Button();
            this.fromBitBtn = new System.Windows.Forms.Button();
            this.onBtn = new System.Windows.Forms.Button();
            this.offBtn = new System.Windows.Forms.Button();
            this.toggleBtn = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.TextBox();
            this.indexLabel = new System.Windows.Forms.TextBox();
            this.shiftUpBtn = new System.Windows.Forms.Button();
            this.shiftDownBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check5 = new System.Windows.Forms.CheckBox();
            this.check6 = new System.Windows.Forms.CheckBox();
            this.check7 = new System.Windows.Forms.CheckBox();
            this.check8 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toBitBtn
            // 
            this.toBitBtn.Location = new System.Drawing.Point(330, 76);
            this.toBitBtn.Name = "toBitBtn";
            this.toBitBtn.Size = new System.Drawing.Size(140, 50);
            this.toBitBtn.TabIndex = 0;
            this.toBitBtn.Text = ">>";
            this.toBitBtn.UseVisualStyleBackColor = true;
            this.toBitBtn.Click += new System.EventHandler(this.toBitBtn_Click);
            // 
            // fromBitBtn
            // 
            this.fromBitBtn.Location = new System.Drawing.Point(330, 132);
            this.fromBitBtn.Name = "fromBitBtn";
            this.fromBitBtn.Size = new System.Drawing.Size(140, 50);
            this.fromBitBtn.TabIndex = 1;
            this.fromBitBtn.Text = "<<";
            this.fromBitBtn.UseVisualStyleBackColor = true;
            this.fromBitBtn.Click += new System.EventHandler(this.fromBitBtn_Click);
            // 
            // onBtn
            // 
            this.onBtn.Location = new System.Drawing.Point(330, 216);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(140, 50);
            this.onBtn.TabIndex = 2;
            this.onBtn.Text = "ON";
            this.onBtn.UseVisualStyleBackColor = true;
            this.onBtn.Click += new System.EventHandler(this.onBtn_Click);
            // 
            // offBtn
            // 
            this.offBtn.Location = new System.Drawing.Point(330, 272);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(140, 50);
            this.offBtn.TabIndex = 3;
            this.offBtn.Text = "OFF";
            this.offBtn.UseVisualStyleBackColor = true;
            this.offBtn.Click += new System.EventHandler(this.offBtn_Click);
            // 
            // toggleBtn
            // 
            this.toggleBtn.Location = new System.Drawing.Point(330, 328);
            this.toggleBtn.Name = "toggleBtn";
            this.toggleBtn.Size = new System.Drawing.Size(140, 50);
            this.toggleBtn.TabIndex = 4;
            this.toggleBtn.Text = "Toggle";
            this.toggleBtn.UseVisualStyleBackColor = true;
            this.toggleBtn.Click += new System.EventHandler(this.toggleBtn_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.Location = new System.Drawing.Point(12, 76);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(300, 35);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "0";
            // 
            // indexLabel
            // 
            this.indexLabel.Location = new System.Drawing.Point(12, 216);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(300, 35);
            this.indexLabel.TabIndex = 6;
            this.indexLabel.Text = "0";
            // 
            // shiftUpBtn
            // 
            this.shiftUpBtn.Location = new System.Drawing.Point(12, 328);
            this.shiftUpBtn.Name = "shiftUpBtn";
            this.shiftUpBtn.Size = new System.Drawing.Size(140, 50);
            this.shiftUpBtn.TabIndex = 7;
            this.shiftUpBtn.Text = "Shift Up";
            this.shiftUpBtn.UseVisualStyleBackColor = true;
            this.shiftUpBtn.Click += new System.EventHandler(this.shiftUpBtn_Click);
            // 
            // shiftDownBtn
            // 
            this.shiftDownBtn.Location = new System.Drawing.Point(172, 328);
            this.shiftDownBtn.Name = "shiftDownBtn";
            this.shiftDownBtn.Size = new System.Drawing.Size(140, 50);
            this.shiftDownBtn.TabIndex = 8;
            this.shiftDownBtn.Text = "Shift Down";
            this.shiftDownBtn.UseVisualStyleBackColor = true;
            this.shiftDownBtn.Click += new System.EventHandler(this.shiftDownBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.check1);
            this.groupBox1.Controls.Add(this.check2);
            this.groupBox1.Controls.Add(this.check3);
            this.groupBox1.Controls.Add(this.check4);
            this.groupBox1.Controls.Add(this.check5);
            this.groupBox1.Controls.Add(this.check6);
            this.groupBox1.Controls.Add(this.check7);
            this.groupBox1.Controls.Add(this.check8);
            this.groupBox1.Location = new System.Drawing.Point(476, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 310);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bits";
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(6, 276);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(55, 28);
            this.check1.TabIndex = 7;
            this.check1.Text = "0";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(6, 242);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(55, 28);
            this.check2.TabIndex = 6;
            this.check2.Text = "1";
            this.check2.UseVisualStyleBackColor = true;
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(6, 208);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(55, 28);
            this.check3.TabIndex = 5;
            this.check3.Text = "2";
            this.check3.UseVisualStyleBackColor = true;
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(6, 174);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(55, 28);
            this.check4.TabIndex = 4;
            this.check4.Text = "3";
            this.check4.UseVisualStyleBackColor = true;
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Location = new System.Drawing.Point(6, 140);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(55, 28);
            this.check5.TabIndex = 3;
            this.check5.Text = "4";
            this.check5.UseVisualStyleBackColor = true;
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Location = new System.Drawing.Point(6, 106);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(55, 28);
            this.check6.TabIndex = 2;
            this.check6.Text = "5";
            this.check6.UseVisualStyleBackColor = true;
            // 
            // check7
            // 
            this.check7.AutoSize = true;
            this.check7.Location = new System.Drawing.Point(6, 72);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(55, 28);
            this.check7.TabIndex = 1;
            this.check7.Text = "6";
            this.check7.UseVisualStyleBackColor = true;
            // 
            // check8
            // 
            this.check8.AutoSize = true;
            this.check8.Location = new System.Drawing.Point(6, 34);
            this.check8.Name = "check8";
            this.check8.Size = new System.Drawing.Size(55, 28);
            this.check8.TabIndex = 0;
            this.check8.Text = "7";
            this.check8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shiftDownBtn);
            this.Controls.Add(this.shiftUpBtn);
            this.Controls.Add(this.indexLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.toggleBtn);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.onBtn);
            this.Controls.Add(this.fromBitBtn);
            this.Controls.Add(this.toBitBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toBitBtn;
        private System.Windows.Forms.Button fromBitBtn;
        private System.Windows.Forms.Button onBtn;
        private System.Windows.Forms.Button offBtn;
        private System.Windows.Forms.Button toggleBtn;
        private System.Windows.Forms.TextBox numberLabel;
        private System.Windows.Forms.TextBox indexLabel;
        private System.Windows.Forms.Button shiftUpBtn;
        private System.Windows.Forms.Button shiftDownBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check5;
        private System.Windows.Forms.CheckBox check6;
        private System.Windows.Forms.CheckBox check7;
        private System.Windows.Forms.CheckBox check8;
    }
}

