using Microsoft.AspNetCore.Mvc;

namespace ChatAppMVC.Controllers
{
    [Route("Chat")]
    public class ChatController : Controller
    {
        [Route("HomePage")]
        public IActionResult HomePage()
        {
            ViewData["Title"] = "Chat";
            return View();
        }
    }
}
