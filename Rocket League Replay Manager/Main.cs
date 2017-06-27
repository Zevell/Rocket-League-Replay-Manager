using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocket_League_Replay_Manager
{
    public partial class Main : Form
    {
        string[] fileNames = new string[500];
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            try
            {
                string RLDemoDir = Environment.ExpandEnvironmentVariables(txtReplayDirectory.Text + "\\");
                int i = 0;

                foreach (string file in Directory.EnumerateFiles(RLDemoDir, "*.replay"))
                {
                    string line;
                    using (StreamReader file2 = new StreamReader(file))
                    {
                        while ((line = file2.ReadLine()) != null)
                        {
                            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                            line = rgx.Replace(line, "");

                            if (line.Contains("BoolPropertyNoneReplayNameStrProperty"))
                            {
                                line = line.Replace("BoolPropertyNoneReplayNameStrProperty", "");
                                line = line.Split(new string[] { "ReplayVersion" }, StringSplitOptions.None)[0];

                                if (line == "" || line == " ")
                                {
                                    line = "Unnamed Replay";
                                }
                                

                                dropdown1.AddItem(line);
                                fileNames[i] = file.Replace(RLDemoDir, "");
                                i++;
                            }
                        }
                    }
                }
            }
            catch { }
        }


        // Window Movement //
        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        // --Window Movement-- //

        private void RLPic_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.rocketleague.com/");
            }
            catch { }
        }

        private void RLPic_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void img_RLPic_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private async void AnimateProgress(int progress, int delay = 1, bool fast = false)
        {
            try
            {
                prgbar1.Visible = true;

                for (int i = 0; i < progress + 1; i++)
                {
                    await Task.Delay(delay);
                    if (fast == true)
                    {
                        i = i + 2;
                        if (prgbar1.Value >= 98)
                        {
                            prgbar1.Value = 100;
                        }
                        else
                        {
                            prgbar1.Value = i;
                        }
                    }
                    else
                    {
                        prgbar1.Value = i;
                    }
                }

                await Task.Delay(200);
                prgbar1.Visible = false;
                prgbar1.Value = 0;
            }
            catch { }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropdown1.selectedIndex == -1)
                {
                    lblFileCopied.Text = "Please select a replay...";
                    lblFileCopied.Visible = true;
                    return;
                }

                string RLDemoDir = Environment.ExpandEnvironmentVariables(txtReplayDirectory.Text + "\\");
                string DesktopDir = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Desktop\\");
                AnimateProgress(100, 1, true);
                File.Copy(RLDemoDir + fileNames[dropdown1.selectedIndex], DesktopDir + fileNames[dropdown1.selectedIndex], true);
                await Task.Delay(600);     

                lblFileCopied.Text = fileNames[dropdown1.selectedIndex] + " exported to Desktop";
                lblFileCopied.Visible = true;
            }
            catch { }
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                string RLDemoDir = Environment.ExpandEnvironmentVariables(txtReplayDirectory.Text + "\\");

                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.Filter = "Replay Files|*.replay";
                openFileDialog1.Title = "Select a Replay File";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    AnimateProgress(100, 1, true);
                    File.Copy(openFileDialog1.FileName, RLDemoDir + Path.GetFileName(openFileDialog1.FileName), true);
                    await Task.Delay(600);

                    lblFileCopied.Text = Path.GetFileName(openFileDialog1.FileName) + " imported to Rocket League";
                    lblFileCopied.Visible = true;
                }
            }
            catch { }
        }
    }
}
