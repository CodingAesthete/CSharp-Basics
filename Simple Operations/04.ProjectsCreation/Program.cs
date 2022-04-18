using System;

namespace _04.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int totalHoursForProjects = projectsCount * 3;
            string result = $"The architect {architectName} will need {totalHoursForProjects} hours to complete {projectsCount} project/s.";
            Console.WriteLine(result);
        }
    }
}
