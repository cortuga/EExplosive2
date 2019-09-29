using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace EExplosive2.Controllers

{
  [Route("api/[controller]")]
  [ApiController]


}
public class ExplosionController : ControllerBase

{
  [HttpGet("{s}")]
  public ActionResult<string> GetNumExplosionKata(string s)
  {
    return string.Join("", s.Select(c => new String(c, int.Parse(c.ToString()))));
  }
}