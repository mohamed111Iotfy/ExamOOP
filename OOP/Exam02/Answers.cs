using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    public class Answers
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }


        public Answers(int id, string AnsText)
        {
            AnswerId = id;
            AnswerText = AnsText;
        }

        public static BaseQuestion[] Add(BaseQuestion[] array, BaseQuestion newItem)
        {
            if (array == null)
            {
                return new BaseQuestion[] { newItem };
            }

            BaseQuestion[] newArray = new BaseQuestion[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[array.Length] = newItem;
            return newArray;
        }

        public override string ToString()
        {
            return $"{AnswerId}: {AnswerText}";
        }

    }
}
