namespace WSRussia
{
    partial class PTitle
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGoAboutWS = new System.Windows.Forms.Button();
            this.buttonGoAboutWSR = new System.Windows.Forms.Button();
            this.buttonGoAboutPrim = new System.Windows.Forms.Button();
            this.buttonGoLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGoAboutWS
            // 
            this.buttonGoAboutWS.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGoAboutWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoAboutWS.Location = new System.Drawing.Point(203, 43);
            this.buttonGoAboutWS.Name = "buttonGoAboutWS";
            this.buttonGoAboutWS.Size = new System.Drawing.Size(378, 80);
            this.buttonGoAboutWS.TabIndex = 0;
            this.buttonGoAboutWS.Text = "О WorldSkills";
            this.buttonGoAboutWS.UseVisualStyleBackColor = false;
            this.buttonGoAboutWS.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonGoAboutWSR
            // 
            this.buttonGoAboutWSR.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGoAboutWSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoAboutWSR.Location = new System.Drawing.Point(203, 143);
            this.buttonGoAboutWSR.Name = "buttonGoAboutWSR";
            this.buttonGoAboutWSR.Size = new System.Drawing.Size(378, 80);
            this.buttonGoAboutWSR.TabIndex = 1;
            this.buttonGoAboutWSR.Text = "О WorldSkills Russia";
            this.buttonGoAboutWSR.UseVisualStyleBackColor = false;
            this.buttonGoAboutWSR.Click += new System.EventHandler(this.buttonGoAboutWSR_Click);
            // 
            // buttonGoAboutPrim
            // 
            this.buttonGoAboutPrim.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGoAboutPrim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoAboutPrim.Location = new System.Drawing.Point(203, 243);
            this.buttonGoAboutPrim.Name = "buttonGoAboutPrim";
            this.buttonGoAboutPrim.Size = new System.Drawing.Size(378, 80);
            this.buttonGoAboutPrim.TabIndex = 2;
            this.buttonGoAboutPrim.Text = "О Приморском крае";
            this.buttonGoAboutPrim.UseVisualStyleBackColor = false;
            this.buttonGoAboutPrim.Click += new System.EventHandler(this.buttonGoAboutPrim_Click);
            // 
            // buttonGoLogin
            // 
            this.buttonGoLogin.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonGoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGoLogin.Location = new System.Drawing.Point(682, 331);
            this.buttonGoLogin.Name = "buttonGoLogin";
            this.buttonGoLogin.Size = new System.Drawing.Size(80, 49);
            this.buttonGoLogin.TabIndex = 3;
            this.buttonGoLogin.Text = "Login";
            this.buttonGoLogin.UseVisualStyleBackColor = false;
            this.buttonGoLogin.Click += new System.EventHandler(this.buttonGoLogin_Click);
            // 
            // PTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonGoLogin);
            this.Controls.Add(this.buttonGoAboutPrim);
            this.Controls.Add(this.buttonGoAboutWSR);
            this.Controls.Add(this.buttonGoAboutWS);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PTitle";
            this.Size = new System.Drawing.Size(784, 400);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGoAboutWS;
        private System.Windows.Forms.Button buttonGoAboutWSR;
        private System.Windows.Forms.Button buttonGoAboutPrim;
        public System.Windows.Forms.Button buttonGoLogin;
    }
}
