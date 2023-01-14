# AM5-SMU-Checker-blazor

Blazor version of **AM5 SMU Checker** that you can run in your browser

## Requirements (end user)

You have to have newish [internet browser](https://docs.microsoft.com/en-us/aspnet/core/blazor/supported-platforms?view=aspnetcore-7.0)

## How to run / develop

### Requirements

You have to have [.NET 7 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) installed,

### Actual run

Run
```
dotnet run
```
  
And then you can open http://localhost:5039 in your browser

## How to publish

### Requirements

You have to have **wasm-tools** workload installed, before you you can do publish. You can install it with following command
```
dotnet workload install wasm-tools
```

### Actual publish
Run
```
dotnet publish -c Release
```
  
and content should be in **bin\Release\net7.0\publish\wwwroot** folder.

## Credits

[RaINi](https://github.com/LeagueRaINi), Reous and [PatrickSchur](https://github.com/patrickschur) for creating the **Zen2-SMU-Checker** command-line tool that is the base of AM5 SMU Checker.

## Licenses

All code files (*.cs, *.razor) and HTML files (*.html) are under [MIT](https://opensource.org/licenses/MIT) license, because original Zen2-SMU-Checker and [MVP.css](https://github.com/andybrewer/mvp/) use that license