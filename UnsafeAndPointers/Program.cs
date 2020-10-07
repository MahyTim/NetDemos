using System;
using System.Runtime.InteropServices;
using System.Text;
using static System.Console;

namespace UnsafeAndPointers
{
    class Program
    {
        private static int I_am_static = 5;
        
        static void Main(string[] args)
        {
            //We_all_live_in_a_container();
            //Hello_Pointers();
            //Hello_MemorySpace();
            //Fix_it();
        }

        private unsafe static void Fix_it()
        {
            // int z = 10;
            // int* zPointer = &z;
            // int x = 20;
            // int* xPointer = &z;
            //
            // Console.WriteLine((long) zPointer);
            // Console.WriteLine((long) xPointer);
            //
            // int* pointer = &I_am_static;
            // {
            //     Console.WriteLine((long) pointer);
            //     GC.Collect();
            //     Console.WriteLine((long) pointer);
            // }
        }

        private unsafe static void Hello_MemorySpace()
        {
            // var pointer = Marshal.AllocHGlobal(cb: sizeof(Person));
            // Console.WriteLine(pointer);
            // Marshal.StructureToPtr(new Person()
            // {
            //     Age = 37,
            //     NumberOfChildren = 2
            // },pointer, false);
            // Console.WriteLine(Marshal.ReadInt32(pointer ));
            //
            // var person = Marshal.PtrToStructure<Person>(pointer);
            // Console.WriteLine(person.Age);
            // Marshal.FreeHGlobal(pointer);

            
            
            
            

            // Person[] array = new Person[2];
            // array[0] = new Person {Age = 18, NumberOfChildren = 5};
            // array[1] = new Person {Age = 20, NumberOfChildren = 1};
            // GCHandle handle = GCHandle.Alloc(array, GCHandleType.Pinned);
            // try
            // {
            //     IntPtr pointer = handle.AddrOfPinnedObject();
            //     int[] copy = new int[array.Length*2];
            //     Marshal.Copy(pointer, copy, 0, copy.Length);
            //     for (int i = 0; i < copy.Length; i++)
            //     {
            //         Console.WriteLine(copy[i]);
            //     }
            // }
            // finally
            // {
            //     if (handle.IsAllocated)
            //         handle.Free();
            // }

            
            
            

            // var pointer = Marshal.AllocHGlobal(cb: 2 * 4);
            // var bytes = Encoding.ASCII.GetBytes("Test");
            // for (int i = 0; i < bytes.Length; i++)
            // {
            //     Marshal.WriteByte(pointer + i, bytes[i]);
            // }
            //
            // var s = Marshal.PtrToStringAnsi(pointer,4);
            // Console.WriteLine(s);
        }

        private static unsafe void Hello_Pointers()
        {
            //TODO: void*
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


            // var pointer = Marshal.OffsetOf(typeof(Person), "Age");
            // Console.WriteLine(pointer);
            // pointer = Marshal.OffsetOf(typeof(Person), "NumberOfChildren");
            // Console.WriteLine(pointer);
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
