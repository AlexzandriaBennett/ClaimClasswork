namespace RealOfficialLab3.Models
{
    public class Student
    {
        // Using flat database technique instead of entity relationship FK PK system
        public int Id { get; set; }
       
        public string Name { get; set; } = null!;


    }
}
