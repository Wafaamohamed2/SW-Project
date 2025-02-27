namespace SW_Project.Models
{
    public class AttendenceRecord
    {
        public int Id { get; set; }
        public int AttendenceId { get; set; }

        public int StudentId { get; set; }

        public DateTime AttendenceDate { get; set; }

        public string FingerId { get; set; }   

        public Student Student { get; set; }

    }
}
