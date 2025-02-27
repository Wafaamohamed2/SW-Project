# Student Management System
  # Project Description
    The Student Management System is a comprehensive platform designed to manage students, teachers, 
    and parents in a school or university setting. The system provides an easy-to-use interface for handling daily operations 
    such as student registration, exam creation, sending notifications to parents, and tracking attendance.

  # Key Features
  
  1. Student Management :
    - Register new students : Add new students to the system with their personal and academic details.
    - Update student information : Modify student records such as name, email, and grade.
    - Track student grades : Monitor and manage student performance over time.

  2. Teacher Management :
    - Create exams and assignments : Teachers can create exams with multiple questions and set time limits.
    - Distribute exams to students : Exams are distributed to students via the EducationBot.
    - Monitor student performance : Teachers can review student grades and provide feedback.

  3. Parent Management :
    - Send notifications to parents : Parents receive notifications about their child's grades and attendance.
    - Alert parents if grades fall below 50 : Automatic alerts are sent to parents if a student's grade is below the passing threshold.

  4. Exam System:
    - Create exams : Teachers can create exams with multiple questions and set time limits.
    - Distribute exams : Exams are distributed to students via the EducationBot.
    - Review answers and provide feedback : Teachers can review student answers and provide personalized feedback.

  5. Attendance Tracking :
    - Record student attendance: Track student attendance using fingerprint or manual entry.
    - Calculate absence rates: Automatically calculate and display absence rates for students.

  6. ChatBot Integration :
    - Distribute exams to students: The EducationBot handles the distribution of exams to students.
    - Review student performance: The bot reviews student performance and provides feedback.
    - Send tips and notifications: The bot sends tips and notifications based on student grades and attendance.

# Database Schema :
 ~ Entities and Relationships
   1. Student Relationships:
         One-to-One with Parent.
         One-to-Many with Attendance.
         Many-to-Many with Exam.
         
   2. Parent Relationships:
        One-to-One with Student.

   3. Teacher Relationships:
        One-to-Many with EducationBot.
      
   5. Exam Relationships:
        Many-to-Many with Student.

   6. Attendance Relationships:
        Many-to-One with Student.

   7. EducationBot Relationships:
        Many-to-One with Teacher, Exam, and Student.


# Technologies Used :
   - Programming Language: C#

   - Database: SQL Server

   - ORM: Entity Framework Core

   - User Interface: Console Application (can be extended to Windows Forms or WPF)

   - Project Management: GitHub
