namespace WSRussia
{
    partial class PLoadVolonteur
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
            this.labelSLoad = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonSeek = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSLoad
            // 
            this.labelSLoad.AutoSize = true;
            this.labelSLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSLoad.Location = new System.Drawing.Point(100, 93);
            this.labelSLoad.Name = "labelSLoad";
            this.labelSLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSLoad.Size = new System.Drawing.Size(175, 16);
            this.labelSLoad.TabIndex = 1;
            this.labelSLoad.Text = "Загрузка волонтеров:";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(281, 92);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(187, 20);
            this.textBoxFileName.TabIndex = 2;
            // 
            // buttonSeek
            // 
            this.buttonSeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeek.Location = new System.Drawing.Point(483, 90);
            this.buttonSeek.Name = "buttonSeek";
            this.buttonSeek.Size = new System.Drawing.Size(87, 23);
            this.buttonSeek.TabIndex = 3;
            this.buttonSeek.Text = "Просмотр...";
            this.buttonSeek.UseVisualStyleBackColor = true;
            this.buttonSeek.Click += new System.EventHandler(this.buttonSeek_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(281, 155);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLoad.Size = new System.Drawing.Size(88, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Загрузка";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Enabled = false;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(375, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCancel.Size = new System.Drawing.Size(93, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelLine1
            // 
            this.labelLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine1.Location = new System.Drawing.Point(3, 371);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLine1.Size = new System.Drawing.Size(778, 23);
            this.labelLine1.TabIndex = 6;
            this.labelLine1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLine2
            // 
            this.labelLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLine2.Location = new System.Drawing.Point(3, 394);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLine2.Size = new System.Drawing.Size(778, 23);
            this.labelLine2.TabIndex = 7;
            this.labelLine2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PLoadVolonteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.labelLine1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSeek);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelSLoad);
            this.Name = "PLoadVolonteur";
            this.Controls.SetChildIndex(this.labelPageTitle, 0);
            this.Controls.SetChildIndex(this.labelSLoad, 0);
            this.Controls.SetChildIndex(this.textBoxFileName, 0);
            this.Controls.SetChildIndex(this.buttonSeek, 0);
            this.Controls.SetChildIndex(this.buttonLoad, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.labelLine1, 0);
            this.Controls.SetChildIndex(this.labelLine2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSLoad;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonSeek;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
    }
}
