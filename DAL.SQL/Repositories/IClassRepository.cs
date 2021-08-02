using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.DTOs;
using Transport.Interfaces;

namespace DAL.SQL.Repositories
{
    public interface IClassRepository : IBaseRepository
    {
        IEnumerable<ClassDTO> GetAll();
        IEnumerable<ClassDTO> Get(IEnumerable<int> ids);
        IEnumerable<ClassDTO> Get(IEnumerable<Identifiable> identifiables);
        ClassStudentsDTO Get(int id);
        ClassStudentsDTO Get(Identifiable identifiable);
    }
}
