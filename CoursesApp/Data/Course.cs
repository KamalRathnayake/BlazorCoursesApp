namespace CoursesApp.Data
{
    public class Course
    {
        public string ReferenceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Article> Articles { get; set; }
    }
}
