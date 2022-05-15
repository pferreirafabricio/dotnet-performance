# ⚡Testing performance on .NET

<p align="left">
  This project aims to test some aspects of .NET and C# most used features, like strings, iterations, serializations and etc.
  <br><br>
  <!-- License -->
  <a>
    <img alt="license url" src="https://img.shields.io/badge/license%20-MIT-1C1E26?style=for-the-badge&labelColor=1C1E26&color=61ffca">
  </a>
</p>

## :open_book: About 
Specifications

``` ini
BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22616
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```

## ⚗️ Results

### MD5 vs SHA256

### Json Serialization

### For vs Foreach

### Strings

### Strings concatenation

### Strings interpolation

### Casting

## 🏄‍♂️ Quick Start
 1. Clone this repository `git clone https://github.com/pferreirafabricio/dotnet-performance.git`;
 2. Enter in the project's folder: `cd dotnet-performance`
 3. Enter in the solution: `cd PerformanceTests`
 4. Change on `Program.cs` file to use the class that you want to test
 5. Finally run `dotnet run --configuration Release` 😃

## :bricks: This project was built with: 
- [.NET](https://dotnet.microsoft.com/en-us/)
- [BenchmarkDotNet](https://benchmarkdotnet.org/index.html)
