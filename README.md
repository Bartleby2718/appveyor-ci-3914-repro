# appveyor-ci-3914-repro
Minimal reproducible example for https://github.com/appveyor/ci/issues/3914

# Commands run (with .NET 8 SDK on Windows Git Bash):
- dotnet new sln --name MySolution
- dotnet new console --name MyProject
- dotnet sln add MyProject
- dotnet new nunit --name MyProject.Tests
- dotnet sln add MyProject.Tests
