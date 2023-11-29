namespace StudentCatalog.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Teacher { get; set; }

        public Subject(int id, string name, string teacher)
        {
            Id = id;
            Name = name;
            Teacher = teacher;
        }
    }
}