using AutoMapper;
using Domain.Dto;
using Domain.Repository;
using Domain.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class TransporteService : ITransporteService
    {
        private readonly ICargueiroRepository _cargueiroRepository;
        private readonly ITransporteRepository _transporteRepository;
        private readonly IMapper _mapper;

        public TransporteService(ICargueiroRepository cargueiroRepository, IMapper mapper, ITransporteRepository transporteRepository)
        {
            _cargueiroRepository = cargueiroRepository;
            _mapper = mapper;
            _transporteRepository = transporteRepository;
        }

        public void adicionarNovoTransporte(FiltroTransporteDto filtroTransporteDto)
        {

            int semana = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(filtroTransporteDto.dataHoraRetorno, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);


            var cargueirosDisponiveis = _cargueiroRepository.BuscarCargueirosDisponiveis(filtroTransporteDto.classe);

            foreach (var cargueiro in cargueirosDisponiveis)
            {
                cargueiro.status = Enum.EnumStatusCargueiro.EmTransporte.ToString();
                _cargueiroRepository.Update(cargueiro);

                //var resultado = obterMinerioDisponivelTask().GetAwaiter().GetResult();

                var retornoMineriosDisponiveis = verificarMineriosDisponiveis(filtroTransporteDto.dataHoraRetorno.Month, filtroTransporteDto.dataHoraRetorno.Year, semana).GetAwaiter().GetResult();


            }

        }

        private async Task<RetornoMinerioDisponivelDto> verificarMineriosDisponiveis(int mes, int ano, int semana)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://fuct-smk186-code-challenge.cblx.com.br/minerais?mes={mes}&ano={ano}&semana={semana}");
            var response = await  client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            var retorno =  JsonConvert.DeserializeObject<RetornoMinerioDisponivelDto>(json);

            return retorno;
        }
    }
}
