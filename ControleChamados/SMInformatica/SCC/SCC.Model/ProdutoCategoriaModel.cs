using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC.DTO;
using SCC.DAO;

namespace SCC.Model
{
    public class ProdutoCategoriaModel
    {

        public DataTable BuscarProdutoCategorias(string codEmpresaUsuario)
        {

            return new ProdutoCategoriaDAO().BuscarProdutoCategorias(codEmpresaUsuario);
        }

        public DataTable PesquisarProdutoCategorias(int codProdutoCategoria)
        {

            return new ProdutoCategoriaDAO().PesquisarProdutoCategorias(codProdutoCategoria);
        }
    }
}
