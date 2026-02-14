using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IClientesRepository
    {
        List<Clientes> GetAllPersonas();
        Clientes GetPersonaById(int id);
        void AddPersona(Clientes clientes);
        void UpdatePersona(Clientes clientes);
        void DeletePersona(int id);

    }
}
