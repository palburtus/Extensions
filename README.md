# C# Extensions
Library of C# Extensions I find handy for most projects

## string ```StringExtensions.cs```

### IsNullEmptyOrWordNull
Returns true for strings that are
- null
- empty (i.e. ```string value = string.empty``` or ```string value = ""```)
- string value is "null" (i.e. ```string value = "null"```)

## int ```IntExtensions.cs```
IsPercentageOf
```
int subSetOfRecords = 458;
int totalRecords = 1127;
int percentage = subSetOfRecords.IsPercentageOf(totalRecords);
//percentage equals (subSetOfRecords / totalRecords * 100 rounded up to the nearest integer)
```
