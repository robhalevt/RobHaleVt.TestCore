# RobHaleVt.TestCore
## Overview
Written before I became familiar with [NUnit's Randomizer Methods](https://docs.nunit.org/articles/nunit/writing-tests/Randomizer-Methods.html), this class library helped me with the development of .NET unit tests. The focus is on extension methods that allow for easy creation of pseudo-random values. To use, create a class that has the [NUnit TestFixtureAttribute](https://docs.nunit.org/articles/nunit/writing-tests/attributes/testfixture.html) on it and which inherits from the RobHale.TestCore.BaseTestFixture class. This exposes a field named Random, of type [System.Random](https://docs.microsoft.com/en-us/dotnet/api/system.random?view=netcore-2.0). This allowed me to assign a pseudo-random value when a test would run.

```csharp
// two examples
uint quantity = Random.NextUInt(1, 50);
bool isMatch = Random.NextBool();
```

The implementation around getting a random Enum value, NextEnum\<T>, allows for an IEnumerable\<T> of Enum values to exclude from the results. 
```csharp
var excluded = new[] { AttributeTargets.Module, AttributeTargets.Assembly, AttributeTargets.Constructor };
var target = Random.NextEnum<AttributeTargets>(excluded);
```
