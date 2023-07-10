using FluentAssertions;
using SummString;

public class SummStringTests
{
    SummStringClass s = new SummStringClass();

    [Theory]
    [InlineData("5", 5)]
    [InlineData("55", 55)]
    [InlineData("0", 0)]
    public void SummTests(string actual, int expected)
    {
        actual.Should().Be(expected.ToString());
    }

    [Fact] public void TestWithSumm()
    {
        int test = s.SummNumbers("5 5");
        test.Should().Be(10);
    }
    
    [Fact] public void TestWithSummWithText()
    {
        int test = s.SummNumbers("5 text 5");
        test.Should().Be(10);
    }
    [Fact] public void TestWithSummWithSleshN()
    {
        int test = s.SummNumbers("5/ntext 5");
        test.Should().Be(10);
    }
    [Fact] public void TestWithOutDelimeterSleshN()
    {
        int test = s.SummNumbers("10 10");
        test.Should().Be(20);
    }
    [Fact] 
    public void TestWithDelimeterSleshN1()
    {
        int test = s.SummNumbers("//;\n3;4;5");
        test.Should().Be(12);
    }
}