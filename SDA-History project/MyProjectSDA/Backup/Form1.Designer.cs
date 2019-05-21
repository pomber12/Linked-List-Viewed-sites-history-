namespace OC.Windows.Forms
{
    partial class Form1
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
            if (disposing && history != null)
            {
                history.Dispose();
            }
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
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolstrip1 = new System.Windows.Forms.ToolStrip();
            this.tssbBack = new System.Windows.Forms.ToolStripSplitButton();
            this.tssbForward = new System.Windows.Forms.ToolStripSplitButton();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbDuplicates = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N"});
            this.listBox1.Location = new System.Drawing.Point(0, 25);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 186);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // toolstrip1
            // 
            this.toolstrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssbBack,
            this.tssbForward,
            toolStripSeparator1,
            this.tsbClear,
            this.tsbDuplicates});
            this.toolstrip1.Location = new System.Drawing.Point(0, 0);
            this.toolstrip1.Name = "toolstrip1";
            this.toolstrip1.Size = new System.Drawing.Size(188, 25);
            this.toolstrip1.TabIndex = 3;
            this.toolstrip1.Text = "Back";
            // 
            // tssbBack
            // 
            this.tssbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbBack.Image = ((System.Drawing.Image)(resources.GetObject("tssbBack.Image")));
            this.tssbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbBack.Name = "tssbBack";
            this.tssbBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tssbBack.Size = new System.Drawing.Size(32, 22);
            this.tssbBack.Text = "&Back";
            // 
            // tssbForward
            // 
            this.tssbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbForward.Image = ((System.Drawing.Image)(resources.GetObject("tssbForward.Image")));
            this.tssbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbForward.Name = "tssbForward";
            this.tssbForward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tssbForward.Size = new System.Drawing.Size(32, 22);
            this.tssbForward.Text = "&Forward";
            // 
            // tsbClear
            // 
            this.tsbClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClear.Image = ((System.Drawing.Image)(resources.GetObject("tsbClear.Image")));
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(36, 22);
            this.tsbClear.Text = "Clear";
            this.tsbClear.ToolTipText = "Clear";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbDuplicates
            // 
            this.tsbDuplicates.CheckOnClick = true;
            this.tsbDuplicates.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDuplicates.Image = ((System.Drawing.Image)(resources.GetObject("tsbDuplicates.Image")));
            this.tsbDuplicates.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDuplicates.Name = "tsbDuplicates";
            this.tsbDuplicates.Size = new System.Drawing.Size(60, 22);
            this.tsbDuplicates.Text = "Duplicates";
            this.tsbDuplicates.ToolTipText = "Allow Duplicates";
            this.tsbDuplicates.CheckedChanged += new System.EventHandler(this.tsbDuplicates_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 211);
            this.Controls.Add(this.toolstrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "  History<T>";
            this.toolstrip1.ResumeLayout(false);
            this.toolstrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolstrip1;
        private System.Windows.Forms.ToolStripSplitButton tssbBack;
        private System.Windows.Forms.ToolStripSplitButton tssbForward;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbDuplicates;
    }
}

