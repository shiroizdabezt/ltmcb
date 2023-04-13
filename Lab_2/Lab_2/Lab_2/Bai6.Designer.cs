namespace Lab_2
{
    partial class Bai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tree_caythumuc = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // tree_caythumuc
            // 
            this.tree_caythumuc.Location = new System.Drawing.Point(1, 2);
            this.tree_caythumuc.Name = "tree_caythumuc";
            this.tree_caythumuc.Size = new System.Drawing.Size(383, 681);
            this.tree_caythumuc.TabIndex = 1;
            this.tree_caythumuc.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tree_caythumuc_BeforeExpand);
            this.tree_caythumuc.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_caythumuc_AfterSelect);
            this.tree_caythumuc.DoubleClick += new System.EventHandler(this.tree_caythumuc_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(390, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(702, 681);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 686);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tree_caythumuc);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView tree_caythumuc;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}