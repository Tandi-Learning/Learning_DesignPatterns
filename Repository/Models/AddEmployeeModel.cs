namespace Repository.Models
{
    public class AddEmployeeModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Level { get; set; }
        public int DepartmentId { get; set; }
    }
}