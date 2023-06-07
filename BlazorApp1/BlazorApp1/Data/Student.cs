namespace BlazorApp1.Data
{
    public class Student
    {
        public int ID { get; set; }

        public string FirstName { get; set; } = null!; 
        public string LastName { get; set; } = null!;
        public string Avatar { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Studies { get; set; }
    }
}
