using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    internal class MCQ : BaseQuestion
    {


        public MCQ(string header, string body, string mark)
            : base(header, body, mark)
        {
            Answers = new Answers[20];

        }

        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var item in Answers)
            {
                Console.WriteLine($"Answer: {item}");
            }
        }
    }
}
