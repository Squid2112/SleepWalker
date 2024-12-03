namespace SleepWalker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preventSleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.preventSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "SleepWalker";
            this.notifyIcon1.Visible = true;
            // Icon is set in Form1.cs constructor

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preventSleepToolStripMenuItem,
            this.enableSleepToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);

            // 
            // preventSleepToolStripMenuItem
            // 
            this.preventSleepToolStripMenuItem.Name = "preventSleepToolStripMenuItem";
            this.preventSleepToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preventSleepToolStripMenuItem.Text = "Prevent Sleep";
            this.preventSleepToolStripMenuItem.Click += new System.EventHandler(this.preventSleepToolStripMenuItem_Click);

            // 
            // enableSleepToolStripMenuItem
            // 
            this.enableSleepToolStripMenuItem.Name = "enableSleepToolStripMenuItem";
            this.enableSleepToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.enableSleepToolStripMenuItem.Text = "Enable Sleep";
            this.enableSleepToolStripMenuItem.Click += new System.EventHandler(this.enableSleepToolStripMenuItem_Click);

            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
        }

        #endregion
    }
}
