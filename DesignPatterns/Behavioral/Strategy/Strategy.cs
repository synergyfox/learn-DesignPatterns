using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Strategy
{
    public interface ICompression
    {
        void CompressFolder(string compressedArchiveFileName);
    }


    public class ZipCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using ZIP approach: '" + compressedArchiveFileName + ".zip' file is created");
        }
    }

    public class RarCompression : ICompression
    {
        public void CompressFolder(string compressedArchiveFileName)
        {
            Console.WriteLine("Folder is compressed using RAR approach: '" + compressedArchiveFileName + ".rar' file is created");
        }
    }

    public class CompressionContext
    {
        private ICompression compression;

        public CompressionContext(ICompression compression)
        {
            this.compression = compression;
        }

        public void SetStrategy(ICompression compression)
        {
            this.compression = compression;
        }

        public void CreateArchive(string compressedArchiveFileName)
        {
            compression.CompressFolder(compressedArchiveFileName);
        }
    }

    }
