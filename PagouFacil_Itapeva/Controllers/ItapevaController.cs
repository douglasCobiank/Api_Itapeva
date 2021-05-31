using AutoMapper;
using ElasticLogStandard.Componentes;
using Itapeva.Servico.Itapeva.Entidades;
using Itapeva.Servico.Itapeva.ItapevaClientWrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PagouFacil_Itapeva.Controllers.Models;
using PagouFacil_Itapeva.Controllers.Mapper;
using System;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;

namespace PagouFacil_Itapeva.Controllers
{
    [Route("v1/Itapeva")]
    public class ItapevaController : ControllerBase, IItapevaController
    {
        private readonly IMapper _mapper;
        private readonly IItapevaClientWrapper _itapevaClientWrapper;
        private IHttpContextAccessor _accessor;

        public ItapevaController(IItapevaClientWrapper itapevaClientWrapper, IConfiguration configuration, IHttpContextAccessor accessor)
        {
            var conf = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ItapevaMapper>();
            });

            _mapper = conf.CreateMapper();
            _itapevaClientWrapper = itapevaClientWrapper;
            _accessor = accessor;
            var ip = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
        }

        [HttpGet("consultar-dados-devedor")]
        public OutConsultarDadosDevedor ConsultarDadosVendedor(InConsultarDadosDevedor input)
        {
            var response = _itapevaClientWrapper.consultaDadosDevedor(input.IdentityNumber);
            return _mapper.Map<OutConsultarDadosDevedor>(response);
        }

        [HttpPost("salvar-acordo")]
        public OutSalvarAcordo SalvarAcordo(InSalvarAcordo input)
        {
            var response = _itapevaClientWrapper.salvarAcordo(_mapper.Map<SalvarAcordoInput>(input));
            return _mapper.Map<OutSalvarAcordo>(response);
        }

        [HttpGet("solicitar-boleto-proxima-parcela")]
        public OutSolicitarBoletoProximaParcela SolicitarBoletoProximaParcela(InSolicitarBoletoProximaParcela input)
        {
            var response = _itapevaClientWrapper.SolicitarDadosProximaParcela(_mapper.Map<SolicitarDadosProximaParcelaInput>(input));
            return _mapper.Map<OutSolicitarBoletoProximaParcela>(response);
        }

        [HttpGet("renegociar-acordo")]
        public OutConsultarDadosDevedor RenegociacaoAcordo(InRenegociacaoAcordo input)
        {
            var response = _itapevaClientWrapper.RenegociacaoAcordo(input.ArrangementID);
            return _mapper.Map<OutConsultarDadosDevedor>(response);
        }

        [HttpPost("salvar-acordo-renegociado")]
        public OutSalvarAcordo SalvarAcordosRenegociados(InSalvarAcordosRenegociados input)
        {
            var response = _itapevaClientWrapper.SalvarAcordosRenegociados(_mapper.Map<RenegociarAcordoInput>(input));
             return _mapper.Map<OutSalvarAcordo>(response);
        }

    }
}
