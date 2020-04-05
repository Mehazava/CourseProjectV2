namespace WSRussia
{
    partial class PAdministrator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGreeting = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.labelGreeting);
            this.panel1.Location = new System.Drawing.Point(13, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 385);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(247, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 90);
            this.button2.TabIndex = 7;
            this.button2.Text = "Управление участниками";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(247, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 90);
            this.button1.TabIndex = 6;
            this.button1.Text = "Управление чемпионатами";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGreeting
            // 
            this.labelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGreeting.Location = new System.Drawing.Point(217, 19);
            this.labelGreeting.Name = "labelGreeting";
            this.labelGreeting.Size = new System.Drawing.Size(323, 40);
            this.labelGreeting.TabIndex = 5;
            this.labelGreeting.Text = "Добро!";
            this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Name = "PAdministrator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PAdministrator_Paint);
            this.Controls.SetChildIndex(this.labelPageTitle, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGreeting;
    }
}
