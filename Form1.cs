using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;
using System.Diagnostics;

namespace FFmpegGUI
{
    public partial class Form1 : Form
    {
        private string fileDirectory;
        private string outputFileName;
        private string outputDirectory;
        private decimal width;
        private decimal height;
        private decimal skipSecond;
        private decimal FPS;
        private string loopType = "0";
        private decimal GIFlength;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            pnlNav.MouseDown += pnlNav_MouseDown;
            tbOutputName.TextChanged += tbOutputName_TextChanged;
            tbOutputName.KeyPress += TbOutputName_KeyPress;
            nudSkipSecond.ValueChanged += NudSkipSecond_ValueChanged;
            nudFPS.ValueChanged += NudFPS_ValueChanged;
            nudGIFlength.ValueChanged += NudGIFlength_ValueChanged;
            nudHeight.ValueChanged += NudHeight_ValueChanged;
            nudWidth.ValueChanged += NudWidth_ValueChanged;
            cbLoopType.SelectionChangeCommitted += cbLoopType_SelectionChangeCommitted;
            cbSkipSecond.CheckedChanged += CbSkipSecond_CheckedChanged;
            cbGiflength.CheckedChanged += CbGiflength_CheckedChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<LoopTypeList> datalist = new List<LoopTypeList>();
            datalist.Add(new LoopTypeList() { Text = "Infinite Loop", Value = "0" });
            datalist.Add(new LoopTypeList() { Text = "Loop Once", Value = "1" });
            datalist.Add(new LoopTypeList() { Text = "No Loop", Value = "-1" });
            cbLoopType.DisplayMember = "Text";
            cbLoopType.ValueMember = "Value";
            cbLoopType.DataSource = datalist;

            //Give variable a default value
            width = 300;
            height = -1;
            FPS = 30;
        }

        private void CbGiflength_CheckedChanged(object sender, EventArgs e)
        {
            if (nudGIFlength.Enabled)
            {
                nudGIFlength.Enabled = false;
            }
            else
            {
                GIFlength = 1;
                nudGIFlength.Enabled = true;
            }
        }

        private void CbSkipSecond_CheckedChanged(object sender, EventArgs e)
        {
            if (nudSkipSecond.Enabled)
            {
                nudSkipSecond.Enabled = false;
            }
            else
            {
                skipSecond = 1;
                nudSkipSecond.Enabled = true;
            }
        }

        private void TbOutputName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[^?:\\/:*?\""<>|]"))
            {
                e.Handled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlNav_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnPickVideo_Click(object sender, EventArgs e)
        {
            fileDialog.Filter = "Video files(*.mp4,*.mkv)|*.mp4;*.mkv";
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileDirectory = fileDialog.FileName;
                lblDirectory.Text = fileDialog.FileName;
                outputFileName = Path.GetFileNameWithoutExtension(fileDialog.FileName);
                tbOutputName.Text = Path.GetFileNameWithoutExtension(fileDialog.FileName);
            }
        }

        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                outputDirectory = dialog.FileName;
                tbOutputDirectory.Text = dialog.FileName;
            }
        }

        private void NudSkipSecond_ValueChanged(object sender, EventArgs e)
        {
            skipSecond = nudSkipSecond.Value;
        }

        private void NudFPS_ValueChanged(object sender, EventArgs e)
        {
            FPS = nudFPS.Value;
        }

        private void NudWidth_ValueChanged(object sender, EventArgs e)
        {
            width = nudWidth.Value;
        }

        private void NudHeight_ValueChanged(object sender, EventArgs e)
        {
            height = nudHeight.Value;
        }

        private void NudGIFlength_ValueChanged(object sender, EventArgs e)
        {
            GIFlength = nudGIFlength.Value;
        }

        private void cbLoopType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoopTypeList obj = cbLoopType.SelectedItem as LoopTypeList;
            if (obj != null)
            {
                loopType = obj.Value;
            }
        }

        private void tbOutputName_TextChanged(object sender, EventArgs e)
        {
            outputFileName = tbOutputName.Text;
        }

        private bool check_IsVideoPicked()
        {
            if (String.IsNullOrEmpty(fileDirectory))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool check_OutputNameIsNull()
        {
            if (String.IsNullOrEmpty(outputFileName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool check_OutputDirectoryIsNull()
        {
            if (String.IsNullOrEmpty(outputDirectory))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ConvertToGIF(string filename, string commandLine)
        {
            var fileName = filename;
            var arguments = commandLine;

            var info = new ProcessStartInfo();
            info.FileName = fileName;
            info.Arguments = arguments;

            info.UseShellExecute = false;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.CreateNoWindow = true;

            using (var p = new Process())
            {
                p.StartInfo = info;
                p.EnableRaisingEvents = true;

                p.OutputDataReceived += (s, o) =>
                {
                    TxtBoxOutput(o.Data);
                };
                p.ErrorDataReceived += (s, o) =>
                {
                    TxtBoxOutput(o.Data);
                };
                p.Start();
                p.BeginOutputReadLine();
                p.BeginErrorReadLine();
                p.WaitForExit();
            }
        }

        public void TxtBoxOutput(string text)
        {
            BeginInvoke(new Action(delegate ()
            {
                rtbCmdOutput.AppendText(Environment.NewLine + text);
                rtbCmdOutput.ScrollToCaret();
            }));
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            rtbCmdOutput.Text = "";
            checkingAnyNull();
        }

        private void checkingAnyNull()
        {
            if (check_IsVideoPicked())
            {
                if (check_OutputNameIsNull())
                {
                    if (check_OutputDirectoryIsNull())
                    {
                        runConvertThread();
                    }
                    else
                    {
                        MessageBox.Show("Please set a output directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a file name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Please pick a video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void runConvertThread()
        {
            var command = "ffmpeg ";

            if (cbSkipSecond.Checked)
            {
                command += $"-ss {skipSecond} ";
            }

            if (cbGiflength.Checked)
            {
                command += $"-t {GIFlength} ";
            }

            command += $"-i \"{fileDirectory}\" -vf \"fps = {FPS},scale = {width}:{height}:flags = lanczos,split[s0][s1];[s0]palettegen[p];[s1][p]paletteuse\" -loop {loopType} \"{outputDirectory}\\{outputFileName}.gif\"";

            await Task.Factory.StartNew(() =>
            {
                ConvertToGIF("cmd.exe", "/C " + command);
            });
        }
    }
}
