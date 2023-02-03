using DotNet7CastBenchmarks;

//Person personObject = (Person)StaticObjects.PersonObject;
//Person? personObject = StaticObjects.PersonObject as Person;

if(StaticObjects.PersonObject is not Person personObject)
{
    return;
}

Console.WriteLine(personObject.Name);