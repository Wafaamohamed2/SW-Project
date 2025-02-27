namespace SW_Project.Models
{
    public class Exam
    {
       public int Id { get; set; }
        public string ExamName { get; set; }
        public int TimeLimitInMinutes { get; set; }
        public List<string> Questions { get; set; } = new List<string>();

        public int QuestionsCount => Questions.Count; 
        
        public Exam() { }
        public Exam(string examname , int examtime) {
        
          ExamName = examname;
          TimeLimitInMinutes = examtime;
        }

        public void AddQuestion(string question)
        {
            Questions.Add(question);
        }
        public void RemoveQuestion(string question) {
            Questions.Remove(question);
        }


        //many to many relationship with student
        public ICollection<Student> Students { get; set; } = new List<Student>();   
    }
}
