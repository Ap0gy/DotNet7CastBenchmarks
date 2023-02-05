using BenchmarkDotNet.Attributes;
using System.Runtime.CompilerServices;

namespace DotNet7CastBenchmarks;

[MemoryDiagnoser(false)]

public class Benchmarks
{
    //[Benchmark]
    //public Person SafeCast()
    //{
    //    Person? personObject = StaticObjects.PersonObject as Person;
    //    return personObject!;
    //}

    //[Benchmark]
    //public Person MatchCast()
    //{
    //    if (StaticObjects.PersonObject is Person personObject)
    //    {
    //        return personObject;
    //    }
    //    return null!;
    //}

    //[Benchmark]
    //public Person HardCast()
    //{
    //    Person personObject = (Person)StaticObjects.PersonObject;
    //    return personObject;
    //}

    [Benchmark]
    public List<Person> Cast_As()
    {
        return StaticObjects.PeopleObject
            .Where(x => x as Person is not null)
            .Cast<Person>()
            .ToList();
    }

    [Benchmark]
    public List<Person> Cast_Is()
    {
        return StaticObjects.PeopleObject
            .Where(x => x is Person)
            .Cast<Person>()
            .ToList();
    }

    [Benchmark]
    public List<Person> OfType()
    {
        return StaticObjects.PeopleObject
            .OfType<Person>()
            .ToList();
    }

    [Benchmark]
    public List<Person> HardCast_As()
    {
        return StaticObjects.PeopleObject
            .Where(x => x as Person is not null)
            .Select(x => (Person)x)
            .ToList();
    }

    [Benchmark]
    public List<Person> HardCast_Is()
    {
        return StaticObjects.PeopleObject
            .Where(x => x is Person)
            .Select(x => (Person)x)
            .ToList();
    }

    [Benchmark]
    public List<Person> HardCast_TypeOf()
    {
        return StaticObjects.PeopleObject
            .Where(x => x.GetType() == typeof(Person))
            .Select(x => (Person)x)
            .ToList();
    }

    [Benchmark]
    public List<Person> HardCast_UnsafeAs()
    {
        return StaticObjects.PeopleObject
            .Where(x => Unsafe.As<Person>(x) is not null)
            .Select(x => (Person)x)
            .ToList();
    }
}