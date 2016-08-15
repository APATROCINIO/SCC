using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC.DTO;
using SCC.DAO;

namespace SCC.Model
{
    public class FornecedorModel
    {
        public int IncluirFornecedor(FornecedorDTO objFornecedorDTO)
        {

            return new FornecedorDAO().IncluirFornecedor(objFornecedorDTO);
        }

        public DataTable BuscarFornecedores()
        {

            return new FornecedorDAO().BuscarFornecedores();
        }

        public DataTable PesquisarFornecedores(string NomeFornecedor)
        {

            return new FornecedorDAO().PesquisarFornecedores(NomeFornecedor);
        }

        public int AtualizarFornecedor(FornecedorDTO objFornecedorDTO)
        {
            return new FornecedorDAO().AtualizarFornecedor(objFornecedorDTO);
        }
 
    }
}
