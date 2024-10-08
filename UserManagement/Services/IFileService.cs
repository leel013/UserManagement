namespace UserManagement.Services
{
    public interface IFileService
    {
        Tuple<int, string> SaveImage(IFormFile imageFile);
        Tuple<int, string> SaveFile(IFormFile resumeFile);
        public bool DeleteFile(string FileName);
    }
}
