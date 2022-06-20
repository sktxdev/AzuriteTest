using System;
using System.Threading.Tasks;

namespace AzuriteTest.Repository
{
    public interface IBlobRepository
    {
        void CreateBlobContainer(string containerId);
        Task<byte[]> DownloadBlob(string containerId, string blobId);
        void UploadBlob(string containerId, string blobId, byte[] content, string contentType);
    }
}

