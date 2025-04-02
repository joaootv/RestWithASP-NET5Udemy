using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Business
{
    public interface IFileBusiness
    {
        public byte[] GetFile(string fileName);
        public Task<FileDetailVO> SaveFileToDisk(UploadFileModel file);
        public Task<List<FileDetailVO>> SaveFilesToDisk(UploadFilesModel file);
    }
}
