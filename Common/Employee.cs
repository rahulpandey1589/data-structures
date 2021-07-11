namespace DataStructures.Common
{
    public class Employee
    {
        public Employee(string firstName,
            string lastName,
            string gender)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
    }
}
