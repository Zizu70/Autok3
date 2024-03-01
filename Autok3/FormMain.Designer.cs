namespace Autok3
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autókToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felvitelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Location = new System.Drawing.Point(40, 120);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 494);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(146, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Köszöntjük oldalunkon!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Válasszon márkát:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(333, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 461);
            this.panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autókToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autókToolStripMenuItem
            // 
            this.autókToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felvitelToolStripMenuItem,
            this.módosításToolStripMenuItem,
            this.törlésToolStripMenuItem});
            this.autókToolStripMenuItem.Name = "autókToolStripMenuItem";
            this.autókToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.autókToolStripMenuItem.Text = "Autók";
            // 
            // felvitelToolStripMenuItem
            // 
            this.felvitelToolStripMenuItem.Name = "felvitelToolStripMenuItem";
            this.felvitelToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.felvitelToolStripMenuItem.Text = "Felvitel";
            this.felvitelToolStripMenuItem.Click += new System.EventHandler(this.felvitelToolStripMenuItem_Click);
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            this.módosításToolStripMenuItem.Click += new System.EventHandler(this.módosításToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.törlésToolStripMenuItem.Text = "Törlés";
            this.törlésToolStripMenuItem.Click += new System.EventHandler(this.törlésToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(646, 642);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Autók";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autókToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felvitelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox1;
    }
}

