using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    internal class TrueOrFalse : BaseQuestion
    {
        public TrueOrFalse(string header, string body, string mark)
            : base(header, body, mark)
        {

            this.Answers = new Answers[]
            {
                    new Answers(1, "true"),
                    new Answers(2, "false")
            };
        }
        public override void Show()
        {
            Console.WriteLine(this);
            foreach (var item in this.Answers)
            {
                Console.WriteLine($"Answer: {item}");
            }
        }
    }
}
