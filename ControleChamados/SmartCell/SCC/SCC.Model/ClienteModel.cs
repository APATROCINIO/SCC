using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC.DAO;
using SCC.DTO;

namespace SCC.Model
{
    public class ClienteModel
    {

        public int IncluirCliente(ClienteDTO objClienteDTO)
        {

            return new ClienteDAO().IncluirCliente(objClienteDTO);
        }

        public DataTable BuscarClientes()
        {

            return new ClienteDAO().BuscarClientes();
        }

        public DataTable BuscarClientesChamado()
        {

            return new ClienteDAO().BuscarClientesChamado();
        }

        public DataTable PesquisarClientes(string NomeCliente)
        {

            return new ClienteDAO().PesquisarClientes(NomeCliente);
        }

        public int AtualizarCliente(ClienteDTO objClienteDTO)
        {
            return new ClienteDAO().AtualizarCliente(objClienteDTO);
        }

    }
}
