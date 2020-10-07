# Execution modes

- All .NET code is running under control of the CLR
- CLR knows everything about the memory scpace, types, variables, stack frames, objects
- CLR performs some checks (arithmetic overflow etc...)

|    |  Managed  |  Native   |
|:---|:---|:---|
|  Code execution  | Safety ensured by the CLR   | No safety guarantees   |
|  Memory management  |  Garbage collection  |  Manual  |
|  Error handling  |  Exception handling  |   Return values / SEH / C++ / exceptions |

# P-Invoke basics

- Allows calling C-style functions
- C-style functions have no metadata except the function name itself

Calling a C-style function:

- Create a static method and mark it as 'extern'
- Use DLLImport to help the CLR to find the function
- P/Invoke engine will call LoadLibrary and GetProcAddress behind the scenes

