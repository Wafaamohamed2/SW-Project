namespace SW_Project.Models
{
    public class Student : IUser
    {
        //Properties
        #region       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public int Grade { get; set; }
        private string Subject { get; set; }

        public int Level { get; set; }
        public int Absences { get; set; }

        #endregion

        //Constructor
        #region
        public Student()
        {
        }
        public Student(int id ,string name ,string email , string password,int grade, string subject, int level, int absences)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Grade = grade;
            Subject = subject;
            Level = level;
            Absences = absences;
        }
        #endregion


        // Registration Methods
        #region
        public bool Login(string email, string password)
        {
            if (this.Email == email && this.Password == password)
            {
                Console.WriteLine(" login successful!");
                return true;
            }
            Console.WriteLine(" login failed!");
            return false;
        }

        public bool SignUp(string name, string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                this.Name = name;
                this.Email = email;
                this.Password = password;
                Console.WriteLine(" signup successful!");
                return true;
            }
            Console.WriteLine(" signup failed!");
            return false;
        }
        #endregion



        // Exam Methods
        #region
        public void Do_Quiz(Exam exam)
        {
            Console.WriteLine($"Student {Name} is doing the quiz: {exam.ExamName}" +
                $"Time Limit : {exam.TimeLimitInMinutes} minutes , Total questions: {exam.QuestionsCount} ");


      

        }
        public int Preview_Quiz(Exam exam)
        {
            // Random grade just for testing

            Random random = new Random();
            int grade = random.Next(0, 100);
            Console.WriteLine($"Student {Name} finished the quiz with grade: {grade} out of 100");

            return grade;
        }

            //public Exam Submit_Quiz(Exam exam)
            //{
            //    return ;
            //}
            #endregion




            public void ViewStdInf(Student student)
        {
            Console.WriteLine($"Student Info: ID={student.Id}, Name={student.Name}, Level={student.Level}");
        }

        public void ChatInterface(EducationBot chat)
        {
            
        }

       

        // one to one relationship with parent

        public Parent parent { get; set; }


    }
}
