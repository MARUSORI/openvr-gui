using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace openvr_gui
{

    public partial class Form1 : Form
    {
        [DllImport("User32")]
        private static extern int ShowWindow(int hwnd, int nCmdShow);

        private static readonly string STEAM_DIR = @"G:\Program Files\Steam\Steam.exe";
        private static readonly string PSMOVE_DIR = @"C:\Users\Patrick\Desktop\VR\PSMove";
        private static readonly string FREEPIE_DIR = @"C:\Program Files (x86)\FreePIE\FreePIE.exe";
        private static readonly string FREEPIE_BRIDGE_DIR = @"C:\Users\Patrick\Desktop\VR\Freepie";
        private static readonly string RIFTCAT_DIR = @"C:\Program Files (x86)\Riftcat\Riftcat.exe";

        private Process moveService;
        private Process freepieService;
        private Process freepieBridge;
        private Process riftcatService;
        private Process steamProcess;

        private bool running = false;

        public Form1()
        {
            InitializeComponent();
        }

        private new void Invalidate()
        {
            button3.Text = running ? "Stop VR" : "Start VR";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!running)
                StartVR();
            else
                StopAllServices();
            Invalidate();
        }

        private void StartVR()
        {
            running = true;
            StartMoveService();
            StartFreePie();
            StartSteam();
            StartRiftcat();
        }

        private void StartMoveService()
        {
            StopMoveService();

            moveService = new Process();
            moveService.StartInfo.FileName = Path.Combine(PSMOVE_DIR, "PSMoveService.exe");
            moveService.StartInfo.Arguments = "";
            moveService.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            moveService.StartInfo.WorkingDirectory = PSMOVE_DIR;
            moveService.StartInfo.CreateNoWindow = true;
            moveService.Start();

            checkbox_move.Checked = true;
        }

        private void StartFreePie()
        {
            StopFreePie();

            freepieService = new Process();
            freepieService.StartInfo.FileName = FREEPIE_DIR;
            freepieService.StartInfo.Arguments = Path.Combine(FREEPIE_BRIDGE_DIR, "hmd.py") + " /r";
            freepieService.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            freepieService.Start();

            Thread.Sleep(1000);
            IntPtr windowHandle = freepieService.MainWindowHandle;
            ShowWindow(windowHandle.ToInt32(), 0);

            checkbox_freepie.Checked = true;

            freepieBridge = new Process();
            freepieBridge.StartInfo.FileName = Path.Combine(FREEPIE_BRIDGE_DIR, "PSMoveFreepieBridge.exe");
            freepieBridge.StartInfo.Arguments = "-x";
            freepieBridge.StartInfo.UseShellExecute = false;
            freepieBridge.StartInfo.RedirectStandardInput = true;
            freepieBridge.StartInfo.RedirectStandardOutput = true;
            freepieBridge.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            freepieBridge.StartInfo.CreateNoWindow = true;
            freepieBridge.Start();

            StreamWriter bridgeInput = freepieBridge.StandardInput;
            bridgeInput.WriteLine("1");
            bridgeInput.WriteLine("0");

            checkbox_freepieb.Checked = true;
        }

        private void StartRiftcat()
        {
            StopRiftcat();
            riftcatService = new Process();
            riftcatService.StartInfo.FileName = RIFTCAT_DIR;
            riftcatService.StartInfo.Arguments = "";
            riftcatService.Start();

            Hide();
            riftcatService.WaitForExit();
            StopAllServices();
            Show();
        }

        private void StartSteam()
        {
            steamProcess = new Process();
            steamProcess.StartInfo.FileName = STEAM_DIR;
            steamProcess.StartInfo.Arguments = "";
            steamProcess.Start();
        }

        private void StopMoveService()
        {
            try
            {
                if (moveService != null && !moveService.HasExited)
                {
                    moveService.Kill();
                    moveService.Dispose();
                    checkbox_move.Checked = false;
                }
            }
            catch { }
        }

        private void StopFreePie()
        {
            try
            {
                if (freepieService != null && !freepieService.HasExited)
                {
                    freepieService.Kill();
                    freepieService.Dispose();
                    checkbox_freepie.Checked = false;
                }
            }
            catch { }

            try
            {
                if (freepieBridge != null && !freepieBridge.HasExited)
                {
                    freepieBridge.Kill();
                    freepieBridge.Dispose();
                    checkbox_freepieb.Checked = false;
                }
            }
            catch { }
        }

        private void StopRiftcat()
        {
            try
            {
                if (riftcatService != null && !riftcatService.HasExited)
                {
                    riftcatService.Kill();
                    riftcatService.Dispose();
                }
            }
            catch { }
        }

        private void StopAllServices()
        {
            StopMoveService();
            StopFreePie();
            StopRiftcat();
            running = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAllServices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StopAllServices();
            Process testCamera = new Process();
            testCamera.StartInfo.FileName = Path.Combine(PSMOVE_DIR, "test_camera.exe");
            testCamera.StartInfo.WorkingDirectory = PSMOVE_DIR;
            testCamera.StartInfo.Arguments = "";
            testCamera.Start();

            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StopAllServices();
            StartMoveService();

            Process configTool = new Process();
            configTool.StartInfo.FileName = Path.Combine(PSMOVE_DIR, "PSMoveConfigTool.exe");
            configTool.StartInfo.WorkingDirectory = PSMOVE_DIR;
            configTool.StartInfo.Arguments = "";
            configTool.Start();

            Invalidate();

            configTool.WaitForExit();
            StopMoveService();
        }
    }
}
