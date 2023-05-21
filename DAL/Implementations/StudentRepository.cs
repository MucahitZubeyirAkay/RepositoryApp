using DAL.Context;
using DAL.Interface;
using Microsoft.EntityFrameworkCore;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        
    }
}
    
