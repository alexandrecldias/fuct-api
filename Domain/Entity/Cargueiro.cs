using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Cargueiro : EntityBase
    {
        public int classe;
        public float capacidade;
        public string status;
        public Minerio minerio;

    }


}
