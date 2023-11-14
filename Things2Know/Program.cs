namespace Things2Know
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Test";
            Console.WriteLine(  student.Name);
            student.Name = "";
            Console.WriteLine(student.Name);
            object p = student;
            object p1 = student.Name;
            Train<Student> train = new Train<Student>();
            Train<string> train1 = new Train<string>();
            train.count = 4;
            train1.count = 5;  
            List<string> list = new List<string>();
            List<Student> students = new List<Student>();
            //List<Train<Student>> trains = new List<Train<Student>>();
        
            students.Add(student);
            students.Add(new Student() { Name = "Noa"});
            Console.WriteLine(students[0].Name);
            students.Remove(student);
            students.RemoveAt(0);


            for (int i = 0; i < students.Count; i++)
            {

            }
           


        }
    }
}