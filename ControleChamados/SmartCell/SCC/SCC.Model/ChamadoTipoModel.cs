using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SCC.DAO;
using SCC.DTO;

namespace SCC.Model
{
    public class ChamadoTipoModel
    {
        public int PesquisarCodigoChamadoTipo(string DescChamadoTipo)
        {

            return new ChamadoTipoDAO().PesquisarCodigoChamadoTipo(DescChamadoTipo);
        }

        public int IncluirItemTipoChamado(ChamadoTipoDTO objChamadoTipoDTO)
        {

            return new ChamadoTipoDAO().IncluirItemTipoChamado(objChamadoTipoDTO);
        }



    }
}
