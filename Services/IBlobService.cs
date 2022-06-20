using System.Threading.Tasks;

namespace AzuriteTest.Services
{
    public interface IBlobService
    {
        void CreateBlobContainer(string containerId);
        Task<byte[]> GetBlob(string containerId, string blobId);
        void UploadBlob(string containerId, string blobId, byte[] content, string contentType);
    }
}

