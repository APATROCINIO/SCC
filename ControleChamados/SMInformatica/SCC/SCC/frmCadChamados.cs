using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SCC.DTO;
using SCC.Model;

namespace SCC
{
    public partial class frmCadChamados : Form
    {
        public frmCadChamados()
        {
            InitializeComponent();
        }


        ChamadoDTO objChamadoDTO = new ChamadoDTO();
        ChamadoItemDTO objChamadoItemDTO = new ChamadoItemDTO();
        public int varCodigoTipoChamado { get; set; }
        private string modo = "";
        private string modoChamado = "";
        private int codClinteSelecionado = 0;
        public static bool bolAtualizar = false;


        #region "EVENTOS DA TELA"

        private void frmCadChamados_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            HabilitarBotoes("");
            dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoCadastro();
            this.rtxObsAtendente.KeyPress += new KeyPressEventHandler(this.rtxObsAtendente_KeyPress);
            this.rtxMarcaModeloSerie.KeyPress += new KeyPressEventHandler(this.rtxMarcaModeloSerie_KeyPress);
            
        }

        private void rtxObsAtendente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void rtxMarcaModeloSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            modo = "Novo";
            InicializarModo();
            CarregarGrids();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (ValidarDadosForm()==true)
            {
                modo = "Salvar";
                InicializarModo();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modo = "Cancelar";
            InicializarModo();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            modo = "Pesquisar";
            InicializarModo();

        }

        private void rdbTipoChamadoCartucho_Click(object sender, EventArgs e)
        {
            CarregarTipoChamado("CARTUCHO");
        }

        private void rdbTipoChamadoManutencao_Click(object sender, EventArgs e)
        {
            CarregarTipoChamado("PADRAO");
        }

        private void rdbtipoChamadoCelular_Click(object sender, EventArgs e)
        {
            CarregarTipoChamado("CELULAR");
        }

