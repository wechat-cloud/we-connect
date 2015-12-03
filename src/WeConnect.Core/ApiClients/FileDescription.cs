using System.IO;

namespace WeConnect.Core
{
    public class FileDescription
    {
        public string FileName { get; set; }
        public Stream FileStream { get; set; }
    }
}