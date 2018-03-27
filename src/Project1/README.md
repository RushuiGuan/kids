# Project 1

# Summary
Open the Project 1 using Visual Studio and Learn about the Visual Studio IDE (Integrated Development Environment)

# The Solution
* Read: [Visual Studio Wiki Page](https://en.wikipedia.org/wiki/Microsoft_Visual_Studio)
* Double click on the file `/c/github/learning/src/Learning.sln`
    * Visual Studio 2017 should launch.  If it is the first time, it might prompt you to login.  Use the outlook email credential to login.  You can also login using the button on the upper right corner.
    * ![Figure 1: Visual Studio Solution](../../images/project1_solution.jpg)
* Observe: The solution tab within Visual Studio.
    * The Learning.sln file is a visual studio solution.
    * A solution file can contain many projects.
    * Currently there is only one project - Project1
        * If you open the folder: `/c/github/learning/src/project1`, you can find the project file with the extension of .csproj.
* A project represents a program.  There are different kinds of programs.  Some are Web programs served by a web server, others are console programs that can be executed on a shell.
    * Project1 is a console program.

# The Project
* A project can contain many files.  Different files have different purposes.
    * README.md file - That's this file!  md stands for Mark Down.  It is a popular file format used to create documents.  It is widely adopted by many web sites and companies.  Here is a guide for [Github Markdown](https://guides.github.com/features/mastering-markdown/).
    * Dependencies - A group of files that are required for this project to function properly.
    * Properties - Project settings and configurations;  Something that will be visited later.
    * Program.cs - The Source code.  This is where you write your program.  
    
# The Source Code
    * A project could have many source code files.  Let's take a look at the Program.cs file

```csharp
//This is a comment; comment is created by leading double slashes
/*
this is also a comment;  it is created by pairing
*/
//this is the namespaces that is being referenced
using System;


namespace Project1 {
    public class Program
    { //sets of curly bracket { } indicates a scope, a scope is a block of code.
        static int Main(string[] args) {
            Console.WriteLine("Hello World!");
            return 0;
        }
    }
}
```