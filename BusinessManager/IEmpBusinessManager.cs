using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityManager;

namespace BusinessManager
{
    public interface IEmpBusinessManager
    {
        public List<Employee> GetAllEmp();
    }
}
