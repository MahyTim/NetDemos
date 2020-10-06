using System.Data.SqlClient;
using System.Dynamic;
using Dapper;
using static System.Console;

namespace DLR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Usages_Serialization();
            //DynamicObject_Example();
            //Usages_SQLReader();
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

        static void Usages_SQLReader()
        {
            var records = new SqlConnection().Query("SELECT TOP 5 Name FROM x");
            foreach (var record in records)
            {
                WriteLine(record.Name);
            }
        }
    }
}