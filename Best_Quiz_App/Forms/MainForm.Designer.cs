
namespace Best_Quiz_App.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.header_panel1 = new System.Windows.Forms.Panel();
            this.minimize_button3 = new System.Windows.Forms.Button();
            this.exit_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.header_panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel1
            // 
            this.header_panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header_panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.header_panel1.Controls.Add(this.minimize_button3);
            this.header_panel1.Controls.Add(this.exit_button1);
            this.header_panel1.Controls.Add(this.label1);
            this.header_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel1.ForeColor = System.Drawing.Color.White;
            this.header_panel1.Location = new System.Drawing.Point(0, 0);
            this.header_panel1.Name = "header_panel1";
            this.header_panel1.Size = new System.Drawing.Size(1602, 120);
            this.header_panel1.TabIndex = 0;
            // 
            // minimize_button3
            // 
            this.minimize_button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.minimize_button3.BackgroundImage = global::Best_Quiz_App.Properties.Resources.Minimize_butt;
            this.minimize_button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize_button3.Location = new System.Drawing.Point(1459, 38);
            this.minimize_button3.Name = "minimize_button3";
            this.minimize_button3.Size = new System.Drawing.Size(50, 43);
            this.minimize_button3.TabIndex = 2;
            this.minimize_button3.UseVisualStyleBackColor = false;
            this.minimize_button3.Click += new System.EventHandler(this.minimize_button3_Click);
            // 
            // exit_button1
            // 
            this.exit_button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_button1.BackgroundImage = global::Best_Quiz_App.Properties.Resources.exit;
            this.exit_button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_button1.Location = new System.Drawing.Point(1515, 38);
            this.exit_button1.Name = "exit_button1";
            this.exit_button1.Size = new System.Drawing.Size(50, 43);
            this.exit_button1.TabIndex = 1;
            this.exit_button1.UseVisualStyleBackColor = false;
            this.exit_button1.Click += new System.EventHandler(this.exit_button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Best Quiz App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1602, 945);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.header_panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.header_panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_button1;
        private System.Windows.Forms.Button play_quiz_button;
        private System.Windows.Forms.Button minimize_button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}