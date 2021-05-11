using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace compress
{
    class Compresser
    {
        public static void ZipComp(string sourcePath, string requestedPath)
        {
            var filelist = new DirectoryInfo(sourcePath).GetFiles("*.*", SearchOption.AllDirectories).Select(s => s.FullName).ToList();
            using Filestream fstream = new Filestream(requestedPath, FileMode.Create, FileAccess.ReadWrite);
            {
                using (ZipArchieve zipArchieve = new ZipArchieve(filestream, ZipArchieveMode.Create))
                {
                    foreach (string file in filelist)
                    {
                        string path = file.Substring(sourcePath.Length);
                        zipArchieve.CreateEntryFromFile(file, path);
                    }    
                }
            }
        }
    }
}
