// Structs can use `with` syntax
var person = new Person("John");
var structPerson = new StructPerson { Name = "John" };

var smith = person with { Name = "Smith" };
var otherSmith = structPerson with { Name = "Smith" };


// Anonymous types can use `with` syntax
var anomymousType = new
{
    Name = "John"
};

var other = anomymousType with { Name = "Smith" };


public record class Person(string Name);
public struct StructPerson
{
    public string Name { get; init; }
};