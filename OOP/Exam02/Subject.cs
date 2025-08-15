using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam02
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }

        public BaseExam ExamOfSubject { get; set; }


        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;

        }

        public void CreateExam(BaseExam exam)
        {
            ExamOfSubject = exam;
        }



    }
}
