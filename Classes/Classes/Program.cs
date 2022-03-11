using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Ali", "Qafarov", 659, 100, true);
            Console.WriteLine("");
            student.Fullname();
            Console.WriteLine("");
            student.allInfo();
            Console.WriteLine("");
            student.examResult();

            Console.WriteLine("");
            Console.WriteLine("");

            Student student2 = new Student("Camal", "Abbas-Alizade", 659, 80, true);
            Console.WriteLine("");
            student2.Fullname();
            Console.WriteLine();
            student2.allInfo();
            Console.WriteLine("");
            student2.examResult();

            Console.WriteLine("");
            Console.WriteLine("");

            Student student3 = new Student("Rafael", "Agayev", 659, 42, false);
            Console.WriteLine("");
            student3.Fullname();
            Console.WriteLine("");
            student3.allInfo();
            Console.WriteLine("");
            student3.examResult();

            Console.WriteLine("");
            Console.WriteLine("");

            Student student4 = new Student("Resul", "Xaliqov", 659, 83, true);
            Console.WriteLine("");
            student4.Fullname();
            Console.WriteLine("");
            student4.allInfo();
            Console.WriteLine("");
            student4.examResult();

            Console.WriteLine("");
            Console.WriteLine("");

            Student student5 = new Student("Feryaz", "Hacimuradov", 659, 79, true);
            Console.WriteLine("");
            student5.Fullname();
            Console.WriteLine("");
            student5.allInfo();
            Console.WriteLine("");
            student5.examResult();
        }
        class Student
        {
            public string Name;
            public string Surname;
            public int Group;
            public int Point;
            public bool isGraduated;


            public Student(string Name, string Surname, int Group, int Point, bool isGraduated)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.Group = Group;
                this.Point = Point;
                this.isGraduated = isGraduated;

                Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\nisGraduated: {isGraduated}");
            }

            public void Fullname()
            {
                Console.WriteLine($"Name: {Name}\nSurname: {Surname}");
            }

            public void allInfo()
            {
                Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nGroup: {Group}\nPoint: {Point}\nisGraduated: {isGraduated}");
                if (Point > 51)
                {
                    isGraduated = true;
                    Console.WriteLine("This student was a graduate");
                }

                else
                {
                    isGraduated = false;
                    Console.WriteLine("This student wasn't graduate");
                }
            }
                public void examResult()
                {
                if (Point > 80)
                    Console.WriteLine($"This student's scores are {Point}.This student can enter the second exam");
                else
                    Console.WriteLine($"This student's scores are {Point}.This student can't enter the seceond exam");
                }
        }
    }
}
