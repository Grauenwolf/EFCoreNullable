One of the long-standing issues with Entity Framework is that it doesn’t adhere to .NET’s design patterns. For example, Entity Framework adds setters to collection properties in violation of [CA2227: Collection properties should be read only](https://docs.microsoft.com/en-us/visualstudio/code-quality/ca2227). These problems are compounded when you try to enable modern static analysis tools (e.g. [Microsoft.CodeAnalysis.FxCopAnalyzers](https://docs.microsoft.com/en-us/visualstudio/code-quality/install-fxcop-analyzers)) and [C# 8’s nullable reference types](https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references). 

This repository is meant to be used in conjunction with the InfoQ article [Preparing Entity Framework Core for Static Analysis and Nullable Reference Types](http://infoq.com).

The project “EFCoreOriginal” has the raw output from the EF Core scaffolding tool. The project “EFCoreNullable” is the same code after its been prepared for static code analysis and nullable reference types.

TODO: Update article link when it is published.
