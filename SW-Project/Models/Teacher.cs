namespace SW_Project.Models
{
    public class Teacher : IUser
    {
        // Properties
        #region
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string Subject { get; set; }
        #endregion


        // Registration Methods
        #region
        public bool Login(string email, string password)
        {

            if (this.Email == email && this.Password == password)
            {
                Console.WriteLine("login successful!");
                return true;
            }
            Console.WriteLine("login failed!");
            return false;
        }
       

        public bool SignUp(string name, string email, string password)
        {
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                this.Name = name;
                this.Email = email;
                this.Password = password;
                Console.WriteLine("signup successful!");
                return true;
            }
            Console.WriteLine("signup failed!");
            return false;
        }
        #endregion


        // Teacher Methods
        #region
        public Exam Create_Quiz(string examName , int ExameTime , List<string>questions)
        {
           var exam = new Exam(examName, ExameTime);
            foreach (var question in questions)
            {
                exam.AddQuestion(question);
            }

            Console.WriteLine($"Quiz {examName} created successfully with {exam.QuestionsCount} questions " );
            return exam;
        }

        public string Submit_Quiz_To_Chat(string quiz)
        {
            return quiz + " Submit";
        }

        public string Provide_Quiz_Answers(string quiz)
        {
            return quiz + " Answers";
        }
        #endregion

        // many to one relationship with student
        public List<Student> students { get; set; } = new List<Student>();
    }
}
