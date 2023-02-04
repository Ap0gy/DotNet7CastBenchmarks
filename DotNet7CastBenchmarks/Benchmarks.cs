using BenchmarkDotNet.Attributes;

namespace DotNet7CastBenchmarks;

[MemoryDiagnoser(false)]

public class Benchmarks
{
    [Benchmark]
    public Person SafeCast()
    {
        Person? personObject = StaticObjects.PersonObject as Person;
        return personObject!;
    }

    [Benchmark]
    public Person MatchCast()
    {
        if (StaticObjects.PersonObject is Person personObject)
        {
            return personObject;
        }
        return null!;
    }

    [Benchmark]
    public Person HardCast()
    {
        Person personObject = (Person)StaticObjects.PersonObject;
        return personObject;
    }
 }