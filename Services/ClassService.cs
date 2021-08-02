using DAL.SQL.Repositories;
using Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClassService : IClassService
    {
        IClassRepository classRepository;

        public ClassService(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public ClassStudentsViewModel Get(int id) => new ClassStudentsViewModel(this.classRepository.Get(id));

        public IEnumerable<ClassViewModel> GetAll() => this.classRepository.GetAll().Select(c => new ClassViewModel(c));
    }
}
