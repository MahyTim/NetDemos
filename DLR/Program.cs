using System.Dynamic;
using static System.Console;

namespace DLR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usages_Serialization();
            //DynamicObject_Example();
        }

        static void DynamicObject_Example()
        {
            dynamic x = new Person(10);
            //WriteLine(x._age);
            
            //x = new ReflectionDynamicObject(new Person(5));
            //WriteLine(x._age);
        }

        static void Usages_Serialization()
        {
            dynamic z = new ExpandoObject();
            z.Naam = "Tim";
            z.Achternaam = "Mahy";

            WriteLine(System.Text.Json.JsonSerializer.Serialize(z));
            
            
            
            
            
            // var jsonString = "{\"Naam\": \"Tim\",\"Achternaam\":\"Mahy\"}";
            // dynamic result = System.Text.Json.JsonSerializer.Deserialize(jsonString, typeof(ExpandoObject));
            // Console.WriteLine(result.Naam);
            //https://github.com/dotnet/runtime/issues/29690
            
            
            
            
            
            
            

            //dynamic result = Newtonsoft.Json.Linq.JObject.Parse(jsonString);
            //Console.WriteLine(result.Naam);


            
            
            
            
            
            // var person = new {Voornaam = "Tim", Achternaam = "Mahy"};
            // WriteLine(System.Text.Json.JsonSerializer.Serialize(person));
        }
    }
}

