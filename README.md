# Uninitialized Property Access in C#

This repository demonstrates a subtle bug in C# related to accessing properties before they are initialized. The `ExampleClass` has a property `MyProperty`, which is used in the `MyMethod` before being assigned a value. This can lead to unexpected behavior depending on the context in which the object is created and used.

## Bug Description
The `MyMethod` attempts to use the value of `MyProperty` in a calculation before it's given an explicit value. If the `MyProperty` has not been initialized it may contain the default value for its type. This can cause unexpected results or exceptions.

## Solution
The solution involves initializing the `MyProperty` either in the constructor of `ExampleClass` or before calling `MyMethod`. This way you can be sure the value is set before being used in operations.

## How to Reproduce
1. Clone the repository.
2. Open the `bug.cs` file and observe the uninitialized property access.
3. Run the code and see the potential unexpected behavior.
4. Open `bugSolution.cs` to see how initializing the property fixes the issue.