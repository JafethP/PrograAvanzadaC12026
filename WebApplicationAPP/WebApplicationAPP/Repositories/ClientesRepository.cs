using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class ClientesRepository : IClientesRepository
    {
        ///Declarar nuestras funciones por ejemplo
        /////CRUD
        ///
        private readonly AppDbContext _context;
        public ClientesRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Clientes> GetAllPersonas() { 
            return _context.Cliente_JafethPoveda.ToList();
        }
        public Clientes GetPersonaById(int id) { 
            return _context.Cliente_JafethPoveda.Find(id);
        }

        public void AddPersona(Clientes persona) { 
            _context.Cliente_JafethPoveda.Add(persona);
            _context.SaveChanges();
        }

        public void UpdatePersona(Clientes persona)
        {
            _context.Cliente_JafethPoveda.Update(persona);
            _context.SaveChanges();       
        }

        public void DeletePersona(int id) { 
            var persona = GetPersonaById(id);
            if (persona != null)
            {
                _context.Cliente_JafethPoveda.Remove(persona);
                _context.SaveChanges();
            }
        }

    }
}
