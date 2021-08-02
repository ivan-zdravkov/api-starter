using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Interfaces;

namespace Transport.DTOs
{
    public class BaseDTO : Identifiable
    {
        public int Id { get; set; }

        public override bool Equals(object other)
        {
            if (other is null)
                return false;

            if (Object.ReferenceEquals(this, other))
                return true;

            if (this.GetType() != other.GetType())
                return false;

            BaseDTO otherDTO = other as BaseDTO;

            return this.Id == otherDTO.Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
