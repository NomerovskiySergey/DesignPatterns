namespace DesignPatterns.Source.StructuralPatterns.Proxy
{
    interface IEmployeeDataSource
    {
        EmployeeInfo GetEmployeeInfo(int id);
        void SetEmployeeInfo(EmployeeInfo employeeInfo);
    }
}
