namespace StoreAppLib.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Privilege { get; set; }

        public Employees(int employeeId, string employeeName, string privilege)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.Privilege = privilege;

        }
    }
}