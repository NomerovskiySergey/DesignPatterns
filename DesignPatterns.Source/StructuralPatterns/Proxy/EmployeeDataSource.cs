using System;
using System.Collections.Concurrent;
using System.Threading;

namespace DesignPatterns.Source.StructuralPatterns.Proxy
{
    class EmployeeDataSource : IEmployeeDataSource
    {
        private static ConcurrentDictionary<int, EmployeeInfo> _database
        = new ConcurrentDictionary<int, EmployeeInfo>();

        public EmployeeInfo GetEmployeeInfo(int id)
        {
            /*  Demo */
            Console.WriteLine("Loading {0} from DB... ", id);
            Thread.Sleep(1000);

            return _database.GetOrAdd(id, this.CreateNewEmployee);
        }

        public void SetEmployeeInfo(EmployeeInfo employeeInfo)
        {
            /* Demo */
            Console.WriteLine("Saving ({0}, {1}) to DB... ",
                employeeInfo.Id, employeeInfo.FullName);

            _database.AddOrUpdate(employeeInfo.Id,
                employeeInfo, (key, value) => employeeInfo);
        }

        private EmployeeInfo CreateNewEmployee(int id)
        {
            return new EmployeeInfo()
            {
                Id = id,
                FullName = "[NoName]"
            };
        }
    }
}
