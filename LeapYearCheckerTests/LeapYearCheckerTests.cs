using NUnit.Framework;
using LeapYearChecker;

namespace LeapYearCheckerTests
{
  public class LeapYearCheckerTests
  {
    private LeapYearChecker.LeapYearChecker _sut;
  
    [OneTimeSetUp]
    public void OneTimeSetup()
    {
      _sut = new LeapYearChecker.LeapYearChecker();
    }
    
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Given_YearIs2000_Then_ShouldReturnTrue()
    {
    //arrange
    var year = 2000;
    
    //act
    var result  = _sut.IsLeapYear(year);

    //asert
    Assert.IsTrue(result);
    }
    
    [Test]
    public void Given_YearIs2001_Then_ShouldReturnFalse()
    {
    //arrange
    var year = 2001;
    
    //act
    var result  = _sut.IsLeapYear(year);

    //asert
    Assert.IsFalse(result);
    }
    
    [Test]
    public void Given_YearIs1800_Then_ShouldReturnFalse()
    {
    //arrange
    var year = 1800;
    
    //act
    var result  = _sut.IsLeapYear(year);

    //asert
    Assert.IsFalse(result);
    }

    [Test]
    public void Given_YearIs2021_Then_ShouldReturnFalse()
    {
    //arrange
    var year = 2021;
    
    //act
    var result  = _sut.IsLeapYear(year);

    //asert
    Assert.IsFalse(result);
    }

    [Test]
    public void Given_YearIs16_Then_ShouldReturnTrue()
    {
    //arrange
    var year = 16;
    
    //act
    var result  = _sut.IsLeapYear(year);

    //asert
    Assert.IsTrue(result);
    }

    [Test]
    public void Given_YearIs1_Then_ShouldReturnFalse()
    {
    //arrange
    var year = 1;
    
    //act
    var result  = _sut.IsLeapYear(year);

    //asert
    Assert.IsFalse(result);
    }
  }
}