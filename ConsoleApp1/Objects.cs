namespace ConsoleApp1
{
    internal class Objects
    {
       
    }

    class School
    {
        public int Oppervlakte { get; set; }

        public string Naam { get; set; } = "No name";

        public List<Student> Studenten { get; set; } = new List<Student>();
    }

    class Student
    {
        public Student() 
        {
        }
        
        public Student(int _studentNummer, string _studentName, string _specialty)
        {
            Studentnummer= _studentNummer;
            Naam = _studentName;
            Specialiteit= _specialty;
        }
        
        public int Studentnummer { get; set; }

        public string? Naam { get; set; }

        private string? Specialiteit { get; set; }

        public string? GeefSpecialiteit()
        {
            return Specialiteit;
        }
    }
}
