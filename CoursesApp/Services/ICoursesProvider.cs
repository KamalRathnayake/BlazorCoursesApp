namespace CoursesApp.Services
{
    public interface ICoursesProvider
    {
        Task<List<Data.Course>> GetAll();
        Task<Data.Course> GetCourseByReferenceId(string referenceId);
    }
}
