using Microsoft.AspNetCore.Mvc;
using Letters.Models;

namespace Letters.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Scrabble() { return View(); }

    [Route("/score")]
    public ActionResult Score(string words)
    {
      LettersVariable myLettersVariable = new LettersVariable(words);
      return View(myLettersVariable);
    }


  }
}
