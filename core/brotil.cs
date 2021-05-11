using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace compress
{
    class Compresser
    {
        public static void BrotilEncoder(string sourcePath, string requestedPath)
        {
            var list = SyncFile(sourcePath, new List<string>());
            using Filestream fstream = new Filestream(requestedPath, FileMode.Create, FileAccess.ReadWrite);
            {
                
            }
        }
    }
}