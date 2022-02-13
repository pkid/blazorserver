using System;
using System.IO;
using System.Threading.Tasks;

namespace test2.Shared
{
    
        public interface IAwsS3FileManager
        {
            Task<string> UploadFileAsync(string fileName, Stream file);
            Task<TransferFile> DownloadFileAsync(string fileName);
            Task DeleteFileAsync(string fileName);
        }
    
}