        private void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarBotoes("Novo");
            HabilitarCampos();

        }

        private void dataGridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se for selecionado um item fora da coleção o grid recarrega
            if (Convert.ToString(dataGridProdutos.Rows[e.RowIndex].Cells[2].Value) == "")
            {
                CarregarGrids(modoChamado);
            }

            //Condição abaixo foi criada, para forçar o sistema abaixo definir objChamadoDTO valor cda coluna CheckBox para true OrderedEnumerableRowCollection false
            //isso foi necessário porque toda vez qu o segundo registro é selecionado, a celula ainda está em edição e o valor da celula é nula
            if ((bool)Convert.ToBoolean(dataGridProdutos.Rows[e.RowIndex].Cells[0].Value) == true)
            {
                dataGridProdutos.Rows[e.RowIndex].Cells[0].Value = false;
            }
            else
            {
                dataGridProdutos.Rows[e.RowIndex].Cells[0].Value = true;
            }

        }

        private void dataGridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            //Se for selecionado um item fora da coleção o grid recarrega
            if (Convert.ToString(dataGridClientes.Rows[e.RowIndex].Cells[2].Value) == "")
            {
                CarregarGrids();
            }



            //verificar se existe um cliente selecionado
            int qtdCliente = dataGridClientes.RowCount;
            int i;

            for (i = 0; i < qtdCliente; i++)
            {
                if (e.RowIndex != i)
                {
                    if (dataGridClientes.Rows[i].Cells[0].Value != null)
                    {
                        //MessageBox.Show("Este Cliente foi selecionado " + dataGridClientes.Rows[i].Cells[2].Value);
                        dataGridClientes.Rows[i].Cells[0].Value = null;
                    }

                }
                else
                {
                    codClinteSelecionado = Convert.ToInt32(dataGridClientes.Rows[i].Cells[1].Value);
                }

            }
        }

        #endregion


        #region "MÉTODOS DA TELA"

        private void InicializarModo()
        {
            switch (modo)
            {
                case "Novo":

                    LimparCampos();
                    HabilitarCampos();
                    HabilitarBotoes(modo);
                    maskDataCadastro.Text = Convert.ToString(DateTime.Now);

                    break;

                case "Salvar":

                    
                    HabilitarBotoes("Salvar");
                    bolAtualizar = false;
                    
                    try
                    {

                        ////////inicio salvar
                        ChamadoItemDTO objChamadoItemDTO = new ChamadoItemDTO();

                        if (lblCodigo.Text != "...")
                        {
                            if (Convert.ToInt32(lblCodigo.Text) > 0)
                            {
                                bolAtualizar = true;
                                objChamadoDTO.Codigo = Convert.ToInt32(lblCodigo.Text);
                            }
                        }

                        if (ValidarProdutoSelecionado() == true)
                        {

                            int qtdProduto = dataGridProdutos.RowCount;
                            int i;

                            DataGridViewRow row = new DataGridViewRow();
                            int x = 0;
                            
                            try
                            {

                                for (i = 0; i < dataGridProdutos.RowCount; i++)
                                {
                                    row = dataGridProdutos.Rows[i];

                                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                                    {
                                        try
                                        {
                                            if (x == 0)
                                            {
                                                //Incluir Primeiro o Chamado
                                                //Cave deum chamado SE O TIPO DE CHAMADO FOR PADRAO = 1 SENÃO = 2 (CELULAR)
                                                objChamadoDTO.TipoChamado_idTipoChamado = new ChamadoTipoModel().PesquisarCodigoChamadoTipo(modoChamado);
                                                objChamadoDTO.Usuarios_idUsuario = MainClass.IdUsuario;
                                                objChamadoDTO.Clientes_idCliente = codClinteSelecionado;
                                                objChamadoDTO.ObsAtendenteChamado = rtxObsAtendente.Text;
                                                objChamadoDTO.DataAtendimento = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
                                                objChamadoDTO.ChamadoFinalizado = "N";
                                                //objChamadoDTO.ChamadosItem_idItemChamado = idChamadoItem;
                                                //objChamadoDTO.ChamadosItem_Produtos_idProduto = idChamadoProduto;
                                                //objChamadoDTO.ObsAtendenteChamado = rtxObsAtendente.Text;

                                                x = new ChamadoModel().IncluirChamado(objChamadoDTO);

                                            }

                                            //Identifica o produto
                                            int idChamadoProduto = Convert.ToInt32(row.Cells[1].Value);

                                            //Incluir Item Chamado e recupera id do item inserido
                                           IncluirItemChamado(idChamadoProduto);


                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Ocorreu um erro ao Salvar o(s) Iten(s) deste Chamado. Favor entrar em contato com o suporte técnico." + ex.Message);
                                        }

                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ocorreu um erro ao Salvar o Chamado atual. Favor entrar em contato com o suporte técnico" + ex.Message);
                            }

                            if (x == 1)
                            {
                                //MessageBox.Show("Chamado incluido com sucesso!");
                                this.toolStripStatusLabel1.Visible = true;
                                this.toolStripStatusLabel1.Text = "Chamado incluído com sucesso!";
                                
                            }

                            HabilitarBotoes(modo);
                            LimparCampos();
                            DesabilitarCampos();
                            CarregarGrids("CHAMADOS");

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao salvar o Chamado. Favor entrar em contato com o suporte técnico " + ex.Message);
                    }

                    break;

                case "Pesquisar":

                    DesabilitarCampos();
                    HabilitarBotoes("");

                    break;

                case "Cancelar":

                    LimparCampos();
                    DesabilitarCampos();
                    HabilitarBotoes(modo);
                    LimpaPainelChamadoCelular();

                    break;

                default:

                    break;

            }

        }

        private void IncluirItemChamado(int valIdChamadoProduto)
        {
            //bool bValor = false;
            int xx = 0;

            //Recupera o id do Chamado
            objChamadoItemDTO.Chamados_idChamado = new ChamadoModel().PesquisarChamado(MainClass.IdUsuario, codClinteSelecionado, objChamadoDTO.TipoChamado_idTipoChamado, objChamadoDTO.DataAtendimento);

            //Incluir Segundo o Item do Chamado
            objChamadoItemDTO.Produtos_idProduto = valIdChamadoProduto;
            objChamadoItemDTO.ObsItemChamado = ""; //esta informação será preenchida posteriormente ao cadastro do Chamado
            objChamadoItemDTO.ValorItem = 0;
            objChamadoItemDTO.ServicoAutorizado = "N";
            objChamadoItemDTO.DataInclusao = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss"));
            objChamadoItemDTO.IdUsuarioCadastro = MainClass.IdUsuario; 

            if (rdbtipoChamadoCelular.Checked == true)
            {
                if (rdbCarregadorSim.Checked == true)
                {
                    objChamadoItemDTO.CelularPossuiCarregador = "S";
                }
                if (rdbCarregadorNao.Checked == true)
                {
                    objChamadoItemDTO.CelularPossuiCarregador = "N";
                }

                if (rdbCartaoMemoriaSim.Checked == true)
                {
                    objChamadoItemDTO.CelularPossuiCartaoMemoria = "S";
                }

                if (rdbCartaoMemoriaNao.Checked == true)
                {
                    objChamadoItemDTO.CelularPossuiCartaoMemoria = "N";
                }

                if (rdbChipSim.Checked == true)
                {
                    objChamadoItemDTO.CelularPossuiChip = "S";
                }
                if (rdbChipNao.Checked == true)
                {
                    objChamadoItemDTO.CelularPossuiChip = "N";
                }
            }

            if (rdbTipoChamadoManutencao.Checked == true)
            {
                if (rdbCarregadorNoteSim.Checked == true)
                {
                    objChamadoItemDTO.PadraoPossuiCarregador = "S";
                }
                if (rdbCarregadorNoteNao.Checked == true)
                {
                    objChamadoItemDTO.PadraoPossuiCarregador = "N";
                }
                objChamadoItemDTO.PadraoMarcaModeloSerie = rtxMarcaModeloSerie.Text;

            }

            try
            {
                xx = new ChamadoItemModel().IncluirChamadoItem(objChamadoItemDTO);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Incluir o(s) Itens do Chamado. Favor entrar em contato com o suporte técnico." + ex.Message);
            }

        }

        private void InicializarModoChamado()
        {
            switch (modoChamado)
            {
                case "CELULAR":
                    try
                    {
                        DesabilitarGrid(modoChamado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar Tipo d Chamado ==  " + modoChamado + "" + ex.Message);
                    }


                    break;

                case "PADRAO":
                    try
                    {
                        DesabilitarGrid(modoChamado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar Tipo d Chamado ==  " + modoChamado + "" + ex.Message);
                    }

                    break;

                case "CARTUCHO":
                    try
                    {
                        DesabilitarGrid(modoChamado);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar Tipo d Chamado ==  " + modoChamado + "" + ex.Message);
                    }

                    break;

                default:

                    break;

            }

        }

        private void HabilitarCampos()
        {
            pnlCabecalho.Enabled = true;
            gbrTipoChamado.Enabled = true;
            pnlObsAtendente.Enabled = true;

            if (rdbtipoChamadoCelular.Checked == true)
            {
                pnlChamadoCelular.Enabled = true;

            }

            if (rdbtipoChamadoCelular.Checked == true)
            {
                pnlChamadoProduto.Enabled = true;

            }

        }

        private void HabilitarBotoes(string ValorBotao)
        {
            switch (ValorBotao)
            {
                case "Novo":
                    btnNovo.Enabled = false;
                    btnSalvar.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnExcluir.Enabled = false;
                    this.toolStripStatusLabel1.Visible = false;

                    break;

                case "Salvar":
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = true;

                    break;

                case "Cancelar":
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = false;

                    break;

                default:
                    btnNovo.Enabled = true;
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnExcluir.Enabled = true;
                    this.toolStripStatusLabel1.Visible = true;
                    this.toolStripStatusLabel1.Text = "";

                    break;

            }

        }

        private void DesabilitarCampos()
        {
            pnlChamadoProduto.Enabled = false;
            gbrTipoChamado.Enabled =  false;
            pnlChamadoCelular.Enabled = false;
            pnlCabecalho.Enabled = false;
            pnlChamadoPadrao.Enabled = false;
            pnlObsAtendente.Enabled = false;


        }

        private void DesabilitarGrid()
        {
            pnlChamadoProduto.BackColor = Color.Transparent;
            pnlChamadoCelular.BackColor = Color.Transparent;
            pnlChamadoPadrao.BackColor = Color.Transparent;


            if (this.dataGridProdutos.DataSource != null)
            {
                this.dataGridProdutos.DataSource = null;
            }
            else
            {
                this.dataGridProdutos.Rows.Clear();

            }

            if (this.dataGridClientes.DataSource != null)
            {
                this.dataGridClientes.DataSource = null;
            }
            else
            {
                this.dataGridClientes.Rows.Clear();

            }
        }

        private void DesabilitarGrid(string tipoChamado)
        {

            if (tipoChamado == "PADRAO")
            {
                CarregarGrids(tipoChamado);
            }

            if (tipoChamado == "CARTUCHO")
            {
                CarregarGrids(tipoChamado);
            }

        }
        
        private void LimparCampos()
        {
            DesabilitarGrid();
            rdbTipoChamadoManutencao.Checked = false;
            rdbtipoChamadoCelular.Checked = false;
            rtxObsAtendente.Text = "";
            rtxMarcaModeloSerie.Text = "";
            //toolStripStatusLabel1.Visible = false;
            //toolStripStatusLabel1.Text = "";


        }
        
        private void CarregarGrids()
        {
            dataGridClientes .AutoGenerateColumns = false;
            dataGridClientes.DataSource = new ClienteModel().BuscarClientes();
            dataGridClientes.Columns[1].Width = 50;
            dataGridClientes.Columns[2].Width = 240;

        }

        private void CarregarGrids(string opcTipoChamado)
        {

            if ((opcTipoChamado == "CARTUCHO" || opcTipoChamado == "PADRAO") == true)
            {
                dataGridProdutos.AutoGenerateColumns = false;
                dataGridProdutos.DataSource = new ProdutoModel().PesquisarProdutos(opcTipoChamado);
                dataGridProdutos.Columns[1].Width = 50;
                dataGridProdutos.Columns[2].Width = 240;

                LimpaPainelChamadoCelular();
                LimpaPainelChamadoPadrao();

            }

            if (opcTipoChamado == "CELULAR")
            {
                dataGridProdutos.AutoGenerateColumns = false;
                dataGridProdutos.DataSource = new ProdutoModel().PesquisarProdutos(opcTipoChamado);
                dataGridProdutos.Columns[1].Width = 50;
                dataGridProdutos.Columns[2].Width = 240;

                LimpaPainelChamadoCelular();
                LimpaPainelChamadoPadrao();
            }

            if (opcTipoChamado == "CHAMADOS")
            {
                dataGridChamados.AutoGenerateColumns = false;
                dataGridChamados.DataSource = new ChamadoModel().BuscarChamadoCadastro();
                dataGridChamados.Columns[0].Width = 100;
                //dataGridChamados.Columns[1].Name
                dataGridChamados.Columns[1].Width = 100;
                dataGridChamados.Columns[2].Width = 160;
                dataGridChamados.Columns[3].Width = 160;
                dataGridChamados.Columns[4].Width = 120;
                //dataGridChamados.Columns[5].Width = 120;
                
            }
 
        }

        private void LimpaPainelChamadoPadrao()
        {
            rdbCarregadorNoteNao.Checked = false;
            rdbCarregadorNoteSim.Checked = false;
            rtxMarcaModeloSerie.Text = "";

        }
        
        private void LimpaPainelChamadoCelular()
        {
            rdbCarregadorNao.Checked = false;
            rdbCarregadorSim.Checked = false;
            rdbCartaoMemoriaNao.Checked = false;
            rdbCartaoMemoriaSim.Checked = false;
            rdbChipNao.Checked = false;
            rdbChipSim.Checked = false;

        }

        private void CarregarTipoChamado(string opcChamado)
        {
            if ((opcChamado == "CARTUCHO" || opcChamado == "PADRAO") == true)
            {
                pnlChamadoProduto.Enabled = true;
                pnlChamadoProduto.BackColor = Color.SpringGreen;
                modoChamado = "CARTUCHO";
                
                if (opcChamado == "PADRAO")
                {
                    pnlChamadoProduto.BackColor = Color.SkyBlue;
                    modoChamado = "PADRAO";
                    pnlChamadoPadrao.Enabled = true;
                    rtxMarcaModeloSerie.Enabled = true;
                    pnlChamadoPadrao.BackColor = Color.SkyBlue;
                }

                pnlChamadoCelular.Enabled = false;
                pnlChamadoCelular.BackColor = Color.Transparent;
                InicializarModoChamado();

            }

            if (opcChamado == "CELULAR")
            {
                pnlChamadoPadrao.Enabled = false;
                pnlChamadoPadrao.BackColor = Color.Transparent;
                
                pnlChamadoCelular.Enabled = true;
                pnlChamadoCelular.BackColor = Color.SkyBlue;
                pnlChamadoProduto.Enabled = true;
                pnlChamadoProduto.BackColor = Color.SkyBlue;
                modoChamado = "CELULAR";
                InicializarModoChamado();
                CarregarGrids(opcChamado);

            }

        }

        private bool ValidarProdutoSelecionado()
        {
            bool boolValor = false;

            int qtdProduto = dataGridProdutos.RowCount;
            int i;

            for (i = 0; i < qtdProduto; i++)
            {
                if (dataGridProdutos.Rows[i].Cells[0].Value != null)
                {
                    boolValor = true;
                }
            }
            
            return boolValor;
        }

        private bool ValidarClienteSelecionado()
        {
            bool boolValor = false;

            int qtdCliente = dataGridClientes.RowCount;
            int i;

            for (i = 0; i < qtdCliente; i++)
            {
                if (dataGridClientes.Rows[i].Cells[0].Value != null)
                {
                    boolValor = true;
                }
            }

            return boolValor;
        }

        private bool ValidarDadosForm()
        {
            bool boolValor = true;


            if (ValidarClienteSelecionado() == false)
            {
                MessageBox.Show("Selecione um Cliente!");
                dataGridClientes.Focus();
                boolValor = false;
            }

            if (ValidarProdutoSelecionado() == false)
            {
                MessageBox.Show("Selecione um Produto!");
                dataGridProdutos.Focus();
                boolValor = false; 
            }


            if (rdbTipoChamadoManutencao.Checked == true)
            {
                if (rdbCarregadorNoteSim.Checked == false && rdbCarregadorNoteNao.Checked == false)
                {   
                    MessageBox.Show("Informe se o Item deste chamado possui ou não um Carregador!");
                    boolValor = false;
                }
                    
            }
                
            if (rdbtipoChamadoCelular.Checked == true)
                {
                    if (rdbCarregadorNao.Checked == false && rdbCarregadorSim.Checked == false)
                    { 
                        MessageBox.Show("Informe se o Celular deste chamado possui ou não um Carregador!");
                        boolValor = false;
                    }


                    if (rdbCartaoMemoriaNao.Checked == false && rdbCartaoMemoriaSim.Checked == false)
                    {   
                        MessageBox.Show("Informe se o Celular deste chamado possui ou não um Cartão de Memória!");
                        boolValor = false;
                    }

                    if (rdbChipNao.Checked == false && rdbChipSim.Checked == false)
                    {
                        MessageBox.Show("Informe se o Celular deste chamado possui ou não um Chip!");
                        boolValor = false;
                    }
                     

                }



            return boolValor;

        }

        #endregion
   

    }
}
