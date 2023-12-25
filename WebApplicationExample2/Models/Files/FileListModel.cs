using System.ComponentModel.DataAnnotations;
using System.Web;
using WebApplicationExample2.Services.Models;

namespace WebApplicationExample2.Models
{
    public class FileListModel
    {
        public List<FileListItemModel> Files { get; set; }
    }
}