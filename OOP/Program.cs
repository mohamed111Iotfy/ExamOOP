using OOP.Exam02;

namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            Subject subject = new Subject(20, "C#");
            BaseExam exam = new FinalExam(new TimeOnly(3, 0), 50);
            TrueOrFalse question1 = new TrueOrFalse("Q1", "Is C# a good programming language?", "4");
            question1.RightAnswers = new Answers(1, "True");
            exam.Questions[0] = question1;
            subject.CreateExam(exam);
            subject.ExamOfSubject.ShowExam();

        }
    }
}
