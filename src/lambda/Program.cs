// C# 9
Func<string, int> intParser9 = (s) => int.Parse(s);

// C# 10 Finally the compiler can understand the type of a lambda (in most cases).
var intParser10 = (string s) => int.Parse(s);

// When multiple overloads exit the compiler won't be able to find a type
var consoleWrite = Console.Write; // ERROR

// Lambdas now have a return type

var choose1 = (bool b) => b ? 1 : "two"; // ERROR: Can't infer return type
var choose2 = object (bool b) => b ? 1 : "two"; // returns object 

//syntax: returnType (params) => statement