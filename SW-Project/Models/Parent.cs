using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SW_Project.Models
{
    public class Parent : IUser
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

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


        // one to one relationship with student

       public Student student { get; set;}
       
        public object ViewSonInf()
        {
            return student.ViewStdInf;
        }

        public string NotifyAboutGrades(string message)
        {
            return $"Notification sent to {Name} about student's grade: {message}";
        }


    }
}
