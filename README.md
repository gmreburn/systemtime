# NutsAndBrackets.SystemTime [![Build status](https://ci.appveyor.com/api/projects/status/mkwv9husohaleda4?svg=true)](https://ci.appveyor.com/project/gmreburn/systemtime)

.Net Abstraction for DateTime so it is testable. Project uses CI/CD. All changes welcomed via pull requests.

# .Net Framework Targets
Compiled support for .Net 2.0, 4.0, 4.5, 4.5.1 4.5.2, 4.6, and 4.6.1.

## Installation
Hosted on [Nuget.org](https://www.nuget.org/packages/NutsAndBrackets.SystemTime)

```console 
PM > Install-Package NutsAndBrackets.SystemTime 
```

## Usage
Defaults to ```System.DateTime implementation```. Get or set SystemTime.Now or SystemTime.UtcNow to mock the behavior.
```C#
Assert.AreEqual(NutsAndBrackets.SystemTime.Now, System.DateTime.Now);
```
Set the SystemTime.Now to a static/known DateTime when you are in a unit testing scenario. That way you can be sure your module is processing using the same DateTime each time. Replace usages in product code of DateTime.Now with SystemTime.Now
```Diff
--- var time = DateTime.Now;
+++ var time = SystemTime.Now;
```

Pratical usage in a unit test
```C#
usings NutsAndBrackets;
...
// Arrange
SystemTime.Now = default(DateTime); // 01/01/0001 12:00:00 AM
var sut = new SystemUnderTest();

// Act
var result = sut.IsMonthJanuary();

// Assert
Assert.IsTrue(result);
```

You can set SystemTime.Now to any DateTime instance

```C#
SystemTime.Now = new System.DateTime(1, 1, 2016); // 01/01/2016
SystemTime.Now = DateTime.Now; // Will cache the current time at runtime and always return that particular time
SystemTime.Now = null; // Reset the mock to default behavior (return current time)
```
