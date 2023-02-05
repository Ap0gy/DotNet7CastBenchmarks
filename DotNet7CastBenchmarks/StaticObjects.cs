namespace DotNet7CastBenchmarks;

public class StaticObjects
{
    //public static object PersonObject = new Person
    //{
    //    Id = Guid.NewGuid(),
    //    Name = "NAME"
    //};

    public static List<object> PeopleObject = Enumerable
        .Range(0, 1000)
        .Select(x => (object)new Person
        {
            Id = Guid.NewGuid(),
            Name = "NAME"
        }).ToList();
}