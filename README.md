# Uninitialized Property Access in C# Method

This repository demonstrates a subtle bug in C# where a class property is accessed within a method before it has been assigned a value.  This can lead to unexpected behavior, particularly if the property's default value (0 for integers, null for objects, etc.) isn't suitable for the operation.

The `bug.cs` file contains the buggy code. The `bugSolution.cs` file provides the corrected version.

## Bug

Accessing a property before initialization can result in an exception or incorrect calculations depending on the context.  In this specific example, `MyProperty` is used in a calculation before it's given a value, leading to undefined behavior.

## Solution

The solution involves initializing `MyProperty` either directly in the class declaration or before its value is used within the method.