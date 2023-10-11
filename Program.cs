using System.Text.RegularExpressions;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {//task1
            //Variant Variant = new Variant("a", true);
            //Variant Variant2 = new Variant("b", false);
            //Variant Variant3 = new Variant("c", false);
            //Question Question = new Question("Sabir", Variant,Variant2,Variant3);
            //Quiz Quiz = new Quiz("Sual",Question);
            //Quiz.Print();


            //task2

            Student student = CreateStudent();
            Console.WriteLine(student.Name);

        }
        public static Student CreateStudent()
        {
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int grade = int.Parse(Console.ReadLine());
            Student student = new Student(name,age,grade);
            return student;

        }
    }
    class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                string regexStr = @"^[A-Z][a-z]{2,}$";
                Regex regex = new Regex(regexStr);

                Match match = regex.Match(value);
                if (match.Success)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("DUZGUN EDED DAXIL ELEYIN");
                }
            }

        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0 || value < 100)
                {
                    value = _age;
                }
                else
                {
                    Console.WriteLine("Yasiviz catmir");
                }
            }
        }

        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _grade = value;
                }
                else
                {
                    Console.WriteLine("Duzgun qiymet daxil edin");
                }
            }
        }
        public Student(string name, int age, int grade)
        {
            _name = name;
            _age = age;
            _grade = grade;
        }


    }
}















































    //TASK1
//    class Quiz
//    {
//        public string Name { get; set; }
//        public Question[] Questions { get; set; }

//        public Quiz(string name,params Question[] questions)
//        {
//            Name = name;
//            Questions= questions;
//        }
//        public void Print()
//        {
//           for(int i=0;i<)
//        }
//    }

//    class Question
//    {
//        public string Text { get; set; }
//        public Variant[] Variants { get; set; }
//        public Question(string text, params Variant[] variants)
//        {
//            Text = text;
//            Variants = variants;
//        }

//    }

//    class Variant
//    {
//        public string Text { get; set; }
//        public bool IsTrue { get; set; }

//        public Variant(string text, bool isTrue)
//        {
//            Text = text;
//            IsTrue = isTrue;
//        }
//    }
//}