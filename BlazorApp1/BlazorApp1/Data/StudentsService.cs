namespace BlazorApp1.Data
{
    public class StudentsService
    {
        public List<Student> Students { get; }
        public StudentsService() { 

            Students = new List<Student>()
        {
        new Student() {
                ID = 1,
                Avatar ="https://cdn.pixabay.com/photo/2018/08/28/12/41/avatar-3637425_960_720.png",
                FirstName = "Jan",
                LastName="Kowalski",
                BirthDate = DateTime.Now,
                Studies = "Informatyka"
        },
        new Student()
        {
            ID = 2,
                Avatar ="https://cdn.pixabay.com/photo/2018/08/28/12/41/avatar-3637425_960_720.png",
                FirstName = "Halina",
                LastName="Jankowska",
                BirthDate = DateTime.Now,
                Studies = "SNM"
        },  
        new Student() {
                ID = 3,
                Avatar ="https://cdn.pixabay.com/photo/2018/08/28/12/41/avatar-3637425_960_720.png",
                FirstName = "Janina",
                LastName="Kowalska",
                BirthDate = DateTime.Now,
                Studies = "Informatyka"
        },
        new Student() {
                ID = 4,
                Avatar ="https://cdn.pixabay.com/photo/2018/08/28/12/41/avatar-3637425_960_720.png",
                FirstName = "Jakub",
                LastName="Nowak",
                BirthDate = DateTime.Now,
                Studies = "SNM"
        },
        };
        }
    }
}
