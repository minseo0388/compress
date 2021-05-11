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
        public static void ZipCompressor(string sourcePath, string requestedPath)
        {
            using (ZipArchieve archive = Zipfile.OpenRead(zipPath));
            {
                foreach (ZipArchieveEntry entry in archive.Entries)
                {
                    if (entry.Fullname.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        entry.ExtractToFile(requestedPath);
                    }
                }
            }
        }
    }
}