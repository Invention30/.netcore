using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager;
using DataManager;

namespace BusinessManager
{
    public class EmpBusinessManager: IEmpBusinessManager
    {
        public List<Employee> GetAllEmp()
        {
            IEmpDataManager empDataManager = new EmpDataManager();
            List<Employee> employees = empDataManager.GetAllEmployee();
            return employees;
        }
    }
}
