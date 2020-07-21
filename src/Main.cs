using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace V1R1_BrowserAlign
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        byte mode = 0, prewmode = 0;
        private void button6_Click(object sender, EventArgs e)
        {
            mode = 1; coml.Text = button6.Text;
            UpdateVisualisation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mode = 2; coml.Text = button1.Text;
            UpdateVisualisation();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mode = 3; coml.Text = button2.Text;
            UpdateVisualisation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mode = 4; coml.Text = button3.Text;
            UpdateVisualisation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mode = 5; coml.Text = button4.Text;
            UpdateVisualisation();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mode = 6; coml.Text = button5.Text;
            UpdateVisualisation();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            mode = 7; coml.Text = button8.Text;
            UpdateVisualisation();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            mode = 8; coml.Text = button9.Text;
            UpdateVisualisation();
        }
        void UpdateVisualisation()
        {
            if (mode == prewmode) return;
            Bitmap bmp = new Bitmap(139,79, System.Drawing.Imaging.PixelFormat.Format16bppRgb555);
            switch (mode)
            {
                case 1:
                    PrintBackgroung(ref bmp);
                    PrintForm(ref bmp, 1); PrintForm(ref bmp, 3); PrintForm(ref bmp, 4);
                    PrintIcon(ref bmp, 2); PrintIcon(ref bmp, 3); PrintIcon(ref bmp, 4);
                    pictureBox1.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 0);
                    PrintIcon(ref bmp, 0);
                    pictureBox2.Image = bmp;
                    progressBar1.Maximum = 9;
                    break;
                case 2:
                    PrintForm(ref bmp, 1); PrintForm(ref bmp, 2);
                    PrintIcon(ref bmp, 1); PrintIcon(ref bmp, 2);
                    pictureBox1.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 0);
                    PrintIcon(ref bmp, 0);
                    pictureBox2.Image = bmp;
                    progressBar1.Maximum = 7;
                    break;
                case 3:
                    PrintForm(ref bmp, 1); PrintForm(ref bmp, 2);
                    pictureBox1.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 0);
                    pictureBox2.Image = bmp;
                    progressBar1.Maximum = 7;
                    break;
                case 4:
                    PrintForm(ref bmp, 0);
                    pictureBox2.Image = (Bitmap)bmp.Clone();
                    PrintBackgroung(ref bmp);
                    pictureBox1.Image = bmp;
                    progressBar1.Maximum = 3;
                    break;
                case 5:
                    PrintBackgroung(ref bmp);
                    pictureBox2.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 1);
                    pictureBox1.Image = bmp;
                    progressBar1.Maximum = 3;
                    break;
                case 6:
                    PrintBackgroung(ref bmp);
                    pictureBox2.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 2);
                    pictureBox1.Image = bmp;
                    progressBar1.Maximum = 3;
                    break;
                case 7:
                    PrintBackgroung(ref bmp);
                    pictureBox2.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 3);
                    PrintIcon(ref bmp, 3);
                    pictureBox1.Image = bmp;
                    progressBar1.Maximum = 3;
                    break;
                case 8:
                    PrintBackgroung(ref bmp);
                    pictureBox2.Image = (Bitmap)bmp.Clone();
                    PrintForm(ref bmp, 4);
                    PrintIcon(ref bmp, 4);
                    pictureBox1.Image = bmp;
                    progressBar1.Maximum = 3;
                    break;
            }
        }
        void PrintBackgroung(ref Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            gr.DrawImage(Properties.Resources.wal, 0,0);
        }
        void PrintForm(ref Bitmap bmp, byte type)
        {
            Graphics gr = Graphics.FromImage(bmp);
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            switch (type)
            {
                case 0:
                    gr.Clear(Color.White);
                    gr.FillRectangle(Brushes.Red, 129, 0, 10, 10);
                    gr.FillRectangle(Brushes.Gray, 109, 0, 20, 10);
                    gr.DrawString("opera", new Font(Font.FontFamily, 10), Brushes.DarkRed, 2,-7);
                    gr.DrawLine(Pens.Black, 0, 10, 139, 10);
                    gr.DrawLine(Pens.Black, 129, 0, 129, 10);
                    gr.DrawLine(Pens.Black, 119, 0, 119, 10);
                    gr.DrawLine(Pens.Black, 109, 0, 109, 10);
                    break;
                case 1:
                    gr.FillRectangle(Brushes.White, 70, 0, 139, 79);
                    gr.DrawLine(Pens.Black, 70, 0, 70, 79);
                    gr.FillRectangle(Brushes.Red, 129, 0, 10, 10);
                    gr.FillRectangle(Brushes.Gray, 109, 0, 20, 10);
                    gr.DrawString("opera", new Font(Font.FontFamily, 10), Brushes.DarkRed, 70, -7);
                    gr.DrawLine(Pens.Black, 70, 10, 139, 10);
                    gr.DrawLine(Pens.Black, 129, 0, 129, 10);
                    gr.DrawLine(Pens.Black, 119, 0, 119, 10);
                    gr.DrawLine(Pens.Black, 109, 0, 109, 10);
                    break;
                case 2:
                    gr.FillRectangle(Brushes.White, 0, 0, 70, 79);
                    gr.DrawLine(Pens.Black, 70, 0, 70, 79);
                    gr.FillRectangle(Brushes.Red, 60, 0, 10, 10);
                    gr.FillRectangle(Brushes.Gray, 40, 0, 20, 10);
                    gr.DrawString("opera", new Font(Font.FontFamily, 10), Brushes.DarkRed, 0, -7);
                    gr.DrawLine(Pens.Black, 0, 10, 70, 10);
                    gr.DrawLine(Pens.Black, 60, 0, 60, 10);
                    gr.DrawLine(Pens.Black, 50, 0, 50, 10);
                    gr.DrawLine(Pens.Black, 40, 0, 40, 10);
                    break;
                case 3:
                    gr.FillRectangle(Brushes.White, 0, 0, 70, 40);
                    gr.DrawLine(Pens.Black, 70, 0, 70, 40);
                    gr.DrawLine(Pens.Black, 0, 40, 70, 40);
                    gr.FillRectangle(Brushes.Red, 60, 0, 10, 10);
                    gr.FillRectangle(Brushes.Gray, 40, 0, 20, 10);
                    gr.DrawString("opera", new Font(Font.FontFamily, 10), Brushes.DarkRed, 0, -7);
                    gr.DrawLine(Pens.Black, 0, 10, 70, 10);
                    gr.DrawLine(Pens.Black, 60, 0, 60, 10);
                    gr.DrawLine(Pens.Black, 50, 0, 50, 10);
                    gr.DrawLine(Pens.Black, 40, 0, 40, 10);
                    break;
                case 4:
                    gr.FillRectangle(Brushes.LightGray, 20, 40, 50, 79);
                    gr.FillRectangle(Brushes.Red, 60, 40, 10, 10);
                    gr.FillRectangle(Brushes.Gray, 40, 40, 20, 10);
                    gr.DrawString("ТВ", new Font(Font.FontFamily, 8), Brushes.DarkRed, 20, 38);
                    gr.DrawLine(Pens.Black, 70, 40, 70, 79);
                    gr.DrawLine(Pens.Black, 20, 40, 70, 40);
                    gr.DrawLine(Pens.Black, 20, 40, 20, 79);
                    gr.DrawLine(Pens.Black, 20, 50, 70, 50);
                    gr.DrawLine(Pens.Black, 60, 40, 60, 50);
                    gr.DrawLine(Pens.Black, 50, 40, 50, 50);
                    gr.DrawLine(Pens.Black, 40, 40, 40, 50);
                    break;
            }
        }
        
        void DisableAll()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        DateTime starttime;
        private void button7_Click(object sender, EventArgs e)
        {
            if (mode == 0) { MessageBox.Show("Выберите команду!", "Сообщение"); return; }
            if (MessageBox.Show("Не запускайте браузер \"Opera\" и программу \"GlazTV\" в промужутке от нажатия кнопки \"ОК\" до окончания выполнения команды! Дождитесь окончания выполнения команды перед тем, как что-то трогать!", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) != DialogResult.OK)
                return;
            starttime = DateTime.Now;
            DisableAll();
            context = System.Threading.SynchronizationContext.Current;
            timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }
        System.Threading.SynchronizationContext context;
        byte progr = 0;
        //string operaPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\..\Local\Programs\Opera\launcher.exe";
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            performanceCounter1.NextValue();
            context.Post(s => { stat.Text = "Ожидание уменьшения нагрузки..."; }, null);
            while (performanceCounter1.NextValue() > 90) { System.Threading.Thread.Sleep(250); };
            progr++;
            List<Process> proc;
            if (mode == 1 || mode == 2 || mode == 3)
            {
                context.Post(s => { stat.Text = "Запуск браузера..."; progressBar1.Value = progr; }, null);
                CallWindow(0, mode != 3);
                performanceCounter1.NextValue();
                do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                progr++;
                context.Post(s => { progressBar1.Value = progr; }, null);
                CallWindow(1, mode != 3);
                performanceCounter1.NextValue();
                do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                progr++;
                context.Post(s => { progressBar1.Value = progr; }, null);
                CallWindow(2, mode != 3);
                performanceCounter1.NextValue();
                do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                progr++;
                context.Post(s => { stat.Text = "Размещение браузера..."; progressBar1.Value = progr; }, null);
                proc = Process.GetProcessesByName("opera").ToList();
                while (!isOwneredExists(ref proc, "Наталья")) { System.Threading.Thread.Sleep(500); proc = Process.GetProcessesByName("opera").ToList(); };
                MoveWindow(proc[0].MainWindowHandle, 0, 0, 1366, Screen.PrimaryScreen.WorkingArea.Height, true);
                ShowWindow(proc[0].MainWindowHandle, 3);
                progr++;
                proc = Process.GetProcessesByName("opera").ToList();
                while (!isOwneredExists(ref proc, "L1")) { System.Threading.Thread.Sleep(500); proc = Process.GetProcessesByName("opera").ToList(); };
                MoveWindow(proc[0].MainWindowHandle, -683, 0, 683, 768, true);
                progr++;
                proc = Process.GetProcessesByName("opera").ToList();
                while (!isOwneredExists(ref proc, "L2")) { System.Threading.Thread.Sleep(500); proc = Process.GetProcessesByName("opera").ToList(); };
                if (mode == 1)
                {
                    MoveWindow(proc[0].MainWindowHandle, -1366, 0, 683, 570, true);
                    progr++;
                    context.Post(s => { stat.Text = "Запуск ТВ..."; progressBar1.Value = progr; }, null);
                    CallWindow(3, false);
                    performanceCounter1.NextValue();
                    do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                    progr++;
                    context.Post(s => { stat.Text = "Размещение ТВ..."; progressBar1.Value = progr; }, null);
                    IntPtr hw = IntPtr.Zero;
                    while (!tviscorrect(ref hw)) System.Threading.Thread.Sleep(500);
                    MoveWindow(hw, -1088, 540, 404, 233, true);
                    GetWindowRect(hw, out RECT rc);
                    while (rc.Bottom - rc.Top - 233 > 10 && rc.Right - rc.Left - 404 > 10)
                    {
                        System.Threading.Thread.Sleep(500);
                        MoveWindow(hw, -1088, 540, 404, 233, true);
                        GetWindowRect(hw, out rc);
                    }
                }
                else
                {
                    MoveWindow(proc[0].MainWindowHandle, -1366, 0, 683, 768, true);
                }
            }
            else if (mode == 6 || mode == 7)
            {
                context.Post(s => { stat.Text = "Запуск браузера..."; progressBar1.Value = progr; }, null);
                CallWindow(2, mode == 7);
                performanceCounter1.NextValue();
                do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                progr++;
                context.Post(s => { stat.Text = "Размещение браузера..."; progressBar1.Value = progr; }, null);
                proc = Process.GetProcessesByName("opera").ToList();
                while (!isOwneredExists(ref proc, "L2")) { System.Threading.Thread.Sleep(500); proc = Process.GetProcessesByName("opera").ToList(); };
                if (mode == 7)
                    MoveWindow(proc[0].MainWindowHandle, -1366, 0, 683, 570, true);
                else
                    MoveWindow(proc[0].MainWindowHandle, -1366, 0, 683, 768, true);
            }
            else
            {
                switch (mode)
                {
                    case 4:
                        context.Post(s => { stat.Text = "Запуск браузера..."; progressBar1.Value = progr; }, null);
                        CallWindow(0, false);
                        performanceCounter1.NextValue();
                        do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                        progr++;
                        context.Post(s => { stat.Text = "Размещение браузера..."; progressBar1.Value = progr; }, null);
                        proc = Process.GetProcessesByName("opera").ToList();
                        while (!isOwneredExists(ref proc, "Наталья")) { System.Threading.Thread.Sleep(500); proc = Process.GetProcessesByName("opera").ToList(); };
                        MoveWindow(proc[0].MainWindowHandle, 0, 0, 1366, Screen.PrimaryScreen.WorkingArea.Height, true);
                        ShowWindow(proc[0].MainWindowHandle, 3);
                        break;
                    case 5:
                        context.Post(s => { stat.Text = "Запуск браузера..."; progressBar1.Value = progr; }, null);
                        CallWindow(1, false);
                        performanceCounter1.NextValue();
                        do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                        progr++;
                        context.Post(s => { stat.Text = "Размещение браузера..."; progressBar1.Value = progr; }, null);
                        proc = Process.GetProcessesByName("opera").ToList();
                        while (!isOwneredExists(ref proc, "L1")) { System.Threading.Thread.Sleep(500); proc = Process.GetProcessesByName("opera").ToList(); };
                        MoveWindow(proc[0].MainWindowHandle, -683, 0, 683, 768, true);
                        break;
                    case 8:
                        context.Post(s => { stat.Text = "Запуск ТВ..."; progressBar1.Value = progr; }, null);
                        CallWindow(3, false);
                        performanceCounter1.NextValue();
                        do { System.Threading.Thread.Sleep(500); } while (performanceCounter1.NextValue() > 90);
                        progr++;
                        context.Post(s => { stat.Text = "Размещение ТВ..."; progressBar1.Value = progr; }, null);
                        IntPtr hw = IntPtr.Zero;
                        while (!tviscorrect(ref hw)) System.Threading.Thread.Sleep(500);
                        MoveWindow(hw, -1088, 540, 404, 233, true);
                        GetWindowRect(hw, out RECT rc);
                        while (rc.Bottom - rc.Top - 233 > 10 && rc.Right - rc.Left - 404 > 10) {
                            System.Threading.Thread.Sleep(500);
                            MoveWindow(hw, -1088, 540, 404, 233, true);
                            GetWindowRect(hw, out rc);
                        }
                        break;
                }
            }
            progr++;
            context.Post(s => { stat.Text = "Команда выполнена."; progressBar1.Value = progr; }, null);
            timer1.Stop();
            context.Post(s => { if (ActiveForm == null) Activate(); }, null);
        }
        bool isOwneredExists(ref List<Process> proc, string owner)
        {
            if (proc.Count == 0) return false;
            for (ushort i = 0; i != proc.Count; ++i)
                if (proc[i].MainWindowHandle == IntPtr.Zero || proc[i].StartTime < starttime)
                    proc.RemoveAt(i--);
            if (proc.Count == 0) return false;
            string[] o = new String[2];
            for (ushort i = 0; i != proc.Count; ++i)
            {
                System.Management.ManagementObjectSearcher Processes = new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ProcessID='" + proc[i].Id + "'");
                foreach (System.Management.ManagementObject Process1 in Processes.Get())
                {
                    Process1.InvokeMethod("GetOwner", (object[])o);
                    if (o[0] != owner) proc.RemoveAt(i--);
                }
            }
            if (proc.Count == 0) return false;
            return true;
        }
        bool tviscorrect(ref IntPtr hwnd)
        {
            IntPtr hw = IntPtr.Zero;
            List<Process> proc = Process.GetProcessesByName("GlazTV").ToList();
            if (proc.Count == 0) { return false; }
            for (ushort i = 0; i != proc.Count; ++i)
                if (proc[i].StartTime < starttime)
                    proc.RemoveAt(i--);
            ProcessThreadCollection ptc = proc[0].Threads;
            RECT rc; bool found = false;
            foreach (ProcessThread thread in ptc)
            { 
                EnumThreadWindows(thread.Id, (hWnd, lParam) => {
                    GetWindowRect(hWnd, out rc);
                    if (rc.Bottom - rc.Top > 500 && rc.Right - rc.Left < 1000)
                    {
                        hw = hWnd;
                        found = true;
                    }
                    return true;
                }, IntPtr.Zero);
                if (found) break;
            }
            if (hw == IntPtr.Zero) return false;
            hwnd = hw;
            return true;
        }
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hwnd, int cmd);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool EnumThreadWindows(int dwThreadId, EnumThreadDelegate lpfn, IntPtr lParam);
        private delegate bool EnumThreadDelegate(IntPtr hWnd, IntPtr lParam);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        void CallWindow(byte th, bool ok)
        {
            if (th == 0)
            {
                if (ok)
                    Process.Start("C:\\Users\\Наталья\\AppData\\Local\\Programs\\Opera\\launcher.exe", @"https://ok.ru/");
                else
                    Process.Start("C:\\Users\\Наталья\\AppData\\Local\\Programs\\Opera\\launcher.exe");

            }
            else if (th == 1)
            {
                if (ok)
                    Process.Start("cmd.exe", "/C runas /profile /savecred /user:L1 \"C:\\Users\\L1\\AppData\\Local\\Programs\\Opera\\launcher.exe https://ok.ru/\"");
                else
                    Process.Start("cmd.exe", "/C runas /profile /savecred /user:L1 \"C:\\Users\\L1\\AppData\\Local\\Programs\\Opera\\launcher.exe\"");
            }
            else if (th == 2)
            {
                if (ok)
                    Process.Start("cmd.exe", "/C runas /profile /savecred /user:L2 \"C:\\Users\\L2\\AppData\\Local\\Programs\\Opera\\launcher.exe https://ok.ru/\"");
                else
                    Process.Start("cmd.exe", "/C runas /profile /savecred /user:L2 \"C:\\Users\\L2\\AppData\\Local\\Programs\\Opera\\launcher.exe\"");
            }
            else if (th == 3)
            {
                ProcessStartInfo st_i = new ProcessStartInfo();
                st_i.FileName = @"C:\Program Files (x86)\Glaz.TV.2.0\GlazTV.exe";
                st_i.WorkingDirectory = @"C:\Program Files (x86)\Glaz.TV.2.0";
                Process.Start(st_i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ActiveForm == null) Activate();
        }

        

        void PrintIcon(ref Bitmap bmp, byte type)
        {
            Graphics gr = Graphics.FromImage(bmp);
            gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            switch (type)
            {
                case 0:
                    gr.DrawImage(Properties.Resources.ok, 60, 30);
                    break;
                case 1:
                    gr.DrawImage(Properties.Resources.ok, 25, 30);
                    break;
                case 2:
                    gr.DrawImage(Properties.Resources.ok, 95, 30);
                    break;
                case 3:
                    gr.DrawImage(Properties.Resources.ok, 25, 15);
                    break;
                case 4:
                    gr.DrawImage(Properties.Resources.tv, 35, 55);
                    break;
            }
        }
    }
}
