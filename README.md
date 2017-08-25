# .Net Portfolio

Final Friday-Solo project for Epicodus C#/.NET.<br>
This is an app that lets a user view my starred repositories on GitHub, and how many stars they have. I may use it to hold my capstone project as well.

## Specs/Wishlist

| Sections of developement | Implemented? |
|---|---|
| api call using RestSharp - Get Any Data | X |
| api call using RestSharp - Get My Repos | X |
| api call using RestSharp - Get My Repos With One Star | X |
| sift through data returned from RestSharp call | X |
| add mvc view to show data in a friendly format | X |
| add various other mvc pages to fill out the site | X |
| ---|---|
| add search function so a user can search for anyone's starred repos | X |
<hr>

## Project Build

Download from the [repo](https://github.com/GrapeSalad/DotNet-Portfolio)

Open Viual Studio 2015 and choose the Open Project option.

Navigate to the directory in which you downloaded the repo and open the project file.

*Packages*

Nuget Packages to get:
* RestSharp.NetCore
* Newtonsoft.Json

### Migration

Navigate to `....\project-name\src\projectname`.
Run this command in your terminal: `dotnet ef database update`.

### Running the Server

After installation and Migration, press f5 or the play button in the toolbar to run the server and have the site appear in your default browser.

## Known Bugs

Searching is not precise, no error checking for form entry.

## Technologies Utilized

* C#
* Visual Studio
* ASP.NET MVC
* ASP.NET
* CSS
* MUI CSS
* Github API
* RestSharp
* Newtonsoft

## Credits

* David Wilson