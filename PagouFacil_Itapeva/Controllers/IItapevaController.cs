using PagouFacil_Itapeva.Controllers.Models;

namespace PagouFacil_Itapeva.Controllers
{
    public interface IItapevaController
    {
        OutConsultarDadosDevedor ConsultarDadosVendedor(InConsultarDadosDevedor input);
    }
}
