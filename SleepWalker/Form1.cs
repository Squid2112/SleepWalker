using System.Runtime.InteropServices;

namespace SleepWalker
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern uint SetThreadExecutionState(uint esFlags);

        private const uint ES_CONTINUOUS = 0x80000000;
        private const uint ES_SYSTEM_REQUIRED = 0x00000001;

        public Form1()
        {
            InitializeComponent();

            // Assign the icon from resources
            notifyIcon1.Icon = Properties.Resources.SleepWalkerIco;

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Hide();
        }

        private void preventSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreventSleep();
        }

        private void enableSleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableSleep();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PreventSleep()
        {
            SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED);
            notifyIcon1.ShowBalloonTip(1000, "SleepWalker", "Sleep mode disabled.", ToolTipIcon.Info);
        }

        private void EnableSleep()
        {
            SetThreadExecutionState(ES_CONTINUOUS);
            notifyIcon1.ShowBalloonTip(1000, "SleepWalker", "Sleep mode enabled.", ToolTipIcon.Info);
        }
    }
}
