using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ClientesBussiness
    {
        private readonly IClientesRepository _personaRepository;

        public ClientesBussiness(IClientesRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public List<Clientes> GetAllPersonas()
        {
            return _personaRepository.GetAllPersonas();
        }

        public Clientes GetPersonaById(int id)
        {
            return _personaRepository.GetPersonaById(id);
        }

        public void AddPersona(Clientes clientes)
        {
            _personaRepository.AddPersona(clientes);
        }

        public void UpdatePersona(Clientes clientes)
        {
            _personaRepository.UpdatePersona(clientes);
        }

        public void DeletePersona(int id) {
            _personaRepository.DeletePersona(id);
        }   


    }
}
