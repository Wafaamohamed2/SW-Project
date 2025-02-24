using SW_Project.Models;

namespace SW_Project.Model
{
    public class EducationBot
    {
        public string Take_Exam_From_Tech_To_Student(Teacher teacher, List<Student> students, Exam Quiz)
        {


            Console.WriteLine($"Exam '{Quiz.ExamName}' is created by {teacher.Name}.");

            foreach (var student in students)
            {
                student.Do_Quiz(Quiz);
            }

            return $"Exam '{Quiz.ExamName}' is sent to {students.Count} students.";
        }

       
        public void ReviewExamAndProvideFeedback(List<Student> students, List<int> degrees)
        {
            string feedback = "";
            string tips = "";
            foreach (var student in students)
            { 
                if (degrees[students.IndexOf(student)] >= 90)
                {
                    feedback = "Excellent work! You have a deep understanding of the material !";
                    tips = "Keep up the good work and challenge yourself with advanced topics !";
                }
                else if (degrees[students.IndexOf(student)] >= 70)
                {
                    feedback = "Good job! You have a good understanding of the material!";
                    tips = "Try to focus on the weak points and improve them!";
                }
                else if (degrees[students.IndexOf(student)] >= 50)
                {
                    feedback = "You need to study more!";
                    tips = "Try to study more and focus on the weak points!";
                }
                else
                {
                    feedback = "You need to study more!";
                    tips = "Try to study more and focus on the weak points!";
                }
                Console.WriteLine($"Student {student.Name} got {degrees[students.IndexOf(student)]} out of 100. {feedback} {tips}");

            }

        }
        public void Notify_Parents_About_Grades(Parent parent,Student student, int degree)
        {
            string Message;
            if (degree < 50)
            {
                 Message = $"Your Child {student.Name} Scored {degree} ..  This is below the passing grade. Please take necessary actions ";
                parent.NotifyAboutGrades(Message);
            }
            else {

                Message = $"Your Chaid {student.Name} Scored {degree} .. This is a good grade .. please encorage him";
              
            }
        }
    }
}

