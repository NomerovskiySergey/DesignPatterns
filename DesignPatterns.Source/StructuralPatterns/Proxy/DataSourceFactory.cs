namespace DesignPatterns.Source.StructuralPatterns.Proxy
{
    static class DataSourceFactory
    {
        public static IEmployeeDataSource CreateEmployeeDataSource()
        {
            return EmployeeDataSourceProxy.Instance;
        }
    }
}
