# C# Object Instantiation and Variable Scope Issue
This repository demonstrates a common misunderstanding in C# regarding object instantiation and variable scope. The `bug.cs` file contains code that incorrectly handles object instances, leading to unexpected behavior.  The `bugSolution.cs` file provides the corrected code.

## Problem
The program creates two instances of the `MyClass` class.  While the second instance is created with a different value for `MyProperty`, the output shows the value from the first instance, indicating that the program is not correctly using the second instance.  This is due to a misunderstanding of how objects and their properties are handled in C#.

## Solution
The solution shows the correct way to access and modify properties of different object instances.