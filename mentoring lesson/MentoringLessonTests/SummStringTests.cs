using FluentAssertions;
using SummString;

public class SummStringTests
{
    private readonly SummStringClass _sut;
    public SummStringTests(){
        _sut = new SummStringClass();
    }
    
    [Fact]
    public void SumDefaultNumbers()
    {
        int test = _sut.SummNumbers("5 15");
        test.Should().Be(20);
    }
    
    [Fact]
    public void SumWithNull()
    {
        int test = _sut.SummNumbers("5 Null");
        test.Should().Be(5);
    }
    [Fact]
    public void SumWithZero()
    {
        int test = _sut.SummNumbers("523 0 27");
        test.Should().Be(550);
    }
    [Fact]
    public void SummWithSymbols()
    {
        int test = _sut.SummNumbers("5/ntext 5");
        test.Should().Be(10);
    }
    [Fact] 
    public void SumUseDefaultSeparator()
    {
        int test = _sut.SummNumbers("//;\n3;4;5");
        test.Should().Be(12);
    }
    [Fact] 
    public void SumUseDefaultSeparatorWithSymbols()
    {
        int test = _sut.SummNumbers("//;\n3;test;45;522");
        test.Should().Be(570);
    }
    [Fact] 
    public void SumUseDefaultSeparatorWithZero()
    {
        int test = _sut.SummNumbers("//;\n3;test0;Null;0;522");
        test.Should().Be(525);
    }
    
    [Fact] 
    public void SumUseSeveralSeparators()
    {
        int test = _sut.SummNumbers("//;\n3; test0      ;Null; 0;522");
        test.Should().Be(525);
    }
}