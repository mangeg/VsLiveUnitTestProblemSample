# VsLiveUnitTestProblemSample
Sample solution where Live Unit Test does not work when a project is using a source generator.

1. Open project in Visual Studio
2. Start Live Unit Testing
3. Only tests from Stample.Working.Test are discovered and execited
4. Run all tests manually.
5. Tests from both Stample.Working.Test and Sample.NotWorking.Test are discovered and executed.

From VS output window when starting Live Unit Testing:
```
Build completed with failures. Errors were logged under 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\diag\'.
```

Log reference from output window:
```
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(3,12): error CS0246: The type or namespace name 'StronglyTypedIdDefaultsAttribute' could not be found (are you missing a using directive or an assembly reference?)
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(3,12): error CS0246: The type or namespace name 'StronglyTypedIdDefaults' could not be found (are you missing a using directive or an assembly reference?)
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(4,18): error CS0103: The name 'StronglyTypedIdBackingType' does not exist in the current context
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(5,22): error CS0103: The name 'StronglyTypedIdImplementations' does not exist in the current context
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(5,66): error CS0103: The name 'StronglyTypedIdImplementations' does not exist in the current context
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(6,17): error CS0103: The name 'StronglyTypedIdConverter' does not exist in the current context
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(1,7): error CS0246: The type or namespace name 'StronglyTypedIds' could not be found (are you missing a using directive or an assembly reference?)
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(10,6): error CS0246: The type or namespace name 'StronglyTypedIdAttribute' could not be found (are you missing a using directive or an assembly reference?)
[16:39:29.214 Verbose] - BuildManager - C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\NotWorkingHelperClass.cs(10,6): error CS0246: The type or namespace name 'StronglyTypedId' could not be found (are you missing a using directive or an assembly reference?)
[16:39:29.214 Verbose] - BuildManager - C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\Roslyn\Microsoft.CSharp.Core.targets(75,5): error MSB4181: The "Csc" task returned false but did not log an error.
[16:39:29.217 Verbose] - BuildManager - Some of the file paths defined in the csproj under the Live Unit Testing build path are missing. Verify whether these files should be present under the Live Unit Testing build path and if necessary update the csproj definition to look these files up in a different place.
[16:39:29.218 Verbose] - BuildManager - Item _OutputPathItem 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\Debug\net6.0\' evaluated via:
_OutputPathItem: '$(OutDir)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:310
  OutDir: '$(OutputPath)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:228
    OutputPath: '$(OutputPath)$(TargetFramework.ToLowerInvariant())\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.TargetFrameworkInference.targets:245
      OutputPath: '$(BaseOutputPath)$(Configuration)\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.DefaultOutputPaths.targets:33
        BaseOutputPath: 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\' @ C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\Sample.NotWorking.csproj:0
        Configuration: 'Debug'
[16:39:29.219 Verbose] - BuildManager - Item AppConfigFileDestination 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\Debug\net6.0\Sample.NotWorking.dll.config' evaluated via:
AppConfigFileDestination: '$(OutDir)$(TargetFileName).config' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:338
  OutDir: '$(OutputPath)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:228
    OutputPath: '$(OutputPath)$(TargetFramework.ToLowerInvariant())\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.TargetFrameworkInference.targets:245
      OutputPath: '$(BaseOutputPath)$(Configuration)\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.DefaultOutputPaths.targets:33
        BaseOutputPath: 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\' @ C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\Sample.NotWorking.csproj:0
        Configuration: 'Debug'
  TargetFileName: '$(TargetName)$(TargetExt)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:248
    TargetName: '$(AssemblyName)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:240
      AssemblyName: '$(MSBuildProjectName)' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.Sdk.props:32
        MSBuildProjectName: 'Sample.NotWorking'
    TargetExt: '.dll' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.Sdk.BeforeCommon.targets:106
[16:39:29.219 Verbose] - BuildManager - Item CreateDirectory 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\Debug\net6.0\ref' evaluated via:
CreateDirectory: '$(OutDir)ref' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:398
  OutDir: '$(OutputPath)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:228
    OutputPath: '$(OutputPath)$(TargetFramework.ToLowerInvariant())\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.TargetFrameworkInference.targets:245
      OutputPath: '$(BaseOutputPath)$(Configuration)\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.DefaultOutputPaths.targets:33
        BaseOutputPath: 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\' @ C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\Sample.NotWorking.csproj:0
        Configuration: 'Debug'
[16:39:29.219 Verbose] - BuildManager - Item _DebugSymbolsOutputPath 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\Debug\net6.0\Sample.NotWorking.pdb' evaluated via:
_DebugSymbolsOutputPath: '@(_DebugSymbolsIntermediatePath->'$(OutDir)%(Filename)%(Extension)')' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:404
  OutDir: '$(OutputPath)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:228
    OutputPath: '$(OutputPath)$(TargetFramework.ToLowerInvariant())\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.TargetFrameworkInference.targets:245
      OutputPath: '$(BaseOutputPath)$(Configuration)\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.DefaultOutputPaths.targets:33
        BaseOutputPath: 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\' @ C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\Sample.NotWorking.csproj:0
        Configuration: 'Debug'
[16:39:29.219 Verbose] - BuildManager - Item _ApplicationManifestFinal 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\Debug\net6.0\Native.Sample.NotWorking.manifest' evaluated via:
_ApplicationManifestFinal: '$(OutDir)$(_DeploymentTargetApplicationManifestFileName)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:442
  OutDir: '$(OutputPath)' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:228
    OutputPath: '$(OutputPath)$(TargetFramework.ToLowerInvariant())\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.TargetFrameworkInference.targets:245
      OutputPath: '$(BaseOutputPath)$(Configuration)\' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.DefaultOutputPaths.targets:33
        BaseOutputPath: 'C:\Dev\Repos\VsLiveUnitTestProblemSample\.vs\LiveUnitTestProblemSample\v17\lut\0\b\Sample.NotWorking\' @ C:\Dev\Repos\VsLiveUnitTestProblemSample\src\Sample.NotWorking\Sample.NotWorking.csproj:0
        Configuration: 'Debug'
  _DeploymentTargetApplicationManifestFileName: 'Native.$(AssemblyName).manifest' @ C:\Program Files\Microsoft Visual Studio\2022\Preview\MSBuild\Current\Bin\amd64\Microsoft.Common.CurrentVersion.targets:264
    AssemblyName: '$(MSBuildProjectName)' @ C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.Sdk.props:32
      MSBuildProjectName: 'Sample.NotWorking'
```
