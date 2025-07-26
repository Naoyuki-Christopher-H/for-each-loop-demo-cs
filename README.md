# For-Each Loop Demo in C#

## Overview

This project demonstrates the use of a **for-each loop** in C#. 
It provides a simple example of iterating over a collection of strings (car brands) and printing each element to the console.

## Features

* Illustrates basic `foreach` syntax in C#
* Uses an array of strings to simulate a collection
* Includes error handling with `try-catch-finally` blocks
* Outputs results to the console

## Code Example

```csharp
String[] cars = { "Nissan", "Mazda", "Toyota" };
int count = 1;

foreach (String car in cars) 
{ 
    Console.WriteLine($"CAR {count}: {car}");
    count++;
}
```

## Output

When executed, the program will display:

```
CAR 1: Nissan
CAR 2: Mazda
CAR 3: Toyota
Press any key to exit...
```

## How to Run

1. Clone the repository:

   ```bash
   git clone https://github.com/Naoyuki-Christopher-H/for-each-loop-demo-cs.git
   ```
2. Open the solution in [Visual Studio](https://visualstudio.microsoft.com/) or another C# IDE.
3. Build and run the project.

## Requirements

* .NET Framework or .NET Core/SDK (compatible with C# projects)
* A C# development environment (e.g., Visual Studio, JetBrains Rider, VS Code with C# extension)

## DISCLAIMER  

UNDER NO CIRCUMSTANCES SHOULD IMAGES OR EMOJIS BE INCLUDED DIRECTLY IN 
THE README FILE. ALL VISUAL MEDIA, INCLUDING SCREENSHOTS AND IMAGES OF 
THE APPLICATION, MUST BE STORED IN A DEDICATED FOLDER WITHIN THE PROJECT 
DIRECTORY. THIS FOLDER SHOULD BE CLEARLY STRUCTURED AND NAMED ACCORDINGLY 
TO INDICATE THAT IT CONTAINS ALL VISUAL CONTENT RELATED TO THE APPLICATION 
(FOR EXAMPLE, A FOLDER NAMED IMAGES, SCREENSHOTS, OR MEDIA).

I AM NOT LIABLE OR RESPONSIBLE FOR ANY MALFUNCTIONS, DEFECTS, OR ISSUES THAT 
MAY OCCUR AS A RESULT OF COPYING, MODIFYING, OR USING THIS SOFTWARE. IF YOU 
ENCOUNTER ANY PROBLEMS OR ERRORS, PLEASE DO NOT ATTEMPT TO FIX THEM SILENTLY 
OR OUTSIDE THE PROJECT. INSTEAD, KINDLY SUBMIT A PULL REQUEST OR OPEN AN ISSUE 
ON THE CORRESPONDING GITHUB REPOSITORY, SO THAT IT CAN BE ADDRESSED APPROPRIATELY 
BY THE MAINTAINERS OR CONTRIBUTORS.

---
