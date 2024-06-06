using System.ComponentModel.DataAnnotations;

namespace ChatAppMVC.Models
{
    public class ChatViewModel
    {
        [Required]
        public string User { get; set; }
        public string Message { get; set; }
    }
}
