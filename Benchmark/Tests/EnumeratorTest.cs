using BenchmarkDotNet.Attributes;

namespace Benchmark;

public class EnumeratorTest
{
    private IEnumerable<int> AuxYield()
    {
        for (int i = 0; i < 100; i++)
        {
            yield return i;
        }
    }

    [Benchmark()]
    public void ComYield()
    {
        foreach (var value in AuxYield())
        {
            Console.WriteLine(value);
        }
    }

    private IEnumerable<int> AuxSemYield()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            list.Add(i);
        }

        return list;
    }
    
    [Benchmark()]
    public void SemYield()
    {
        var list = AuxSemYield();
        foreach (var value in list)
        {
            Console.WriteLine(value);
        }
    }

}