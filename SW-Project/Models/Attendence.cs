﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SW_Project.Models
{
    public class Attendence
    {
        public int Id { get; set; }

        private readonly SW_Entity _context;

        public Attendence(SW_Entity context)
        {
            _context = context;
        }


        // Method to record attendance for a student
        #region  
        public void RecordAttendance(string fingerId)
        {
            // check if student has fingerid record , if the fingerId is invalid
            if (string.IsNullOrEmpty(fingerId))
            {
                Console.WriteLine("Invalid finger ID. Attendance not recorded.");
                return;
            }
            var student = _context.Students.FirstOrDefault(s => s.FingerId == fingerId);

          
                if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            var record = new AttendenceRecord
            {
                StudentId = student.Id,
                AttendenceDate = DateTime.Now
            };

            _context.AttendenceRecords.Add(record);
            _context.SaveChanges();

        }
        #endregion



        // Method to check if a student has attended
        #region
        public bool CheckAttendance(string fingerId)
        {
            var student = _context.Students.FirstOrDefault(s => s.FingerId == fingerId);
            if (student == null)
            {
                return true;
            }
            return false;
        }
        #endregion


        // Method to calculate the attendance rate for a student
        #region
        public double Attendance_Rate(string fingerId, DateTime startDate, DateTime endDate)
        {

            var student = _context.Students.FirstOrDefault(s => s.FingerId == fingerId);
            if (student == null)
            {
                return 100.0;
            }

            // num of days should student attend
            int totalDays = (int)(endDate - startDate).TotalDays + 1;

            // num of days student attended already
            int presentDays = _context.AttendenceRecords.Count(r => r.StudentId == student.Id && r.AttendenceDate.Date >= startDate.Date &&
            r.AttendenceDate.Date <= endDate.Date);

            // calculate the attendance rate
            int absentDays = totalDays - presentDays;
            double absenceRate = (absentDays / (double)totalDays) * 100;

            return absenceRate;

        }

        #endregion



        // many to one relationship with student
        public int studentId { get; set; }  // foreign key

        public Student Student { get; set; }
    }
}
