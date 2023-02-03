namespace DotNet7CastBenchmarks;

public class StaticObjects
{
    public static object PersonObject = new Person
    {
        Id = Guid.NewGuid(),
        Name = "Test Name"
    };
}