using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Cargueiro : EntityBase
    {
        public int classe { get; set; }
        public float capacidade { get; set; }
        public string status { get; set; }
        public virtual Minerio Minerio { get; set; }
        public int IdMinerio { get; set; }
        public virtual Transporte Transporte { get; set; }

    }


}
