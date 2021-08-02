using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.DTOs;

namespace Services.ViewModels
{
    public class ClassStudentsViewModel : ClassViewModel
    {
        //ToDo: Introduce AutoMapper
        public ClassStudentsViewModel(ClassStudentsDTO dto) : base(dto.Id, dto.Name)
        {
            this.Students = dto.Students.Select(s => new StudentViewModel(s));
        }

        public IEnumerable<StudentViewModel> Students { get; set; }
    }
}
