# modopt
Demonstrates a problem overriding methods with modopt in F# 3.1

This repository contains an abstract base class in C++/CLI which has two(differently named) abstract methods, 
one returning an int and another returning a 'long' (which is also a 32-bit value in C++).

Both methods return System.Int32, but the C++/CLI compiler decorates the method returning long with a modopt flag 
indicating that the int was actually a long in C++ speak.

There are 3 derived classes, written in C++/CLI, C# and F#. All 3 override the two methods of the abstract base class, 
and all 3 compile - but referencing the F# class crashes at runtime with an exception:
```
System.TypeLoadException was unhandled
Message: Method 'GetLong' in type 'FSharp.FSharpDerived' from assembly 'FSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' does not have an implementation.
```

Looking at the IL with ILSpy, the C# compiler copies the modopt flag from the base method into the derived method, 
but the F# compiler doesn't - and so the CLR complains when loading the assembly.
