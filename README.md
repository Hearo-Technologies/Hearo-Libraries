# Hearo Libraries

NuGet package for Hearo Technologies. 

Will build automatically into a NuGet package hosted on github via github actions if version number is bumped. 

## Install NuGet Package

To install on a new project, add a new source to Visual Studio or Rider. 

- Visual Studio: https://docs.microsoft.com/en-us/nuget/consume-packages/install-use-packages-visual-studio#package-sources
Source is "https://nuget.pkg.github.com/Hearo-Technologies/index.json"

- Rider
    Go to the NuGet manager
    Select the Sources tab
    Click the plus to add a new source.
    Url is "https://nuget.pkg.github.com/Hearo-Technologies/index.json"
    Then use your GitHub user and password for auth

After the source is configured, you should see the Hearo-Libraries package in the list of available packages. 