using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Interfaces;

namespace DAL.SQL.Models
{
    public interface IBaseModel : Identifiable
    {
        int CreatedBy { get; set; }
        int? ModifiedBy { get; set; }
        DateTime CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
