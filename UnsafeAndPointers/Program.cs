using System;
using System.Runtime.InteropServices;
using static System.Console;

namespace UnsafeAndPointers
{
    class Program
    {
        static void Main(string[] args)
        {
            //We_all_live_in_a_container();
            Hello_Pointers();
        }

        private static unsafe void Hello_Pointers()
        {
            //TODO: void*
            //TODO: structs
            //TODO: statics & fixed

            // Keyword on method (scoped also allowed)
            // See csproj

            // var age = 15;
            // int* agePointer = &age;
            // var letter = 'A';
            // char* letterPointer = &letter;
            //
            // Console.WriteLine($"{age} on memory {(long)agePointer}");
            // Console.WriteLine($"{letter} on memory {(long)letterPointer}");
            //
            // *letterPointer = 'B';
            // Console.WriteLine($"{age} on memory {(long)agePointer}");
            // Console.WriteLine($"{letter} on memory {(long)letterPointer}");
            //
            // char** pointerToLetterPointer = &letterPointer;
            // Console.WriteLine($"{(long)pointerToLetterPointer} points to {(long)letterPointer} points to {letter}");

            // Person person = new Person() {Age = 37, NumberOfChildren = 2};
            // Person* pointerToPerson = &person;
            // Console.WriteLine(pointerToPerson->Age);
            // Console.WriteLine(pointerToPerson->NumberOfChildren);
            //
            // int* pointerToAge = &pointerToPerson->Age;
            // pointerToAge[0] = 38;
            //
            // Console.WriteLine(pointerToPerson->Age);
            // Console.WriteLine(pointerToPerson->NumberOfChildren);
            //
            // Console.WriteLine((long) &pointerToPerson->Age);
            // Console.WriteLine((long) &pointerToPerson->NumberOfChildren);
            //
            // Console.WriteLine(pointerToPerson->Get(0));
            // Console.WriteLine(pointerToPerson->Get(1));
        }

        public struct Person
        {
            public int NumberOfChildren;
            public int Age;
        }
        
        // //[StructLayout(LayoutKind.Explicit)]
        // public struct Person
        // {
        //     [FieldOffset(0)] public int NumberOfChildren;
        //     //[FieldOffset(4)]
        //     //[FieldOffset(sizeof(int))]
        //     public int Age;
        //     
        //     // [FieldOffset(0)]
        //     // private unsafe fixed int indexed[2];
        //     //
        //     // public int Get(int index)
        //     // {
        //     //     return indexed[index];
        //     // }
        // }

        private static void We_all_live_in_a_container()
        {
            var z = int.MaxValue;
            WriteLine(z + 1);


            // checked
            // {
            //     WriteLine(z+1);    
            // }
            //
            // unchecked
            // {
            //     WriteLine(z+1);
            // }
        }
    }
}