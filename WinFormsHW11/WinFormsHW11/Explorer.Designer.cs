namespace WinFormsHW11
{
    partial class Explorer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewExplorerFile = new System.Windows.Forms.TreeView();
            this.listViewExplorer = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewExplorerFile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewExplorer);
            this.splitContainer1.Size = new System.Drawing.Size(661, 511);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeViewExplorerFile
            // 
            this.treeViewExplorerFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewExplorerFile.Location = new System.Drawing.Point(0, 0);
            this.treeViewExplorerFile.Name = "treeViewExplorerFile";
            this.treeViewExplorerFile.Size = new System.Drawing.Size(220, 511);
            this.treeViewExplorerFile.TabIndex = 0;
            this.treeViewExplorerFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TreeViewExplorerFile_MouseClick);
            // 
            // listViewExplorer
            // 
            this.listViewExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExplorer.Location = new System.Drawing.Point(0, 0);
            this.listViewExplorer.Name = "listViewExplorer";
            this.listViewExplorer.Size = new System.Drawing.Size(437, 511);
            this.listViewExplorer.TabIndex = 0;
            this.listViewExplorer.UseCompatibleStateImageBehavior = false;
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Explorer";
            this.Text = "Explorer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewExplorerFile;
        private System.Windows.Forms.ListView listViewExplorer;
    }
}

