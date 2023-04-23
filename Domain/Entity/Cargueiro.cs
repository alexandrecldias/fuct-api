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
        public char tipoMineral;
        public string status;
    
        public Cargueiro(int classe, float capacidade, char tipoMineral, string status)
        {
            this.classe = classe;
            this.capacidade = capacidade;
            this.tipoMineral = tipoMineral;
            this.status = status;   
        }
    }


}
