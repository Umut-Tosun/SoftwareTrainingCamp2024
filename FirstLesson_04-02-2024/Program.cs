// See https://aka.ms/new-console-template for more information

using FirstLesson_04_02_2024.Business;
using FirstLesson_04_02_2024.Entities;

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//variables --> camelCase
bool isAuthhenticated = true;

Console.WriteLine(message1);

//condition
if (isAuthhenticated )
{
    Console.WriteLine("Buton --> Hoşgeldin User");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yapmalısın");
}


string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; // will be dynamic data

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

     //start     //condition     //increment
for (int i = 0; i < loans.Length; i++) //i mean index
{
    Console.WriteLine(loans[i]);
}

Course course = new Course();
course.Id = 1;
course.Name = "C#";
course.Description = ".NET 8 Training Camp";
course.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Spring Camp";
course2.Price = 0;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python Camp";
course3.Price = 0;

Course[] courses = { course, course2, course3 };

for (int i = 0;i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " "+ courses[i].Price);
}

CourseManager courseManager = new();
Course[] courses2 =  courseManager.GetAll();


for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " " + courses2[i].Price);
}


Console.WriteLine("Kod Bitti.");

