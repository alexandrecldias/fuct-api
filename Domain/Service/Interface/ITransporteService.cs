﻿using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service.Interface
{
    public interface ITransporteService
    {
        void adicionarNovoTransporte(FiltroTransporteDto filtroTransporteDto);
    }
}
