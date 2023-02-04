using BenchmarkDotNet.Attributes;

namespace DotNet7CastBenchmarks;


[MemoryDiagnoser(false)]
public class Benchmarks
{
    [Benchmark]
    public Person SafeCast()
    {
        Person? safeCastedPersonObject = StaticObjects.PersonObject as Person;
        return safeCastedPersonObject!;
    }

    [Benchmark]
    public Person MatchCast()
    {
        if (StaticObjects.PersonObject is Person matchCastedpersonObject)
        {
            return matchCastedpersonObject;
        }
        return null!;
    }

    [Benchmark]
    public Person HardCast()
    {
        Person personHardCast = (Person)StaticObjects.PersonObject;
        return personHardCast;
    }
 }