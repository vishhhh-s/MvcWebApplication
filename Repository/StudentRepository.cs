using MvcWebApplication.Models;

namespace MvcWebApplication.Repository
{
    public static class StudentRepository
    {
        private static List<Student> students = new List<Student>
        {
                new Student {Name="Маша", Status=true, Age=18 },
                new Student {Name="Лера", Status=true, Age=19 },
                new Student {Name="Тоня", Status=false, Age=20 }
        };
        public static List<Student> GetAll()
        {
            return students;
        }

        public static void Add(Student student)
        {
            students.Add(student);
        }

        internal static void Delete(string name)
        {
            var item=students.FirstOrDefault(item=>item.Name==name);
            if (item != null)
                students.Remove(item);
        }
    }
}
