# systemtime [![Build status](https://ci.appveyor.com/api/projects/status/hfaxg4up1mytd3wq?svg=true)](https://ci.appveyor.com/project/gmreburn/dotnet-chef-api)

.Net Abstraction for DateTime so it is testable. Project uses CI/CD. All changes welcomed via pull requests.

## Usage
Defaults to ```System.DateTime implementation```. Get or set SystemTime.Now or SystemTime.UtcNow to mock the behavior.
```C#
Assert.AreEqual(gmreburn.SystemTime.Now, System.DateTime.Now);
```
Set the SystemTime.Now to a static/known DateTime when you are in a unit testing scenario. That way you can be sure your module is processing using the same DateTime each time. Replace usages in product code of DateTime.Now with SystemTime.Now
```Diff
--- var time = DateTime.Now;
+++ var time = SystemTime.Now;
```

Pratical usage in a unit test
```C#
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
SystemTime.Now = new System.DateTime(1, 1, 2016);
SystemTime.Now = DateTime.Now; // Will cache the current time and always return that particular time
SystemTime.Now = null; // Reset the mock to default behavior (return current time)
```
