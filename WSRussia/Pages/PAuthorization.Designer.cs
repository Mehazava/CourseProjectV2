namespace WSRussia
{
    partial class PAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoginId = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginId = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.buttonLoginGo = new System.Windows.Forms.Button();
            this.buttonCancelLogin = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.comboBoxPersonType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 72);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(539, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пожалуйста, авторизируйтесь в системе, используя ваш ID и пароль.";
            // 
            // labelLoginId
            // 
            this.labelLoginId.AutoSize = true;
            this.labelLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginId.Location = new System.Drawing.Point(109, 167);
            this.labelLoginId.Name = "labelLoginId";
            this.labelLoginId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLoginId.Size = new System.Drawing.Size(85, 20);
            this.labelLoginId.TabIndex = 2;
            this.labelLoginId.Text = "Id number:";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginPassword.Location = new System.Drawing.Point(109, 209);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLoginPassword.Size = new System.Drawing.Size(82, 20);
            this.labelLoginPassword.TabIndex = 3;
            this.labelLoginPassword.Text = "Password:";
            // 
            // textBoxLoginId
            // 
            this.textBoxLoginId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginId.Location = new System.Drawing.Point(200, 164);
            this.textBoxLoginId.Name = "textBoxLoginId";
            this.textBoxLoginId.Size = new System.Drawing.Size(345, 26);
            this.textBoxLoginId.TabIndex = 4;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLoginPassword.Location = new System.Drawing.Point(200, 206);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(345, 26);
            this.textBoxLoginPassword.TabIndex = 5;
            // 
            // buttonLoginGo
            // 
            this.buttonLoginGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginGo.Location = new System.Drawing.Point(215, 413);
            this.buttonLoginGo.Name = "buttonLoginGo";
            this.buttonLoginGo.Size = new System.Drawing.Size(103, 29);
            this.buttonLoginGo.TabIndex = 6;
            this.buttonLoginGo.Text = "Login";
            this.buttonLoginGo.UseVisualStyleBackColor = true;
            this.buttonLoginGo.Click += new System.EventHandler(this.buttonLoginGo_Click);
            // 
            // buttonCancelLogin
            // 
            this.buttonCancelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancelLogin.Location = new System.Drawing.Point(324, 413);
            this.buttonCancelLogin.Name = "buttonCancelLogin";
            this.buttonCancelLogin.Size = new System.Drawing.Size(103, 29);
            this.buttonCancelLogin.TabIndex = 7;
            this.buttonCancelLogin.Text = "Cancel";
            this.buttonCancelLogin.UseVisualStyleBackColor = true;
            this.buttonCancelLogin.Click += new System.EventHandler(this.buttonCancelLogin_Click);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxRemember.Location = new System.Drawing.Point(442, 416);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(133, 24);
            this.checkBoxRemember.TabIndex = 8;
            this.checkBoxRemember.Text = "Remember me";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // comboBoxPersonType
            // 
            this.comboBoxPersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPersonType.FormattingEnabled = true;
            this.comboBoxPersonType.Items.AddRange(new object[] {
            "Participant",
            "Coordinator",
            "Expert",
            "Administrator"});
            this.comboBoxPersonType.Location = new System.Drawing.Point(563, 206);
            this.comboBoxPersonType.Name = "comboBoxPersonType";
            this.comboBoxPersonType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPersonType.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(595, 179);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "I am:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(184, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 121);
            this.panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(199, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "V4XBG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(182, 32);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(190, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите код с картинки:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxPersonType);
            this.Controls.Add(this.checkBoxRemember);
            this.Controls.Add(this.buttonCancelLogin);
            this.Controls.Add(this.buttonLoginGo);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLoginId);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelLoginId);
            this.Controls.Add(this.label1);
            this.Name = "PAuthorization";
            this.Controls.SetChildIndex(this.labelPageTitle, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.labelLoginId, 0);
            this.Controls.SetChildIndex(this.labelLoginPassword, 0);
            this.Controls.SetChildIndex(this.textBoxLoginId, 0);
            this.Controls.SetChildIndex(this.textBoxLoginPassword, 0);
            this.Controls.SetChildIndex(this.buttonLoginGo, 0);
            this.Controls.SetChildIndex(this.buttonCancelLogin, 0);
            this.Controls.SetChildIndex(this.checkBoxRemember, 0);
            this.Controls.SetChildIndex(this.comboBoxPersonType, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLoginId;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.TextBox textBoxLoginId;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Button buttonLoginGo;
        private System.Windows.Forms.Button buttonCancelLogin;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.ComboBox comboBoxPersonType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}
