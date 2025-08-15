using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    public abstract class BaseExam
    {
        public TimeOnly TimeOfExam { get; set; }
        public int NumberOfQuestions { get; set; }


        public BaseQuestion[] Questions { get; set; }

        public BaseExam(TimeOnly time, int numberOfQuestions)
        {
            TimeOfExam = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new BaseQuestion[numberOfQuestions];
        }

        public abstract void ShowExam();
    }
}
