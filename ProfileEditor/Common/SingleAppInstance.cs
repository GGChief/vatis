﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace ProfileEditor.Common
{
    public class SingleAppInstance
    {
        private const int SW_RESTORE = 9;
        private static Mutex mutex;
        [DllImport("user32.dll")]
        private static extern int ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern int IsIconic(IntPtr hWnd);
        private static IntPtr GetCurrentInstanceWindowHandle()
        {
            IntPtr result = IntPtr.Zero;
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
            Process[] array = processesByName;
            for (int i = 0; i < array.Length; i++)
            {
                Process process = array[i];
                if (process.Id != currentProcess.Id && process.MainModule.FileName == currentProcess.MainModule.FileName && process.MainWindowHandle != IntPtr.Zero)
                {
                    result = process.MainWindowHandle;
                    break;
                }
            }
            return result;
        }
        private static void SwitchToCurrentInstance()
        {
            IntPtr currentInstanceWindowHandle = GetCurrentInstanceWindowHandle();
            if (currentInstanceWindowHandle != IntPtr.Zero)
            {
                if (IsIconic(currentInstanceWindowHandle) != 0)
                {
                    ShowWindow(currentInstanceWindowHandle, 9);
                }
                SetForegroundWindow(currentInstanceWindowHandle);
            }
        }
        public static bool Exists(string name = "")
        {
            if (IsAlreadyRunning(name))
            {
                SwitchToCurrentInstance();
                return true;
            }
            return false;
        }
        private static bool IsAlreadyRunning(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                string location = Assembly.GetExecutingAssembly().Location;
                FileSystemInfo fileSystemInfo = new FileInfo(location);
                name = fileSystemInfo.Name;
            }
            bool flag;
            mutex = new Mutex(true, "Global\\" + name, out flag);
            if (flag)
            {
                mutex.ReleaseMutex();
            }
            return !flag;
        }
    }
}
