using Domain.Dto;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interface
{
    public interface IMinerioService
    {
        IEnumerable<MinerioComboDto> ObterTodos();
    }
}
