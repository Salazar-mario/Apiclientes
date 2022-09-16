using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apiclientes.modelos;

namespace Apiclientes.Repositorio
{
    public class RepoClientes
    {
         public static List<Clientes> _listaClientes = new List<Clientes>()
        {
            new Clientes() { Id = 1, Nombre = "Cliente 1" , Apellido = "Apellido 1" , Direccion = "Direccion 1"},
            new Clientes() { Id = 2, Nombre = "Cliente 2" , Apellido = "Apellido 2" , Direccion = "Direccion 2"},
            new Clientes() { Id = 3, Nombre = "Cliente 3" , Apellido = "Apellido 3" , Direccion = "Direccion 3"}
        };

        public IEnumerable<Clientes> ObtenerClientes()
        {
            return _listaClientes;
        }

        public Clientes ObtenerCliente(int id)
        {
            var cliente = _listaClientes.Where(cli => cli.Id == id);

            return Clientes.FirstOrDefault();
        }

        public void Agregar(Clientes nuevoCliente)
        {
            _listaClientes.Add(nuevoCliente);
        }
    }
}

        
