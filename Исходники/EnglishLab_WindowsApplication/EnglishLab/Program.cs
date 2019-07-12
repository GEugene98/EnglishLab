using System;
using System.Diagnostics;
using System.IO;

namespace EnglishLab
{
    static class Program
    {
        static void Main()
        {
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "UserInfo.dat")))
                Process.Start(Path.Combine(Environment.CurrentDirectory, "MainModule.exe"));
            else
                Process.Start(@"FirstStart\FirstStart.exe");
        }
    }
}
