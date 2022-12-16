using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string y = "5";
            // Omzetten van string naar int
            float z = float.Parse(y);

            Console.WriteLine(z * 3);

            // Vraag voor een getal
            Console.WriteLine("Geef een getal in voor x? ");
            int x = int.Parse(Console.ReadLine());

            // If statements
            if (x > 3)
            {
                Console.WriteLine("X is groter als 3");
            }
            else if (x == 3)
            {
                Console.WriteLine("X is 3");
            }
            else
            {
                Console.WriteLine("X is niet groter als 3");
            }

            // LOOPS
            // For loop
            // i += 2 betekent i = i + 2
            for (int i = 0; i <= 4; i += 2)
            {
                Console.WriteLine(i);
            }

            // While loop
            int j = 4;
            while (j >= 0)
            {
                Console.WriteLine(j);
                j -= 1;
            }

            // Variabelen zijn alleen beschikbaar binnen hun 'scope'
            // Onderstaand zal niet werken, want nummer bestaat alleen binnen het if-statement
            // if (true)
            // {
            //    int nummer = 5;
            // }
            // Console.WriteLine(nummer);

            // Dit is op te lossen door de variabele al eerder aan te maken
            int nummer;
            if (true)
            {
                nummer = 5;
            }

            Console.WriteLine(nummer);

            // Lists
            List<int> onzeLijst = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            onzeLijst.Add(5);
            onzeLijst.Remove(5);

            foreach (int item in onzeLijst)
            {
                Console.WriteLine(item);
            }

            // Dictionary
            Dictionary<string, int> leeftijden = new Dictionary<string, int>();
            leeftijden["Finn"] = 20;
            Console.WriteLine("De leeftijd van Finn is " + leeftijden["Finn"]);



            // Klasses en objecten (klasses staan in objects.cs)
            School school = new School() { Naam = "Zuyd Hogeschool", Oppervlakte = 1000 };

            Console.WriteLine(school.Naam);

            Student cooleStudent = new Student() { Studentnummer = 1234, Naam = "Joey" };

            school.Studenten.Add(cooleStudent);

            Student ralf = new Student() { Studentnummer = 4321, Naam = "Ralf" };
            school.Studenten.Add(ralf);

            Student nieuweStudent = new Student(123, "Finn", "AI");

            school.Studenten.Add(nieuweStudent);

            // nieuweStudent.Specialiteit mag niet, want Specialiteit is private.
            // De functie GeefSpecialiteit mag wel, want die functie is public.
            // Het vraagteken achter string geef aan dat het null zou kunnen zijn.

            string? specialty = nieuweStudent.GeefSpecialiteit();
        }

        // Functie
        int telOp(int x, int y)
        {
            return x + y;
        }

        void printHallo()
        {
            Console.WriteLine("Hallo");
        }
    }
}