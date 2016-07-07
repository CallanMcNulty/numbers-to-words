using Xunit;
using System.Collections.Generic;

namespace NumberToWord
{
  public class ConverterTest
  {
    [Fact]
    public void Convert_4_four() {
      Converter convert = new Converter();
      Assert.Equal("four", convert.numberToString(4));
    }
    [Fact]
    public void Convert_43_fortythree() {
      Converter convert = new Converter();
      Assert.Equal("fortythree", convert.numberToString(43));
    }
  }
}
