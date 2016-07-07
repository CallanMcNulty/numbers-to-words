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
      Assert.Equal("forty three", convert.numberToString(43));
    }
    [Fact]
    public void Convert_13_thirteen() {
      Converter convert = new Converter();
      Assert.Equal("thirteen", convert.numberToString(13));
    }
    [Fact]
    public void Convert_433_fourhundredthirtythree() {
      Converter convert = new Converter();
      Assert.Equal("four hundred thirty three", convert.numberToString(433));
    }
    [Fact]
    public void Convert_4433_fourthousandfourhundredthirtythree() {
      Converter convert = new Converter();
      Assert.Equal("four thousand four hundred thirty three", convert.numberToString(4433));
    }
    [Fact]
    public void Convert_45433_fortyfivethousandfourhundredthirtythree() {
      Converter convert = new Converter();
      Assert.Equal("forty five thousand four hundred thirty three", convert.numberToString(45433));
    }
    [Fact]
    public void Convert_4001433_fourmilliononethousandfourhundredthirtythree() {
      Converter convert = new Converter();
      Assert.Equal("four million one thousand four hundred thirty three", convert.numberToString(4001433));
    }
    [Fact]
    public void Convert_400_fourhundred() {
      Converter convert = new Converter();
      Assert.Equal("four hundred", convert.numberToString(400));
    }
    [Fact]
    public void Convert_4000_fourthousand() {
      Converter convert = new Converter();
      Assert.Equal("four thousand", convert.numberToString(4000));
    }
    [Fact]
    public void Convert_4point3_fourandthreetenths() {
      Converter convert = new Converter();
      Assert.Equal("four and three tenths", convert.numberToString(4.3F));
    }
    [Fact]
    public void Convert_4point03_fourandthreehundredths() {
      Converter convert = new Converter();
      Assert.Equal("four and three hundredths", convert.numberToString(4.03F));
    }
  }
}
