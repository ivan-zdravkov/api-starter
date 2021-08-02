using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SQL.Models
{
    public abstract class BaseModel : IBaseModel
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public override bool Equals(object other)
        {
            if (other is null)
                return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
                return false;

            BaseModel otherModel = other as BaseModel;

            return this.Id == otherModel.Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
