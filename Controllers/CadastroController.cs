namespace Insta.Controllers
{
    [Route("Cadastro")]
    public class Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}