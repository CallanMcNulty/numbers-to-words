using System;
using Nancy;

namespace NumberToWord
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        float userNumber = Request.Form["number"];
        Converter newNumberToCovert = new Converter();
        string convertedNumber = newNumberToCovert.numberToString(userNumber);
        return View["result.cshtml", convertedNumber];
      };
    }
  }
}
