using ElasticLogStandard.Componentes;
using ElasticLogStandard.Model;
using Itapeva.Servico.Itapeva.Entidades;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;

namespace Itapeva.Servico.Itapeva.ItapevaClientWrapper
{
    public class ItapevaClientWrapper : IItapevaClientWrapper
    {
        private ItapevaAPI _api;
        private readonly string IP;

        ElasticLog log = new ElasticLog(313, TipoLogEnum.API, "api_313_itapeva", RegistroTipoEnum.ALL, "Itapeva313.API");

        public ItapevaClientWrapper(IConfiguration _configuration)
        {
            _api = new ItapevaAPI(_configuration);
        }

        public ConsultaDadosDevedorResponse consultaDadosDevedor(string IdentityNumber)
        {
            try
            {
                var result = _api.ConsultarDadosDevedor(IdentityNumber);
                GravaLog("ConsultarDadosDevedor()", IdentityNumber, result);
                return JsonConvert.DeserializeObject<ConsultaDadosDevedorResponse>(result);
            }
            catch(Exception ex)
            {
                GravaLog("ConsultarDadosDevedor()", IdentityNumber, null, ex);
            }
            return null;
        }

        public SalvarAcordoResponse salvarAcordo(SalvarAcordoInput input)
        {
            try
            {
                var result = _api.SalvarAcordo(input);
                GravaLog("SalvarAcordo()", JsonConvert.SerializeObject(input), result);
                return JsonConvert.DeserializeObject<SalvarAcordoResponse>(result);
            }
            catch (Exception ex)
            {
                GravaLog("SalvarAcordo()", JsonConvert.SerializeObject(input), null, ex);
            }
            return null;
        }

        public SolicitarDadosProximaParcelaResponse SolicitarDadosProximaParcela(SolicitarDadosProximaParcelaInput input)
        {
            try
            {
                var result = _api.SolicitarDadosProximaParcela(input);
                GravaLog("SolicitarDadosProximaParcela()", JsonConvert.SerializeObject(input), result); 
                return JsonConvert.DeserializeObject<SolicitarDadosProximaParcelaResponse>(result);
            }
            catch (Exception ex)
            {
                GravaLog("SolicitarDadosProximaParcela()", JsonConvert.SerializeObject(input), null, ex);
            }
            return null;
        }

        public ConsultaDadosDevedorResponse RenegociacaoAcordo(int ArrangementID)
        {
            try
            {
                var result = _api.RenegociacaoAcordo(ArrangementID);
                GravaLog("RenegociacaoAcordo()", ArrangementID.ToString(), result);
                return JsonConvert.DeserializeObject<ConsultaDadosDevedorResponse>(result);
            }
            catch (Exception ex)
            {
                GravaLog("RenegociacaoAcordo()", ArrangementID.ToString(), null, ex);
            }
            return null;
        }

        public SalvarAcordosRenegociadosResponse SalvarAcordosRenegociados(RenegociarAcordoInput input)
        {
            try
            {
                var result = _api.SalvarAcordosRenegociados(input);
                GravaLog("SalvarAcordosRenegociados()", JsonConvert.SerializeObject(input), result);
                return JsonConvert.DeserializeObject<SalvarAcordosRenegociadosResponse>(result);
            }
            catch (Exception ex)
            {
                GravaLog("SalvarAcordosRenegociados()", JsonConvert.SerializeObject(input), null, ex);
            }
            return null;
        }


        private void GravaLog(string nomeFuncao, string entrada, string saida, Exception ex = null)
        {
            if(saida != null)
                log.LogAPI(RegistroTipoEnum.INFO, IP, nomeFuncao, "Sucesso na requisição.", "", DateTime.Now, entrada, DateTime.Now, saida, false);
            else
                log.LogAPI(RegistroTipoEnum.ERRO, IP, nomeFuncao, "Falha na requisição." + ex.Message, ex.StackTrace, DateTime.Now, entrada, DateTime.Now, null, false);
        }
    }
}
