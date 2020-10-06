using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Threading.Channels;
using static System.Console;

namespace ExpandoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = new System.Dynamic.ExpandoObject();
            d.Z = "10";
            WriteLine(d.Z);
            WriteLine(d.Z.GetType());
    
            // d.Z = 100;
            // WriteLine(d.Z);
            // WriteLine(d.Z.GetType());
            
            // d.Print = new Action<string>((s) => WriteLine(s));
            // d.Print("test");
            
            // d.Event = null;
            // d.Event += new Action<object,EventArgs>((o, eventArgs) => WriteLine(o) );
            // d.Event("testEvent", new EventArgs());
            
            
            // foreach (var z in d)
            // {
            //     Console.WriteLine(z.Key);   
            // }
            
            
            
            
            
            
            
            
            
            
            
            
            // IDictionary<string, object> z = d;
            // foreach (var i in z)
            // {
            //     WriteLine(i);
            // }
            //
            
            
            
            
            
            
            
            
            
            
            
            
            // z.Remove("Print");
            // d = z;
            // foreach (var i in z)
            // {
            //     WriteLine(i);
            // }
            //
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            // ((INotifyPropertyChanged) d).PropertyChanged += (sender, eventArgs) => WriteLine(eventArgs.PropertyName);
            // d.Z = "500";
            // d.Z = "1500";
        }
    }
}