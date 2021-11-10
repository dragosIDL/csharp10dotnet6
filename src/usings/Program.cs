// Global Usings

// You can define the using statements that should be imported in all the files in the project in a normal *.cs class
// syntax: global using csharp10dotnet6.usings.Model
// Person is accessible without having to add any using statements even though the record is under csharp10dotnet6
Person john = new("John", 20);

// Implicit Usings
// By default when a new dotnet project is created there are several using statements that are made global by default
/// To enable this behavior edit .csproj and add <ImplicitUsings>enable</ImplicitUsings>
// Linq is accessible without having to add using System.Linq;
var result = new[] { 1, 2, 3 }.Select(i => i + 1).Sum();

// Which using statements are implicitly added depepnds on the type of the project.
