using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.DTOs;
using Transport.Interfaces;

namespace DAL.SQL.Repositories
{
    public interface IBaseRepository
    {
        bool Exists(Identifiable id);
        bool Exists(int id);

        void Delete(Identifiable identifiable);
        void Delete(int id);
        void Delete(IEnumerable<Identifiable> identifiables);
        void Delete(IEnumerable<int> ids);
    }
}
