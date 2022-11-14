using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace CopyFileOrDirectoryFromRemoteComputer
{
    public partial class FrmMain : Form
    {
        public string DestinationFileOrDirectoryPath;
        public string DestinationIpAdress;
        public string SourcePath;

        public FrmMain()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private bool PingHost(string hedefIpAdresi)
        {
            var pingable = false;
            var pinger = new Ping();

            try
            {
                var reply = pinger.Send(hedefIpAdresi);
                if (reply != null) pingable = reply.Status == IPStatus.Success;
            }
            catch (Exception)
            {
                return false;
            }

            return pingable;
        }

        private void RunPsExec(string remoteComputer, string processName, string exeParameters)
        {
            var psExecPath = Application.StartupPath + @"\PsExec.exe";

            var command = processName + " " + exeParameters;
            var rComputer = @"\\" + remoteComputer;
            var parametre = " -accepteula -s " + rComputer + " " + command;

            var psExecProcess = new Process
            {
                StartInfo =
                {
                    FileName = psExecPath,
                    Arguments = parametre,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                }
            };
            psExecProcess.Start();

            var output = psExecProcess.StandardOutput;
            string line;
            while ((line = output.ReadLine()) != null) rtb_log.AppendText(line + Environment.NewLine);
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            SourcePath = tb_sourcePath.Text.Trim();
            DestinationIpAdress = tb_destinationIpAdress.Text.Trim();
            DestinationFileOrDirectoryPath = tb_destinationFileOrDirectoryPath.Text.Trim();


            if (SourcePath != "")
            {
                if (DestinationIpAdress != "")
                {
                    if (DestinationFileOrDirectoryPath != "")
                    {
                        if (PingHost(DestinationIpAdress))
                        {
                            if (bw_copy.IsBusy != true)
                            {
                                bw_copy.RunWorkerAsync();
                                rtb_log.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Ping error!", @"Info");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Destination file or directory cannot be blank.", @"Info");
                    }
                }
                else
                {
                    MessageBox.Show(@"Destination ip adress cannot be blank.", @"Info");
                }
            }

            else
            {
                MessageBox.Show(@"Source path cannot be blank.", @"Info");
            }
        }

        private void bw_copy_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((MethodInvoker) delegate { });


            // Xcopy - Directory copy
            RunPsExec(DestinationIpAdress, @"C:\Windows\System32\cmd.exe",
                @"/c Xcopy /E /H /C /I /Y ""\\" + SourcePath + @""" """ + DestinationFileOrDirectoryPath + @"""");

            // Xcopy - Directory copy & install
            //RunPsExec(DestinationIpAdress, @"C:\Windows\System32\cmd.exe",
            //    @"/c Xcopy /E /H /C /I /Y ""\\"+SourcePath+@""" """+DestinationFileOrDirectoryPath+@""" && ""Z:\_setup\install.cmd""");

            // Xcopy - Directory copy
            //RunPsExec(DestinationIpAdress, @"C:\Windows\System32\cmd.exe",
            //    @"/c Xcopy /E /H /C /I /Y ""\\" + SourcePath + @""" """ + DestinationFileOrDirectoryPath + @"""");

            // Xcopy - File copy
            //RunPsExec(DestinationIpAdress, @"C:\Windows\System32\cmd.exe",
            //    @"/c echo F|Xcopy /S /Q /Y /F ""\\" + SourcePath + @"\opera33x86.exe"" ""Z:\_setup\opera33x86.exe""");

            // Copy - File copy
            //RunPsExec(DestinationIpAdress, @"C:\Windows\System32\cmd.exe",
            //    @"/c COPY /y ""\\" + SourcePath + @"\MicrosoftPowerBI.exe"" ""Z:\_setup\MicrosoftPowerBI.exe""");
        }

        private void bw_copy_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(@"Completed", @"Info");
        }
    }
}