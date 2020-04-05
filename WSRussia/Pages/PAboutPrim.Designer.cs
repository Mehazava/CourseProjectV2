namespace WSRussia
{
    partial class PAboutPrim
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HistoryTabPage = new System.Windows.Forms.TabPage();
            this.EventsTabPage = new System.Windows.Forms.TabPage();
            this.TourismTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HistoryTabPage);
            this.tabControl1.Controls.Add(this.EventsTabPage);
            this.tabControl1.Controls.Add(this.TourismTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(23, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 376);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // HistoryTabPage
            // 
            this.HistoryTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryTabPage.Location = new System.Drawing.Point(4, 34);
            this.HistoryTabPage.Name = "HistoryTabPage";
            this.HistoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryTabPage.Size = new System.Drawing.Size(732, 338);
            this.HistoryTabPage.TabIndex = 0;
            this.HistoryTabPage.Text = "История";
            this.HistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // EventsTabPage
            // 
            this.EventsTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EventsTabPage.Location = new System.Drawing.Point(4, 34);
            this.EventsTabPage.Name = "EventsTabPage";
            this.EventsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EventsTabPage.Size = new System.Drawing.Size(732, 338);
            this.EventsTabPage.TabIndex = 1;
            this.EventsTabPage.Text = "События";
            this.EventsTabPage.UseVisualStyleBackColor = true;
            // 
            // TourismTabPage
            // 
            this.TourismTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TourismTabPage.Location = new System.Drawing.Point(4, 34);
            this.TourismTabPage.Name = "TourismTabPage";
            this.TourismTabPage.Size = new System.Drawing.Size(732, 338);
            this.TourismTabPage.TabIndex = 2;
            this.TourismTabPage.Text = "Туризм";
            this.TourismTabPage.UseVisualStyleBackColor = true;
            // 
            // PAboutPrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.tabControl1);
            this.Name = "PAboutPrim";
            this.Controls.SetChildIndex(this.labelPageTitle, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HistoryTabPage;
        private System.Windows.Forms.TabPage EventsTabPage;
        private System.Windows.Forms.TabPage TourismTabPage;
    }
}
