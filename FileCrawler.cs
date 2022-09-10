using System;
using System.IO;
namespace OOP
{
    partial class Program
    {
        class FileCrawler
        {
            public FileCrawler(string path)
            {
                _path = path;
                foreach (string file in Directory.GetFiles(path))
                {
                    File newFile = new File(file);
                    _files.Add(newFile);
                    // Console.WriteLine(newFile.GetInfo());
                    // Console.WriteLine(newFile.GetContent());
                }
                foreach (string dir in Directory.GetDirectories(path))
                {
                    _dirs.Add(new DirectoryInfo(dir));
                }
            }
            List<File> _files = new List<File>();
            public void FileSize()
            {
                foreach (File file in _files)
                {
                    Console.WriteLine(file.GetInfo());
                }
            }
            List<DirectoryInfo> _dirs=new List<DirectoryInfo>();
            string _path;
            
            public void DirInfo()
            {
                foreach (DirectoryInfo dir in _dirs)
                {
                    Console.WriteLine($"{dir.Name} contains {dir.GetFiles().Length} files and {dir.GetDirectories().Length} directories");
                }
            }
        }
    }
}

