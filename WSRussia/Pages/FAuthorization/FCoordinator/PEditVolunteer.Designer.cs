namespace WSRussia
{
    partial class PEditVolonteur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxCompetention = new System.Windows.Forms.ComboBox();
            this.labelSCompetention = new System.Windows.Forms.Label();
            this.buttonFileLoad = new System.Windows.Forms.Button();
            this.buttonDistribute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSCount = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCompetention
            // 
            this.comboBoxCompetention.FormattingEnabled = true;
            this.comboBoxCompetention.Items.AddRange(new object[] {
            "Все компетенции"});
            this.comboBoxCompetention.Location = new System.Drawing.Point(127, 80);
            this.comboBoxCompetention.MaxDropDownItems = 30;
            this.comboBoxCompetention.Name = "comboBoxCompetention";
            this.comboBoxCompetention.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxCompetention.Size = new System.Drawing.Size(260, 21);
            this.comboBoxCompetention.TabIndex = 1;
            this.comboBoxCompetention.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompetention_SelectedIndexChanged);
            // 
            // labelSCompetention
            // 
            this.labelSCompetention.AutoSize = true;
            this.labelSCompetention.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSCompetention.Location = new System.Drawing.Point(10, 81);
            this.labelSCompetention.Name = "labelSCompetention";
            this.labelSCompetention.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSCompetention.Size = new System.Drawing.Size(110, 16);
            this.labelSCompetention.TabIndex = 2;
            this.labelSCompetention.Text = "Компетенция:";
            // 
            // buttonFileLoad
            // 
            this.buttonFileLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFileLoad.Location = new System.Drawing.Point(393, 78);
            this.buttonFileLoad.Name = "buttonFileLoad";
            this.buttonFileLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFileLoad.Size = new System.Drawing.Size(134, 23);
            this.buttonFileLoad.TabIndex = 3;
            this.buttonFileLoad.Text = "Загрузка с фаила";
            this.buttonFileLoad.UseVisualStyleBackColor = true;
            this.buttonFileLoad.Click += new System.EventHandler(this.buttonFileLoad_Click);
            // 
            // buttonDistribute
            // 
            this.buttonDistribute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDistribute.Location = new System.Drawing.Point(533, 78);
            this.buttonDistribute.Name = "buttonDistribute";
            this.buttonDistribute.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonDistribute.Size = new System.Drawing.Size(215, 23);
            this.buttonDistribute.TabIndex = 4;
            this.buttonDistribute.Text = "Распределить по компетенциям";
            this.buttonDistribute.UseVisualStyleBackColor = true;
            this.buttonDistribute.Click += new System.EventHandler(this.buttonDistribute_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle30.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(13, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(758, 305);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle31;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle32;
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle33;
            this.Column3.HeaderText = "Пол";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle34;
            this.Column4.HeaderText = "Регион";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle35;
            this.Column5.HeaderText = "Компетенция";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // labelSCount
            // 
            this.labelSCount.AutoSize = true;
            this.labelSCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSCount.Location = new System.Drawing.Point(259, 114);
            this.labelSCount.Name = "labelSCount";
            this.labelSCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSCount.Size = new System.Drawing.Size(133, 15);
            this.labelSCount.TabIndex = 6;
            this.labelSCount.Text = "Всего волонтеров:";
            this.labelSCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(398, 114);
            this.labelCount.Name = "labelCount";
            this.labelCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCount.Size = new System.Drawing.Size(0, 15);
            this.labelCount.TabIndex = 7;
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PEditVolonteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.labelSCount);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDistribute);
            this.Controls.Add(this.buttonFileLoad);
            this.Controls.Add(this.labelSCompetention);
            this.Controls.Add(this.comboBoxCompetention);
            this.Name = "PEditVolonteur";
            this.Load += new System.EventHandler(this.PEditVolonteur_Load);
            this.Controls.SetChildIndex(this.labelPageTitle, 0);
            this.Controls.SetChildIndex(this.comboBoxCompetention, 0);
            this.Controls.SetChildIndex(this.labelSCompetention, 0);
            this.Controls.SetChildIndex(this.buttonFileLoad, 0);
            this.Controls.SetChildIndex(this.buttonDistribute, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.labelSCount, 0);
            this.Controls.SetChildIndex(this.labelCount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCompetention;
        private System.Windows.Forms.Label labelSCompetention;
        private System.Windows.Forms.Button buttonFileLoad;
        private System.Windows.Forms.Button buttonDistribute;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label labelSCount;
        private System.Windows.Forms.Label labelCount;
    }
}
