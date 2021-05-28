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
        public static void BrotilCompresser(string sourcePath, string requestedPath)
        {
            var filelist = new DirectoryInfo(sourcePath).GetFiles("*.*", SearchOption.AllDirectories).Select(s => s.FullName).ToList();
            {
                using (FileStream compressedFileStream = File.Create(fileToCompress.FullName + ".gz"))
                {
                    using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                    {
                         originalFileStream.CopyTo(compressionStream);
                    }
                    FileInfo info = new FileInfo(requestedPath + Path.DirectorySeparatorChar + fileToCompress.Name + ".gz");
                }
            }
        }
    }
}