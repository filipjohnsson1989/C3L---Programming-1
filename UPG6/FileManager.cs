using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPG6
{
    static class FileManager
    {
        private const string _path = "ProgramFile.txt";

        public static void Update(string line)
        {
            using (StreamWriter sw = (File.Exists(_path)) ? File.AppendText(_path) : File.CreateText(_path))
            {
                    sw.WriteLine(line);
            }

        }

        public static string Read()
        {
            string fileContent;
            using (StreamReader sr = new StreamReader(_path))
            {
                fileContent = sr.ReadToEnd();
            }

            return fileContent;
        }
    }
}
