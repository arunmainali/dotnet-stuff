using System.IO;
using System;

class Program {
    static void Main() {
        DriveInfo[] drive_info = DriveInfo.GetDrives();

        foreach(DriveInfo items in drive_info) {
            Console.WriteLine(items.Name);
        }

        string file_location = @"./test.txt";
        FileStream fs = null;
        if (!File.Exists(file_location)) {
            using (fs = File.Create(file_location)) {

            }
        }
        Console.WriteLine("File created succesfully");
    }
}
