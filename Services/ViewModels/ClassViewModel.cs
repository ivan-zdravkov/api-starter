using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.DTOs;

namespace Services.ViewModels
{
    public class ClassViewModel
    {
        //ToDo: Introduce AutoMapper
        public ClassViewModel(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public ClassViewModel(ClassDTO dto) : this(dto.Id, dto.Name) { }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
