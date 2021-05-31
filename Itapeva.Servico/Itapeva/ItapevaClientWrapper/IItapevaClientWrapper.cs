using Itapeva.Servico.Itapeva.Entidades;

namespace Itapeva.Servico.Itapeva.ItapevaClientWrapper
{
    public interface IItapevaClientWrapper
    {
        ConsultaDadosDevedorResponse consultaDadosDevedor(string IdentityNumber);
        SalvarAcordoResponse salvarAcordo(SalvarAcordoInput salvarAcordo);
        SolicitarDadosProximaParcelaResponse SolicitarDadosProximaParcela(SolicitarDadosProximaParcelaInput input);
        ConsultaDadosDevedorResponse RenegociacaoAcordo(int ArrangementID);
        SalvarAcordosRenegociadosResponse SalvarAcordosRenegociados(RenegociarAcordoInput renegociarAcordoInput);
    }
}
