## Tests on strings fails inside docker container

How to reproduce:

- Clone the repository into a local directory
- Build a temp docker image:
  - ```docker build -t tempImg .```
- Start a container based on tempImg Image
  - ```docker run --rm -it tempImg```
- Now, inside the container run the solution tests as follows:
  - ```dotnet test```

After first attempt failed, i added the following line to the project file, and the test keeps failing
```xml
<ItemGroup>
	<RuntimeHostConfigurationOption Include="System.Globalization.Invariant" Value="true" />
	<ProjectReference Include="..\LibStrings\LibStrings.csproj" />
</ItemGroup>
```

Result:
```
Test run for /app/LibTests/bin/Debug/netcoreapp3.1/LibTests.dll(.NETCoreApp,Version=v3.1)
Microsoft (R) Test Execution Command Line Tool Version 16.7.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...

A total of 1 test files matched the specified pattern.
  X StringExtensions_RemoveDiacritics_SUCCESS [77ms]
  Error Message:
     String lengths are both 23. Strings differ at index 4.
  Expected: "amaha devera ser cabado"
  But was:  "amah� dever� ser ��bado"
  ---------------^

  Stack Trace:
     at UnitTests.StringExtensionsTests.StringExtensions_RemoveDiacritics_SUCCESS() in /app/LibTests/StringExtensionsTests.cs:line 19


Test Run Failed.
Total tests: 1
     Failed: 1
 Total time: 2.1396 Seconds
```