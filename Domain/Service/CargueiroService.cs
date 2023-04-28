using AutoMapper;
using Domain.Dto;
using Domain.Entity;
using Domain.Repository;
using Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class CargueiroService : ICargueiroService
    {
        private readonly ICargueiroRepository _cargueiroRepository;
        private readonly IMapper _mapper;

        public CargueiroService(ICargueiroRepository cargueiroRepository, IMapper mapper)
        {
            _cargueiroRepository = cargueiroRepository;
            _mapper = mapper;
        }

        public IEnumerable<Cargueiro> ObterTodos()
        {
            var todosCargueiros = _cargueiroRepository.BuscarTodos();

            //var comboMinerio = _mapper.Map<IEnumerable<MinerioComboDto>>(todosMinerio);

            return todosCargueiros;
        }

        public Cargueiro ObterCargueiroPorId(int idCargueiro)
        {
            var retorno = _cargueiroRepository.BuscarCargueirosComMinerioAssociado(13);

            return retorno;
        }
    }
}
