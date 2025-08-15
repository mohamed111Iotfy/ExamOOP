using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    public abstract class BaseQuestion : ICloneable, IComparable<BaseQuestion>
    {


        public string Header { get; set; }
        public string Body { get; set; }

        public string Mark { get; set; }

        public Answers[] Answers { get; set; }

        public Answers? RightAnswers { get; set; }

        public BaseQuestion(string header, string body, string mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = new Answers[20];
        }

        public abstract void Show();

        public int CompareTo(BaseQuestion? other)
        {
            if (other == null) return 1;
            return string.Compare(Header, other.Header, StringComparison.Ordinal);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Header} - {Body} - {Mark}";
        }

    }
