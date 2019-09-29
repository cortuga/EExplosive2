using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace EExplosive2.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Mumbling
  {

    public class MumblingContoller : ControllerBase
    {
      [HttpGet("{s}")]
      public ActionResult<string> GetMumblingKata(string s)
      {
        return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
      }
    }
  }
}
