using FluentAssertions;
using mentoring_lesson;

namespace MentoringLes1;

public class FizzBuzzTest
{
    FizzBuzz fizzBuzz = new FizzBuzz();
    
    [Fact]
    public void TestFizzText()
    {
        var test=fizzBuzz.Process(3);
        test.Should().Be("Fizz");
    }
    [Fact]
    public void TestBuzzText()
    {
        var test=fizzBuzz.Process(5);
        test.Should().Be("Buzz");
    }
    [Fact]
    public void TestBuzzAndFizzText()
    {
        var test=fizzBuzz.Process(15);
        test.Should().Be("FizzBuzz");
    }
    [Fact]
    public void TestDefaultText()
    {
        var test=fizzBuzz.Process(17);
        test.Should().Be("17");
    }
}