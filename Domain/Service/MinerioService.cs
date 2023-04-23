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
    public class MinerioService : IMinerioService
    {
        private readonly IMinerioRepository _minerioRepository;
        public readonly IMapper _mapper;

        public MinerioService(IMinerioRepository minerioRepository, IMapper mapper)
        {
            _minerioRepository = minerioRepository;
            _mapper = mapper;
        }

        public IEnumerable<MinerioComboDto> ObterTodos()
        {
            var todosMinerio = _minerioRepository.BuscarTodos();

            var comboMinerio = _mapper.Map<IEnumerable<MinerioComboDto>>(todosMinerio);

            return comboMinerio;
        }
    }
}
