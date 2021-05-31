using AutoMapper;
using Itapeva.Servico.Itapeva.Entidades;
using PagouFacil_Itapeva.Controllers.Models;

namespace PagouFacil_Itapeva.Controllers.Mapper
{
    public class ItapevaMapper : Profile
    {
        public ItapevaMapper()
        {
            CreateMap<ConsultaDadosDevedorResponse, OutConsultarDadosDevedor>();

            CreateMap<SalvarAcordoResponse, OutSalvarAcordo>();

            CreateMap<SalvarAcordosRenegociadosResponse, OutSalvarAcordo>();

            CreateMap<SolicitarDadosProximaParcelaResponse, OutSolicitarBoletoProximaParcela>();

        }
    }
}
