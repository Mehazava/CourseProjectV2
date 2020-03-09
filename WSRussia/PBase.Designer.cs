namespace WSRussia
{
    partial class PBase
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
            this.labelPageTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelPageTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPageTitle.Location = new System.Drawing.Point(3, 0);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(778, 47);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "Page title";
            this.labelPageTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPageTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PBase";
            this.Size = new System.Drawing.Size(784, 468);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label labelPageTitle;
    }
}
