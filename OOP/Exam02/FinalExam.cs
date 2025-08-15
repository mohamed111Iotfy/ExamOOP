using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    internal class FinalExam : BaseExam
    {

        public FinalExam(TimeOnly time, int numberOfQuestions) : base(time, numberOfQuestions)
        {

        }

        public override void ShowExam()
        {
            int totalmarks = 0;
            int totalPossibleMarks = 0;
            int questionIndex = 0;

            foreach (var question in Questions)
            {
                question.Show();
                Console.WriteLine($"Question {questionIndex++}: {question.Body}");
                int ans = int.Parse(Console.ReadLine()!);

                if (question.Answers != null & ans == question.RightAnswers.AnswerId)
                    totalmarks += int.Parse(question.Mark);

                totalPossibleMarks += int.Parse(question.Mark);
            }
            Console.WriteLine($"your Grade :{totalmarks}/{totalPossibleMarks}");


        }


    }
}
