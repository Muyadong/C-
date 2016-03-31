using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11._1._1驱动器
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo driver in drivers)
            {
                if (driver.DriveType == DriveType.Fixed && driver.DriveFormat == "NTFS")
                    Console.WriteLine("在{0}驱动器上还有{1}个字节的剩余空间。总的{2}",driver.Name,driver.AvailableFreeSpace,driver.TotalSize);
            }
        }
    }
}
