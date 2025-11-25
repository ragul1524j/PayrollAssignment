
namespace PayrollProject
{
    public class MockEmployeeDataReader : IEmployeeDataReader
    {
        public EmployeeRecord GetEmployeeRecord(int employeeId)
        {
            // Return hardcoded data consistent with IDs 101, 102, 103
            if (employeeId == 101)
            {
                return new EmployeeRecord
                {
                    Id = 101,
                    Name = "Logesh",
                    Role = "Developer",
                    IsVetern = false
                };
            }

            if (employeeId == 102)
            {
                return new EmployeeRecord
                {
                    Id = 102,
                    Name = "Prathees",
                    Role = "Manager",
                    IsVetern = true
                };
            }

            if (employeeId == 103)
            {
                return new EmployeeRecord
                {
                    Id = 103,
                    Name = "Waseef",
                    Role = "Intern",
                    IsVetern = false
                };
            }

            // Default/unknown
            return new EmployeeRecord
            {
                Id = employeeId,
                Name = "Unknown",
                Role = "Unknown",
                IsVetern = false
            };
        }
    }
}
