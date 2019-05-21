namespace MyProjectSDA
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolstrip1 = new System.Windows.Forms.ToolStrip();
            this.Button1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolstrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "facebook.com",
            "zamunda.net",
            "youtub.com",
            "unibit.bg",
            "yahoo.com",
            "github.com",
            "wikipedia.org"});
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
            this.Button1});
            this.toolstrip1.Location = new System.Drawing.Point(0, 0);
            this.toolstrip1.Name = "toolstrip1";
            this.toolstrip1.Size = new System.Drawing.Size(188, 25);
            this.toolstrip1.TabIndex = 3;
            this.toolstrip1.Text = "Back";
            // 
            // Button1
            // 
            this.Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Button1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Button1.Name = "Button1";
            this.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Button1.Size = new System.Drawing.Size(16, 22);
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
            this.Text = "MyProjectSDA<T>";
            this.toolstrip1.ResumeLayout(false);
            this.toolstrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStrip toolstrip1;
        private System.Windows.Forms.ToolStripSplitButton Button1;
    }
}

