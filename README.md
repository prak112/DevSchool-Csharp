# C# Learnings
*SOURCE : [Microsoft Learn-Down the Rabbit hole...](https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/)* :octocat:

## Overview

- This repository contains basic C# programs that demonstrate the fundamental concepts of C#, includes and not limited to :
   - Datatypes
   - String operations
   - Loops
   - Data Structures (Arrays, Lists)
   - Classes
- The programs are written in Visual Studio 2022 and can be run on Windows, Linux or MacOS
- Includes tasks and final assignment from Software Developer Training at Savon Ammattiopisto (SAKKY)

## Table of Contents

- [Fundamentals](#fundamentals)
- [Type System](#type-system)
- [Execution and Program Hierarchy](#execution-and-program-hierarchy)
- [Usage](#usage)
- [License](#license)
-------------

## Fundamentals
### C# Features
 - Garbage Collection (check Source for more), i.e., automated reclamation of memory occupied by unreachable unused objects
 - LINQ, Language Integrated Query, to provide commmon-pattern syntax to work with data from any source

### C# Program Execution
- C# compiles the code to IL (Intermediate Language)
- Code in IL is converted by .NET (CLR-Common Language Runtime & Set of Class libraries) to native-machine instructions by JIT (JustInTime) compilation


### GENERIC CLASS

* Class - collection of methods, Ex. string / List
* Method - specific function inside a Class, Ex.string.Length / List.Count
* Object(Variable using Class) - template of the Class called inside a Program for multiple use, i.e., instance of a class
    * Example 1 - calls string Class and saves string fiveStars as "*****"
    ```sh
    string fiveStars = new string("*", 5);  
    ```
    * Example 2 - List class is called to create a new object "genericArray". All items are saved in it
    ```sh
    List<var> genericArray = new List<var>() { 32, "randy", 21.4, "2.1325", True }  
    ```    


## TYPE System

* .NET Framework follows [Common Type System or CTS](https://learn.microsoft.com/en-us/dotnet/standard/base-types/common-type-system).
* CTS supports following 5 different categories :
    1. <b>Classes
    2. Structures
    3. Enumerations
    4. Interfaces
    5. Delegates</b>
* RECORD, used to define any of the TYPES for storage and minimal associated behavior (for ex. record struct, record class, etc.)
* VALUE TYPES (Immutable)
    * Simple (int, short, float, double, decimal, bool, char)
    * Enum
    * Struct (similar to class, but inherits from Object)
    * Nullable
    * Tuple
* REFERENCE TYPES (Mutable)
    * Class
        * Unicode Strings (string)
        * User-defined
    * Interface (possible Network Programming feature)
    * Array
    * Delegate (equivalent to Decorators in Python)


## Execution and Program Hierarchy

* PROGRAMS (multiple Files and/or namespaces)
* NAMESPACES (holds Classes, Properties and everything included in the Program)
* TYPES (Value & Reference, ex. Class, Array, int, string, etc.)
* MEMBERS (Methods, Properties)
* ASSEMBLIES (Metadata, ex: .exe or .dll files)


------------
## Usage

### Getting Started
To get a local copy up and running follow these simple steps.

### Prerequisites
- Visual Studio 2022
- .NET Framework 6.0 or later


### Installation
1. Clone the repo
   ```sh
   git clone https://github.com/prak112/sakky-okk-Cperus.git
   ```
2. Open the solution file in Visual Studio.

### Working
1. Create a new Project
2. Build your Logic
3. Click on ```<project_name>.sln``` file
4. Debug the program
5. Correct errors as shown in *"Error List"*

### Contributing
Contributions are what make the open source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License
Distributed under the MIT License. See `LICENSE` for more information.

[![LinkedIn][linkedin-shield]][linkedin-url]

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->

[!contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues

[license-shield]: https://img.shields.io/github/license/prak112/Best-README-Template.svg?style=for-the-badge
[license-url]: https://choosealicense.com/licenses/mit/
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/prakirth-govardhanam-3a185156/
[product-screenshot]: images/screenshot.png
