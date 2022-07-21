using Microsoft.AspNetCore.Http;

namespace Arthes.DATA.Models
{
    public class FileUpload
    {
        public IFormFile? File { get; set; }
        public string? Revista { get; set; }
    }

}
