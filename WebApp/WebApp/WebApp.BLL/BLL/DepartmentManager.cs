using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Model.Model;
using WebApp.Repository.Repository;

namespace WebApp.BLL.BLL
{
    public class DepartmentManager
    {
        DepartmentRepository _DepartmentRepository = new DepartmentRepository();
        public bool Add(Department department)
        {
            return _DepartmentRepository.Add(department);
        }

        public bool Delete(int id)
        {
            return _DepartmentRepository.Delete(id);
        }
        public bool Update(Department department)
        {
            return _DepartmentRepository.Update(department);
        }
        public List<Department> GetAll()
        {
            return _DepartmentRepository.GetAll();
        }
        public Department GetById(int id)
        {
            return _DepartmentRepository.GetById(id);
        }
    }
}
