// See https://aka.ms/new-console-template for more information
using Lab_01;
using System.Security.Cryptography.X509Certificates;

var materie1 = new Materie
{
    Denumire = "Algoritmi fundamentali",
    Durata = "2h curs, 2h seminar/lab"
};

var materie2 = new Materie
{
    Denumire = "Dezvoltare Aplicatii Web",
    Durata = "2h curs, 2h lab"
};

var materie3 = new Materie
{
    Denumire = "Dezvoltare Aplicatii Web",
    Durata = "2h curs, 2h lab"
};

var student1 = new Student
{
    Nume = "Ionescu",
    Prenume = "Alex",
    CNP = "5010101170018",
    Materii = new List<Materie> { materie1, materie2 },
    NrMatricol = "195/2022"
};

var student2 = new Student
{
    Nume = "Bobiță",
    Prenume = "Andrei",
    CNP = "5020202450019",
    Materii = new List<Materie> { materie1, materie3 },
    NrMatricol = "34/2022"
};

var student3 = new Student
{
    Nume = "Tedi",
    Prenume = "Zamfir",
    CNP = "5030303230019",
    Materii = new List<Materie> { materie1, materie2, materie3 },
    NrMatricol = "367/2022"
};

foreach (Materie subject in student2.Materii)
{
    Console.WriteLine(subject.Denumire + ": " + subject.Durata);
}

foreach (Student student in new List<Student> { student1, student2, student3 })
{
    Console.WriteLine(student.NrMatricol);
}