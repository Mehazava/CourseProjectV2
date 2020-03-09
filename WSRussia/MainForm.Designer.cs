namespace WSRussia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelCLocation = new System.Windows.Forms.Label();
            this.labelCTime = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(760, 40);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "WorldSkills Russia 2020";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeRemaining.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTimeRemaining.Location = new System.Drawing.Point(12, 537);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(760, 22);
            this.labelTimeRemaining.TabIndex = 1;
            this.labelTimeRemaining.Text = "-Time remaining error-";
            this.labelTimeRemaining.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(129, 23);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 26);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelCLocation
            // 
            this.labelCLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCLocation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCLocation.Location = new System.Drawing.Point(212, 66);
            this.labelCLocation.Name = "labelCLocation";
            this.labelCLocation.Size = new System.Drawing.Size(360, 28);
            this.labelCLocation.TabIndex = 4;
            this.labelCLocation.Text = "Владивосток, Россия";
            this.labelCLocation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelCTime
            // 
            this.labelCTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelCTime.Location = new System.Drawing.Point(214, 94);
            this.labelCTime.Name = "labelCTime";
            this.labelCTime.Size = new System.Drawing.Size(360, 28);
            this.labelCTime.TabIndex = 5;
            this.labelCTime.Text = "Вторник, 2 апреля 2020";
            this.labelCTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.BackColor = System.Drawing.SystemColors.Control;
            this.panelPage.Location = new System.Drawing.Point(0, 134);
            this.panelPage.Name = "panelPage";
            this.panelPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelPage.Size = new System.Drawing.Size(784, 400);
            this.panelPage.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.labelCTime);
            this.Controls.Add(this.labelCLocation);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelTimeRemaining);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WSR 2020";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelCLocation;
        private System.Windows.Forms.Label labelCTime;
        private System.Windows.Forms.Panel panelPage;
    }
}

