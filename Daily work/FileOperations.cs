using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_work
{
    internal class FileOperations
    {
        public void CreateFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
             using StreamWriter str = fi.CreateText();

            Console.WriteLine("File is created");
            str.WriteLine("Hello There");
            str.WriteLine("Hi");
            str.WriteLine("Are u there?");

        }
        public void WriteData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter the text which" + "You want to write to the file");
            string? str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt",FileMode.Open,FileAccess.Read);
            StreamReader streamReader = new StreamReader(fs);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while(str!=null)
            {
                Console.WriteLine(str);
                str=sr.ReadLine();
            }
            sr.Close();
            fs.Close();

        }
        public void CopyMoveFile()
        {
            FileInfo fi1 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fi2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt");
            fi1.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp\\" + "Sample.txt");
            fi2.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\" + "Sample1.txt");

        }
        public void DeleteFile()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Temp1\\Sample1.txt");
            fi.Delete();
        }
        public void FileProperies()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Temp\\Sample.txt");
            Console.WriteLine(fi.Name);
            Console.WriteLine(fi.FullName);
            Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Extension);
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.LastWriteTime);

        }

    }
}
