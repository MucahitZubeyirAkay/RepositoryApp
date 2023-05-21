using BLL.Operation.Interface;
using DAL.Interface;
using DAL.Interface.Abstract;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Operation.Implementations
{
    public class StudentService : GenericService<Student>, IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository, IGenericRepository<Student> repository) : base(repository)
        {
            _studentRepository = studentRepository;
        }

    }
}