using Itapeva.Servico.Itapeva.Entidades;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Text;

namespace Itapeva.Servico.Itapeva
{
    public class ItapevaAPI : ServicesExecuteAPI
    {
        public ItapevaAPI(IConfiguration _configuration)
        {
            BaseUrl = _configuration["Itapeva:BaseUrl"];
            User = _configuration["Itapeva:Username"];
            Password = _configuration["Itapeva:Password"];
        }
        public string ConsultarDadosDevedor(string IdentityNumber)
        {
            var client = new RestClient(GetBaseUrl() + $"/api/v1/Antlia/Inbound/GetCustomerData.json?IdentityNumber={IdentityNumber}");
            RestRequest request = GetRequest(Method.GET);
            return ClientExecute(client, request).Content;
        }

        public string SalvarAcordo(SalvarAcordoInput salvarAcordo)
        {
            var client = new RestClient(GetBaseUrl() + "/api/Adhil/v1/SubmitAdhilNegotiationInbound.json");
            RestRequest request = GetRequest(Method.POST, salvarAcordo);
            return ClientExecute(client, request).Content;
        }

        public string SolicitarDadosProximaParcela(SolicitarDadosProximaParcelaInput solicitarDados)
        {
            var client = new RestClient(GetBaseUrl() + $"/v1/Antlia/Inbound/GetCustomerNextInstallments.json?identitynumber={solicitarDados.IdentityNumber}&GenerateBilletPDFContent={solicitarDados.GenerateBillePdfContent}");
            RestRequest request = GetRequest(Method.GET);
            return ClientExecute(client, request).Content;
        }

        public string RenegociacaoAcordo(int ArrangementID)
        {
            var client = new RestClient(GetBaseUrl() + $"/api/v1/Antlia/Inbound/Renegotiation/GetRenegotiationData.json&ArrangementID={ArrangementID}");
            RestRequest request = GetRequest(Method.GET);
            return ClientExecute(client, request).Content;
        }

        public string SalvarAcordosRenegociados(RenegociarAcordoInput renegociarAcordoInput)
        {
            var client = new RestClient(GetBaseUrl() + $"/api/v1/Antlia/Inbound/Renegotiation/SaveAntliaInboundRenegotiationArrangement.json");
            RestRequest request = GetRequest(Method.POST, renegociarAcordoInput);
            return ClientExecute(client, request).Content;
        }

        private RestRequest GetRequest(Method method, object obj = null, string permissao = null)
        {
            var request = new RestRequest(method);
            request.AddHeader("Content-Type", "application/json");
            var autorizacao = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes($"{User}:{Password}"));
            request.AddHeader("Authorization", "Basic " + autorizacao);

            if (obj != null)
                request.Parameters.Add(new Parameter("application/json", JsonConvert.SerializeObject(obj), ParameterType.RequestBody));
            else
                request.Parameters.Add(new Parameter("application/json", "", ParameterType.RequestBody));

            return request;
        }

        private IRestResponse ClientExecute(RestClient restClient, RestRequest restRequest)
        {
            var response = restClient.Execute(restRequest);
            if ((response.StatusCode == HttpStatusCode.OK) && (response.Content.Equals("")))
                return response;

            if (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created)
                throw new Exception(response.Content);

            return response;
        }

        private string GetBaseUrl()
        {
            return this.BaseUrl;
        }
    }
}
