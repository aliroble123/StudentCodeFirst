namespace StudentCodeFirst
{
    public class Student
    {
        // Entity Framework recognizes StudentId as the primary key by convention.
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
