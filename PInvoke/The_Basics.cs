using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PInvoke
{
    partial class Program
    {
          private static void The_Basics()
        {
            var processId = int.Parse(Console.ReadLine());
            var process = Process.GetProcessById(processId);
            Console.WriteLine($"{process} is {CPUType(process)}");
        }
        
        private static string CPUType(Process process)
        {
            SYSTEM_INFO systemInfo;
            GetNativeSystemInfo(out systemInfo);
            bool isWow64;
            IsWow64Process(process.Handle, out isWow64);
            if (systemInfo.wProcessorArchitecture == 0)
            {
                return "32";
            }
            else
            {
                if (systemInfo.wProcessorArchitecture == 9 && IsWow64Process(process.Handle, out isWow64) == true)
                {
                    return isWow64 ? "32" : "64";
                }
            }
            return "Unknown";
        }
        
        //https://docs.microsoft.com/en-us/windows/win32/api/wow64apiset/nf-wow64apiset-iswow64process
        [DllImport("kernel32")]
        static extern bool IsWow64Process(IntPtr hProcess, out bool wow64);
        
        //https://docs.microsoft.com/en-us/windows/win32/api/sysinfoapi/nf-sysinfoapi-getnativesysteminfo
        [DllImport("kernel32")]
        static extern void GetNativeSystemInfo(out SYSTEM_INFO lpSystemInfo);
        
        
        [StructLayout(LayoutKind.Sequential)]
        struct SYSTEM_INFO
        {
            public ushort wProcessorArchitecture; //WORD
            public ushort wReserved; // WORD
            public uint dwPageSize; //DWORD
            public IntPtr lpMinimumApplicationAddress; //LPVOID
            public IntPtr lpMaximumApplicationAddress; //LPVOID
            public IntPtr dwActiveProcessorMask; //DWORD_PTR
            public uint dwNumberOfProcessors;
            public uint dwProcessorType;
            public uint dwAllocationGranularity;
            public ushort wProcessorLevel;
            public ushort wProcessorRevision;
        }
    }
}