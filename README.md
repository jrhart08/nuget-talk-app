# NugetTalkApp

A basic console app to consume our `NdashLib` NuGet package. Its repo (and instructions on publishing it)
can be found here: https://github.com/jrhart08/nuget-sample-lib

After publishing our NdashLib project (detailed on its README), we have 2 methods of installing it:

### Option 1 - dotnet CLI

```ps1
# from solution folder
dotnet add MyConsoleApp package NdashLib --source C:\nuget-repo
```

### Option 2 - Visual Studio

1. Add `C:\nuget-repo` as a package source
    - Navigate to `Tools > Options > NuGet Package Manager > Package Sources`
    - Add a new source
      - Name: `Local`
      - Source: `C:\nuget-repo`
2. Install `NdashLib` NuGet package using your favorite method (via the Package Manager Console or the "Manage Packages" window)
