namespace WSRussia
{
    partial class PCompetencies
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Обслуживание гражданского транспорта");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Специалисты строительной сферы");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Специалисты, занятые на промышленном производстве");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Специалисты информационных и коммуникационных технологий");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Творчество и дизаин");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Сфера услуг");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Все компетенции                               ", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.treeView1.Indent = 10;
            this.treeView1.Location = new System.Drawing.Point(13, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.NodeFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.Text = "Обслуживание гражданского транспорта";
            treeNode2.Name = "Node2";
            treeNode2.NodeFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode2.Text = "Специалисты строительной сферы";
            treeNode3.Name = "Node3";
            treeNode3.NodeFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode3.Text = "Специалисты, занятые на промышленном производстве";
            treeNode4.Name = "Node4";
            treeNode4.NodeFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode4.Text = "Специалисты информационных и коммуникационных технологий";
            treeNode5.Name = "Node5";
            treeNode5.NodeFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode5.Text = "Творчество и дизаин";
            treeNode6.Name = "Node6";
            treeNode6.NodeFont = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode6.Text = "Сфера услуг";
            treeNode7.Name = "Узел0";
            treeNode7.NodeFont = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode7.Text = "Все компетенции                               ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView1.Size = new System.Drawing.Size(246, 371);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TextBoxDescription);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(265, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 371);
            this.panel1.TabIndex = 3;
            // 
            // TextBoxDescription
            // 
            this.TextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDescription.Location = new System.Drawing.Point(3, 26);
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBoxDescription.Size = new System.Drawing.Size(498, 340);
            this.TextBoxDescription.TabIndex = 1;
            this.TextBoxDescription.Text = "";
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Name = "labelName";
            this.labelName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelName.Size = new System.Drawing.Size(506, 23);
            this.labelName.TabIndex = 0;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PCompetencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treeView1);
            this.Name = "PCompetencies";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PCompetencies_Paint);
            this.Controls.SetChildIndex(this.labelPageTitle, 0);
            this.Controls.SetChildIndex(this.treeView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TextBoxDescription;
        private System.Windows.Forms.Label labelName;
    }
}
