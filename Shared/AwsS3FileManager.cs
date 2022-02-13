using System;
using System.IO;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Transfer;

namespace test2.Shared
{

    

    public class AwsS3FileManager : IAwsS3FileManager
    {
        private readonly IAmazonS3 _client;
        private readonly string _bucket;


        public AwsS3FileManager(IAmazonS3 client)
        {
            _client = client;
            _bucket = "yashuawss3bucket1";

        }
        public Task DeleteFileAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<TransferFile> DownloadFileAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UploadFileAsync(string fileName, Stream file)
        {
            var filestream = new MemoryStream();
            await file.CopyToAsync(filestream);

            var s3FileName = $"{DateTime.Now.Ticks}-{fileName}";

            var transferRequest = new TransferUtilityUploadRequest()
            {
                ContentType = "image/png",
                InputStream = filestream,
                BucketName = _bucket,
                Key = s3FileName
            };
            transferRequest.Metadata.Add("x-amz-meta-title", fileName);

            var fileTransferUtility = new TransferUtility(_client);
            await fileTransferUtility.UploadAsync(transferRequest);

            return s3FileName;
        }
    }
}
