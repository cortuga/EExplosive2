using System;

namespace EExplosive2.Models
{
  public class Mumbling
  {
    public string inputString { get; set; }

    public int id { get; set; }

    public DateTime Time { get; set; } = DateTime.Now;
  }
}