using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interface
{
    public interface ICargueiroService
    {
        IEnumerable<Cargueiro> ObterTodos();
        Cargueiro ObterCargueiroPorId(int idCargueiro);
    }
}
