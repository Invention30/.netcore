using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager;

namespace DataManager
{
    public interface IEmpDataManager
    {
        public List<Employee> GetAllEmployee();
    }
}
