using DAL.SQL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.DTOs;
using Transport.Interfaces;

namespace DAL.SQL.Repositories
{
    public class ClassRepository : BaseRepository<ClassEntity>, IClassRepository
    {
        public ClassRepository(Context context) : base(context) { }

        public IEnumerable<ClassDTO> GetAll() => this.dbSet.Select(c => BuildClassDTO(c)).ToList();
        public IEnumerable<ClassDTO> Get(IEnumerable<int> ids) => this.dbSet.Where(c => ids.Contains(c.Id)).Select(c => BuildClassDTO(c)).ToList();
        public IEnumerable<ClassDTO> Get(IEnumerable<Identifiable> identifiables) => this.Get(identifiables.Select(i => i.Id));
        public ClassStudentsDTO Get(int id) => this.dbSet.Where(c => c.Id == id).Select(c => BuildClassStudentsDTO(c)).FirstOrDefault();
        public ClassStudentsDTO Get(Identifiable identifiable) => this.Get(identifiable.Id);

        private static ClassStudentsDTO BuildClassStudentsDTO(ClassEntity c) =>
            new ClassStudentsDTO()
            {
                Id = c.Id,
                Name = c.Name,
                MaxSize = c.MaxSize,
                Students = c.Students.Select(s => new StudentDTO()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Age = s.Age
                })
            };

        private static ClassDTO BuildClassDTO(ClassEntity c) =>
            new ClassDTO()
            {
                Id = c.Id,
                Name = c.Name,
                MaxSize = c.MaxSize
            };
    }
}
