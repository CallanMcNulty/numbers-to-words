using System.Collections.Generic;
using System;

namespace NumberToWord
{
  public class Converter
  {
    private Dictionary<char, string> _digitNames = new Dictionary<char, string>() {
                                                                                {'0', ""},
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

    private Dictionary<char, string> _teensNames = new Dictionary<char, string>() {
                                                                                {'0', "ten"},
                                                                                {'1', "eleven"},
                                                                                {'2', "twelve"},
                                                                                {'3', "thirteen"},
                                                                                {'4', "fourteen"},
                                                                                {'5', "fifteen"},
                                                                                {'6', "sixteen"},
                                                                                {'7', "seventeen"},
                                                                                {'8', "eightteen"},
                                                                                {'9', "nineteen"}
                                                                                };

    private Dictionary<int, string> _placeNames = new Dictionary<int, string>() {
                                                                                {0, ""},
                                                                                {1, " thousand"},
                                                                                {2, " million"},
                                                                                {3, " billion"},
                                                                                {4, " trillion"}
                                                                                };

    public string numberToString(float number)
    {
      string numberString = number.ToString();
      int decimalIndex = numberString.IndexOf(".");
      if(decimalIndex==-1)
      {
        return manyDigitsToString(numberString);
      }
      else
      {
        string finalWord = "";
        finalWord = finalWord + manyDigitsToString(numberString.Substring(0,decimalIndex)) +" and "+ manyDigitsToString(numberString.Substring(decimalIndex+1,numberString.Length-decimalIndex-1));
        string fraction = "1";
        for(int i=0; i<numberString.Length-decimalIndex-1; i++)
        {
          fraction = fraction + "0";
        }
        fraction = manyDigitsToString(fraction);
        if(fraction.Substring(0,3)=="one")
        {
          fraction = fraction.Substring(4,fraction.Length-4);
        }
        finalWord = finalWord + " " +  fraction + "ths";

        return finalWord;
      }
    }
    public string manyDigitsToString(string numberString)
    {
      string finalWord = "";
      if(numberString.Length <= 3)
      {
        return threeDigitsToString(numberString);
      }
      for(int i=0; i<=numberString.Length; i+=3)
      {
        int startIndex = Math.Max(0,numberString.Length-i-3);
        int substringLength = Math.Min(3,numberString.Length-i);
        string spacer = "";
        if(finalWord != "")
        {
          spacer = " ";
        }
        finalWord = threeDigitsToString(numberString.Substring(startIndex,substringLength)) + _placeNames[i/3] +spacer+ finalWord;
      }
      return finalWord;
    }

    public string threeDigitsToString(string numberString)
    {
      while(numberString.Length < 3)
      {
        numberString = "0" + numberString;
      }
      string finalWord = "";
      char hundreds = numberString[0];
      if(hundreds != '0')
      {
        finalWord = finalWord + _digitNames[hundreds] + " hundred";
      }
      char tens = numberString[1];
      string spacer = "";
      if(finalWord != "")
      {
        spacer = " ";
      }
      if(tens=='1')
      {
        finalWord = finalWord +spacer+ _teensNames[numberString[2]];
      }
      else
      {
        if(_tensNames[tens]=="")
        {
          spacer = "";
        }
        finalWord = finalWord +spacer+ _tensNames[tens];
        string ones = _digitNames[numberString[2]];
        string spacer2 = "";
        if(ones != "" && finalWord != "")
        {
          spacer2 = " ";
        }
        finalWord = finalWord + spacer2 + ones;
      }
      return  finalWord;
    }
  }
}
