# C# Extensions
Library of C# Extensions I find handy for most projects

## string ```StringExtensions.cs```

### IsNullEmptyOrWordNull
Returns true for strings that are
- null
- empty (i.e. ```string value = string.empty``` or ```string value = ""```)
- string value is "null" (i.e. ```string value = "null"```)

## int ```IntegerExtensions.cs```
IsPercentageOf
```
int subsetOfRecords = 458;
int totalRecords = 1127;
int percentage = subsetOfRecords.IsPercentageOf(totalRecords);
//percentage equals 41 (subsetOfRecords / totalRecords * 100 rounded to the nearest integer)
```
subset of records divided by total records that eqaul n.5 will round up
