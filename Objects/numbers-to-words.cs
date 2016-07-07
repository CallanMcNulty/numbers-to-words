using System.Collections.Generic;
using System;

namespace NumberToWord
{
  public class Converter
  {
    private Dictionary<char, string> _digitNames = new Dictionary<char, string>() {
                                                                                {'0', "zero"},
                                                                                {'1', "one"},
                                                                                {'2', "two"},
                                                                                {'3', "three"},
                                                                                {'4', "four"},
                                                                                {'5', "five"},
                                                                                {'6', "six"},
                                                                                {'7', "seven"},
                                                                                {'8', "eight"},
                                                                                {'9', "nine"}
                                                                                };

    private Dictionary<char, string> _tensNames = new Dictionary<char, string>() {
                                                                                {'0', ""},
                                                                                {'1', ""},
                                                                                {'2', "twenty"},
                                                                                {'3', "thirty"},
                                                                                {'4', "forty"},
                                                                                {'5', "fifty"},
                                                                                {'6', "sixty"},
                                                                                {'7', "seventy"},
                                                                                {'8', "eighty"},
                                                                                {'9', "ninety"}
                                                                                };
    public string numberToString(int number)
    {
      string numberString = number.ToString();
      while(numberString.Length < 3)
      {
        numberString = "0" + numberString;
      }
      return _tensNames[numberString[numberString.Length - 2]] + _digitNames[numberString[numberString.Length - 1]];
    }
  }
}
