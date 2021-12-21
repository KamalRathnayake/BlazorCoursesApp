using CoursesApp.Data;
using System.Net.Http.Json;

namespace CoursesApp.Services
{
    public class CoursesProvider : ICoursesProvider
    {
        private HttpClient httpClient;

        public CoursesProvider(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<List<Course>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Data.Course>>("/Courses/");
        }
        public async Task<Course> GetCourseByReferenceId(string referenceId)
        {
            var result = await httpClient.GetAsync($"/Courses/{referenceId}");
            return await result.Content.ReadFromJsonAsync<Course>();
        }
    }
}
