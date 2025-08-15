using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    internal class PracticalExam : BaseExam
    {
        public PracticalExam(TimeOnly time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            foreach (var question in Questions)
            {
                question.Show();
                Console.WriteLine("Your answer:");
                int answer = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"correct Answer :{question.RightAnswers}");
            }

        }


    }
}
