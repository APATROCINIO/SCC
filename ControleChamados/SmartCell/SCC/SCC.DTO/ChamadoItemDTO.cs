using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCC.DTO
{
    public class ChamadoItemDTO
    {
        private int codigo;
        private int produtos_idProduto;
        private int chamados_idChamado;
        private string celularPossuiCarregador;
        private string celularPossuiCartaoMemoria;
        private string celularPossuiChip;
        private string padraoPossuiCarregador;
        private string padraoMarcaModeloSerie;
        private string servicoAutorizado;
        private decimal valorItem;
        private string obsItemChamado;
        private string obsItemTecnico;
        private DateTime dataInclusao;
        private int idUsuarioCadastro;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Produtos_idProduto
        {
            get { return produtos_idProduto; }
            set { produtos_idProduto = value; }
        }

        public int Chamados_idChamado
        {
            get { return chamados_idChamado; }
            set { chamados_idChamado = value; }
        }

        public string CelularPossuiCarregador
        {
            get { return celularPossuiCarregador; }
            set { celularPossuiCarregador = value; }
        }

        public string CelularPossuiCartaoMemoria
        {
            get { return celularPossuiCartaoMemoria; }
            set { celularPossuiCartaoMemoria = value; }
        }

        public string CelularPossuiChip
        {
            get { return celularPossuiChip; }
            set { celularPossuiChip = value; }
        }

        public string PadraoPossuiCarregador
        {
            get { return padraoPossuiCarregador; }
            set { padraoPossuiCarregador = value; }
        }

        public string PadraoMarcaModeloSerie
        {
            get { return padraoMarcaModeloSerie; }
            set { padraoMarcaModeloSerie = value; }
        }

        public decimal ValorItem
        {
            get { return valorItem; }
            set { valorItem = value; }
        }

        public string ServicoAutorizado
        {
            get { return servicoAutorizado; }
            set { servicoAutorizado = value; }
        }

        public string ObsItemChamado
        {
            get { return obsItemChamado; }
            set { obsItemChamado = value; }
        }

        public string ObsItemTecnico
        {
            get { return obsItemTecnico; }
            set { obsItemTecnico = value; }
        }

        public DateTime DataInclusao
        {
            get { return dataInclusao; }
            set { dataInclusao = value; }
        }

        public int IdUsuarioCadastro
        {
            get { return idUsuarioCadastro; }
            set { idUsuarioCadastro = value; }
        }

    }
}
