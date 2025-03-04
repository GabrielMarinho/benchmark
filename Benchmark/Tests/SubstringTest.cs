using BenchmarkDotNet.Attributes;

namespace Benchmark.Tests;

[MemoryDiagnoser]
public class SubstringTest
{

    private readonly string _myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
    
    
    [Benchmark]
    public string SubstringWithSpanStart()
    {
        return _myString.AsSpan(0, 10).ToString();
    }

    [Benchmark]
    public string SubstringWithStartAndLength()
    {
        return _myString[..10];
    }
    
    [Benchmark]
    public string SubstringWithSpanMiddle()
    {
        return _myString.AsSpan(20, 5).ToString();
    }
    
    [Benchmark]
    public string SubstringWithStartAndLengthMiddle()
    {
        return _myString[20..25];
    }
    
    [Benchmark]
    public string SubstringWithSpanEnd()
    {
        return _myString.AsSpan(45).ToString();
    }
    
    [Benchmark]
    public string SubstringWithStartAndLengthEnd()
    {
        return _myString[45..];
    }

}