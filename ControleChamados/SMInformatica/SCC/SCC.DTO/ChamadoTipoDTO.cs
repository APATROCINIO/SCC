using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC.DTO
{
    public class ChamadoTipoDTO
    {
        //tipoitemchamadocelular
        //tipoitemchamadopadrao

        private int codigo;
        private string descTipoChamadoGrupoEmpresa;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string DescTipoChamadoGrupoEmpresa
        {
            get { return descTipoChamadoGrupoEmpresa; }
            set { descTipoChamadoGrupoEmpresa = value; }
        }

    }
}
