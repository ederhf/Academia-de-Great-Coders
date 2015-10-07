
using System;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void GiveBookAName(ref GradeBook book)
        {
            //book = new GradeBook();
            //book.Name = "Livro de Notas";
        }

        static void IncrementNumber(ref int number)
        {
            number = 42;
        }

        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Olá, Éder. É hora de estudar.");

            Array();

            //Immutable();

            //PassByValueAndRef();

            //GradeBook book = new GradeBook();
            //book.AddGrade(77);
            //book.AddGrade(54.25f);
            //book.AddGrade(41f);

            //GradeStatistics stats = book.ComputeStatistics();
            //Console.WriteLine(stats.AverageGrade);
            //Console.WriteLine(stats.LowestGrade);
            //Console.WriteLine(stats.HighestGrade);


        }

        private static void Array()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }

        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length >= 3)
            {
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
        }

        private static void Immutable()
        {
            string name = " Éder ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 10, 7);
            date = date.AddHours(25);

            Console.WriteLine(date);
            Console.WriteLine(name);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveBookAName(ref g2);
            Console.WriteLine(g2.Name);

            int x1 = 4;
            IncrementNumber(ref x1);
            Console.WriteLine(x1);
        }
    }
}
