using System;
using System.Collections.Concurrent;

namespace DesignPatterns.Source.StructuralPatterns.Proxy
{
    class EmployeeDataSourceProxy: IEmployeeDataSource
    {
        #region Singleton implementation

        private static readonly Lazy<EmployeeDataSourceProxy> _instance =
            new Lazy<EmployeeDataSourceProxy>(() => new EmployeeDataSourceProxy());

        public static EmployeeDataSourceProxy Instance
        {
            get { return _instance.Value; }
        }
        #endregion

        private readonly IEmployeeDataSource _dataSource = new EmployeeDataSource();

        private static ConcurrentDictionary<int, EmployeeInfo> _cache
            = new ConcurrentDictionary<int, EmployeeInfo>();

        public EmployeeInfo GetEmployeeInfo(int id)
        {
            return _cache.GetOrAdd(id, _dataSource.GetEmployeeInfo);
        }

        public void SetEmployeeInfo(EmployeeInfo employieInfo)
        {
            _dataSource.SetEmployeeInfo(employieInfo);

            EmployeeDataSourceProxy._cache.AddOrUpdate(employieInfo.Id,
                employieInfo, (key, value) => employieInfo);
        }
    }
}
