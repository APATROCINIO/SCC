using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC.DTO;
using SCC.DAO;

namespace SCC.Model
{
    public class GrupoEmpresasModel
    {

        public DataTable BuscarGrupoEmpresas(int codProdutoCategoria)
        {

            return new GrupoEmpresasDAO().BuscarGrupoEmpresas(codProdutoCategoria);
        }
    
    }
}
