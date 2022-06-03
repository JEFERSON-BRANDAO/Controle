using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Media;
using MySql.Data.MySqlClient;
using Classes;
using System.Globalization;

// ===============================
// AUTHOR       : JEFFERSON BRANDÃO DA COSTA - ANALISTA/PROGRAMADOR
// CREATE DATE  : 03/12/2015
// DESCRIPTION  : Programa para RH fazer controle de entrega de cesta e frios
// SPECIAL NOTES: Alteração para exibir mensagem de funcionario com cadastro desatualizados, que nao foi registrada entrega da cesta pelo sistema ano anterior
// ===============================
// Change History: version 1.0.0.3 - Desing
// Date: 10/04/2019
//================================


namespace Controle
{
    public partial class FormEtrega : Form
    {

        public FormEtrega()
        {
            InitializeComponent();
            // 
            #region RODAPÉ

            int anoCriacao = 2015;
            int anoAtual = DateTime.Now.Year;
            string texto = anoCriacao == anoAtual ? " Foxconn CNSBG All Rights Reserved." : "-" + anoAtual + " Foxconn CNSBG All Rights Reserved.";
            //
            lbRodape.Text = "Copyright © " + anoCriacao + texto;

            #endregion

        }       
        //
        #region SOM AVISO

        private void SomErro()
        {
            try
            {
                string caminho = @"../../sound/fail.wav";
                SoundPlayer som = new SoundPlayer(caminho);
                som.Play();
            }
            catch (Exception)
            {
                //
            }
        }
        //
        private void SomOK()
        {
            try
            {
                string caminho = @"../../sound/pass.wav";
                SoundPlayer som = new SoundPlayer(caminho);
                som.Play();

                //aguarda tempo de 1 segundo para próxima mensagem de voz
                System.Threading.Thread.Sleep(1000);

                //mensagem de voz FELIZ NATAL
                caminho = @"../../sound/felizNatal.wav";
                SoundPlayer som2 = new SoundPlayer(caminho);
                som2.Play();

            }
            catch (Exception)
            {
                //
            }
        }

        #endregion
        //
        private void FormEtrega_Load(object sender, EventArgs e)
        {
            rdbCesta.Checked = true;
            //
            CultureInfo cult = new CultureInfo("pt-BR");
            DateTime Data = DateTime.Now;
            lbData.Text = Data.ToString("F", cult);

        }

        private void txtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //refresh data/hora
                CultureInfo cult = new CultureInfo("pt-BR");
                DateTime Data = DateTime.Now;
                lbData.Text = Data.ToString("F", cult);
                //
                lbAviso.Visible = false;
                //
                getFuncionario();
            }
        }
        //
        public void getFuncionario()
        {
            #region CONSULTA

            MySQLDbConnect Objconn = new MySQLDbConnect();
            //
            try
            {
                try
                {
                    FormataMatricula f = new FormataMatricula();
                    string matricula = f.formataStrMatricula(txtMatricula.Text.Trim());
                    //                  

                    Objconn.Conectar();
                    Objconn.Parametros.Clear();
                    //
                    string sql = "select identrega, matricula, nome, c_custo, ano from controle_entrega.entrega where matricula = '" + matricula + "' order by identrega desc";
                    //    
                    Objconn.SetarSQL(sql);
                    Objconn.Executar();
                    //
                    if (Objconn.Isvalid)
                    {
                        //
                        if (Objconn.Tabela.Rows.Count > 0)
                        {
                            dataGridViewFunc.Rows.Clear();
                            int colunas = 4;

                            // monta o array de valores...
                            object[] values = new object[colunas];

                            // varre as colunas para preencher os valores...
                            for (int i = 0; i < 1; i++)
                            {
                                values[0] = Objconn.Tabela.Rows[i]["matricula"].ToString();
                                values[1] = Objconn.Tabela.Rows[i]["nome"].ToString();
                                values[2] = Objconn.Tabela.Rows[i]["c_custo"].ToString();
                                values[3] = Objconn.Tabela.Rows[i]["ano"].ToString();
                            }

                            // adiciona no grid...
                            dataGridViewFunc.Rows.Add(values);

                            if (dataGridViewFunc.RowCount > 0)
                            {
                                //verica se usuario deixou de pegar cesta ano anterior, pois não poderá receber com cadastro de ano anterior
                                string ano = string.IsNullOrEmpty(values[3].ToString()) ? "0" : values[3].ToString();// indice 3,  ano

                                if (int.Parse(ano) >= DateTime.Now.Year)//verifica se o ano do cadastro eh atual
                                {
                                    fazerEntrega(matricula);
                                }
                                else
                                {
                                    SomErro();
                                    //
                                    lbAviso.Visible = true;
                                    string msg = ano.Equals("0") ? string.Empty : "ANO: " + ano;// tratamento para nao exibir msg  ano 0
                                    lbAviso.Text = "Funcionário com cadastro antigo. " + msg;

                                    //Limpa grid
                                    dataGridViewFunc.Rows.Clear();
                                    dataGridViewCesta.Rows.Clear();
                                    dataGridViewFrio.Rows.Clear();
                                }
                            }
                        }
                        else
                        {
                            txtMatricula.Clear();
                            //
                            SomErro();
                            //        //
                            lbAviso.Visible = true;
                            lbAviso.Text = "Nenhum registro encontrado. Funcionário não cadastrado.";
                            //Limpa grid
                            dataGridViewFunc.Rows.Clear();
                            dataGridViewCesta.Rows.Clear();
                            dataGridViewFrio.Rows.Clear();

                        }

                    }
                    else
                    {
                        txtMatricula.Clear();
                        //
                        SomErro();
                        //        
                        lbAviso.Visible = true;
                        //        
                        lbAviso.Text = Objconn.Message.Equals("Unable to connect to any of the specified MySQL hosts.") ? "ERRO:: Sem conexão de rede ou comunicação com banco de Dados" : Objconn.Message;
                        //Limpa grid
                        dataGridViewFunc.Rows.Clear();
                        dataGridViewCesta.Rows.Clear();
                        dataGridViewFrio.Rows.Clear();
                    }
                }
                catch (Exception erro)
                {
                    txtMatricula.Clear();
                    //
                    SomErro();
                    //        
                    lbAviso.Visible = true;
                    //        
                    lbAviso.Text = erro.Message;
                    //Limpa grid
                    dataGridViewFunc.Rows.Clear();
                    dataGridViewCesta.Rows.Clear();
                    dataGridViewFrio.Rows.Clear();
                }

            }
            finally
            {
                Objconn.Desconectar();
            }

            #endregion
        }
        //
        public void getCesta(string matricula)
        {
            #region CONSULTA

            MySQLDbConnect Objconn = new MySQLDbConnect();
            //
            try
            {
                try
                {
                    Objconn.Conectar();
                    Objconn.Parametros.Clear();
                    //
                    string sql = @"select  identrega as id_entrega,                                                    
                                       case cesta 
                                          when 0 then 'NÃO'
                                          when 1 then 'SIM'
                                        else 'NÃO'
                                        end status_cesta,                
                                        case DATE_FORMAT(STR_TO_DATE(dataHora_cesta, '%Y-%m-%d %H:%i:%s'), '%d/%m/%Y %H:%i:%s')
                                            when '00/00/0000 00:00:00' then ''
                                        else DATE_FORMAT(STR_TO_DATE(dataHora_cesta, '%Y-%m-%d %H:%i:%s'), '%d/%m/%Y %H:%i:%s')
		                                end as dataHora_cesta
                                        from controle_entrega.entrega 
                                        where matricula = '" + matricula + "' order by id_entrega desc";
                    //                    string sql = @"select  identrega as id_entrega,                                                    
                    //                                       case cesta 
                    //                                          when 0 then 'NÃO'
                    //                                          when 1 then 'SIM'
                    //                                        else 'NÃO'
                    //                                        end status_cesta,                
                    //                                        case concat(date_format(dataHora_cesta, GET_FORMAT(DATE,'EUR')), ' : ' ,time_format( dataHora_cesta, '%H:%i:%s') )
                    //                                            when '00.00.0000 : 00 00 00' then null
                    //                                            else  concat(date_format(dataHora_cesta, GET_FORMAT(DATE,'EUR')), ' : ' ,time_format( dataHora_cesta, '%H:%i:%s') )
                    //		                                end as dataHora_cesta
                    //                                        from controle_entrega.entrega 
                    //                                        where matricula = '" + matricula + "' order by id_entrega desc";

                    Objconn.SetarSQL(sql);
                    Objconn.Executar();
                    //
                    if (Objconn.Isvalid)
                    {

                        if (Objconn.Tabela.Rows.Count > 0)
                        {
                            dataGridViewCesta.Rows.Clear();
                            int colunas = 2;

                            // monta o array de valores...
                            object[] values = new object[colunas];

                            //// adiciona as colunas no grid...
                            //if (rowsCount == 0)
                            //    for (int i = 0; i < 1; i++)
                            //        dataGridViewCesta.Columns.Add("Entregue", "Data/Hora");

                            // varre as colunas para preencher os valores...
                            for (int i = 0; i < 1; i++)
                            {
                                values[0] = Objconn.Tabela.Rows[i]["status_cesta"].ToString();
                                values[1] = Objconn.Tabela.Rows[i]["dataHora_cesta"].ToString();
                            }

                            // adiciona no grid...
                            dataGridViewCesta.Rows.Add(values);

                            string status = values[0].ToString();
                            if (status.Equals("NÃO"))
                                dataGridViewCesta.Rows[0].DefaultCellStyle.SelectionBackColor = Color.Red;

                        }
                    }
                    else
                    {
                        txtMatricula.Clear();
                        //
                        SomErro();
                        //        
                        lbAviso.Visible = true;
                        //        
                        lbAviso.Text = Objconn.Message.Equals("Unable to connect to any of the specified MySQL hosts.") ? "ERRO:: Sem conexão de rede ou comunicação com banco de Dados" : Objconn.Message;
                        //Limpa grid
                        dataGridViewFunc.Rows.Clear();
                        dataGridViewCesta.Rows.Clear();
                        dataGridViewFrio.Rows.Clear();
                    }
                }
                catch (Exception erro)
                {
                    txtMatricula.Clear();
                    //
                    SomErro();
                    //        
                    lbAviso.Visible = true;
                    //        
                    lbAviso.Text = erro.Message;
                    //Limpa grid
                    dataGridViewFunc.Rows.Clear();
                    dataGridViewCesta.Rows.Clear();
                    dataGridViewFrio.Rows.Clear();
                }

            }
            finally
            {
                Objconn.Desconectar();
            }

            #endregion
        }
        //
        public void getFrio(string matricula)
        {
            #region CONSULTA

            MySQLDbConnect Objconn = new MySQLDbConnect();
            //
            try
            {
                try
                {

                    Objconn.Conectar();
                    Objconn.Parametros.Clear();
                    //
                    string sql = @"select 
                                 identrega as id,
                                  case frio 
                                         when 0 then 'NÃO'
                                         when 1 then 'SIM'
                                      else 'NÃO'
                                   end status_frio,
                                   case DATE_FORMAT(STR_TO_DATE(dataHora_frio, '%Y-%m-%d %H:%i:%s'), '%d/%m/%Y %H:%i:%s') 
                                        when '00/00/0000 00:00:00' then ''
                                   else DATE_FORMAT(STR_TO_DATE(dataHora_frio, '%Y-%m-%d %H:%i:%s'), '%d/%m/%Y %H:%i:%s') 
		                           end as dataHora_frio                       
                             from controle_entrega.entrega 
                             where  matricula = '" + matricula + "' order by identrega desc";

                    //                    string sql = @"select 
                    //                                 identrega as id,
                    //                                  case frio 
                    //                                         when 0 then 'NÃO'
                    //                                         when 1 then 'SIM'
                    //                                      else 'NÃO'
                    //                                   end status_frio,
                    //                                   case concat(date_format(dataHora_frio, GET_FORMAT(DATE,'EUR')), ' : ' ,time_format( dataHora_frio, '%H:%i:%s') )
                    //                                       when '00.00.0000 : 00 00 00' then null
                    //                                       else  concat(date_format(dataHora_frio, GET_FORMAT(DATE,'EUR')), ' : ' ,time_format( dataHora_frio, '%H:%i:%s') )
                    //		                           end as dataHora_frio                       
                    //                             from controle_entrega.entrega 
                    //                             where  matricula = '" + matricula + "' order by identrega desc";
                    //
                    Objconn.SetarSQL(sql);
                    Objconn.Executar();
                    //

                    if (Objconn.Isvalid)
                    {
                        if (Objconn.Tabela.Rows.Count > 0)
                        {
                            dataGridViewFrio.Rows.Clear();
                            int colunas = 2;

                            // monta o array de valores...
                            object[] values = new object[colunas];

                            //// adiciona as colunas no grid...
                            //if (rowsCount == 0)
                            //    for (int i = 0; i < 1; i++)
                            //        dataGridViewFrio.Columns.Add("Entregue", "Data/Hora");

                            // varre as colunas para preencher os valores...
                            for (int i = 0; i < 1; i++)
                            {
                                values[0] = Objconn.Tabela.Rows[i]["status_frio"].ToString();
                                values[1] = Objconn.Tabela.Rows[i]["dataHora_frio"].ToString();
                            }

                            // adiciona no grid...
                            dataGridViewFrio.Rows.Add(values);

                            string status = values[0].ToString();
                            if (status.Equals("NÃO"))
                                dataGridViewFrio.Rows[0].DefaultCellStyle.SelectionBackColor = Color.Red;
                            //dataGridViewFrio.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
                            //dataGridViewFrio.Rows[0].Cells[0].Style.BackColor = Color.Aqua;
                            //dataGridViewFrio.Rows[0].Cells[1].Style.BackColor = Color.Aqua;

                        }
                    }
                    else
                    {
                        txtMatricula.Clear();
                        //
                        lbAviso.Visible = true;
                        //              
                        lbAviso.Text = Objconn.Message.Equals("Unable to connect to any of the specified MySQL hosts.") ? "ERRO:: Sem conexão de rede ou comunicação com banco de Dados" : Objconn.Message;
                        //Limpa grid
                        dataGridViewFunc.Rows.Clear();
                        dataGridViewCesta.Rows.Clear();
                        dataGridViewFrio.Rows.Clear();
                    }
                }
                catch (Exception erro)
                {

                    txtMatricula.Clear();
                    //
                    SomErro();
                    //        
                    lbAviso.Visible = true;
                    //        
                    lbAviso.Text = erro.Message;
                    //Limpa grid
                    dataGridViewFunc.Rows.Clear();
                    dataGridViewCesta.Rows.Clear();
                    dataGridViewFrio.Rows.Clear();
                }

            }
            finally
            {
                Objconn.Desconectar();
            }

            #endregion
        }
        //
        public bool verificarEntrega(string item, string matricula)
        {
            #region CONSULTA

            MySQLDbConnect Objconn = new MySQLDbConnect();
            bool status = false;
            string sql = string.Empty;
            //
            try
            {
                try
                {
                    Objconn.Conectar();
                    Objconn.Parametros.Clear();
                    //
                    if (item.Equals("CESTA"))
                    {
                        sql = @"select 
                                      identrega, matricula,
                                      case cesta 
                                         when 0 then 'NÃO'
                                         when 1 then 'SIM'
                                         else 'NÃO'
                                       end status_cesta
                                       from controle_entrega.entrega
                                       where matricula = '" + matricula + "' order by identrega desc";
                    }
                    else//FRIO
                    {
                        sql = @"select 
                                       identrega,  matricula,
                                        case frio 
                                           when 0 then 'NÃO'
                                           when 1 then 'SIM'
                                           else 'NÃO'
                                        end status_frio
                                       from controle_entrega.entrega
                                       where  matricula = '" + matricula + "' order by identrega desc";
                    }
                    //
                    Objconn.SetarSQL(sql);
                    Objconn.Executar();
                    //
                    if (Objconn.Isvalid)
                    {

                        if (Objconn.Tabela.Rows.Count > 0)
                        {
                            //coluna2  status_cesta ou status_frio
                            status = Objconn.Tabela.Rows[0][2].ToString().Equals("NÃO") ? false : true;

                        }
                        else
                        {
                            status = false;
                        }
                    }
                    else
                    {
                        txtMatricula.Clear();
                        //
                        lbAviso.Visible = true;
                        //              
                        lbAviso.Text = Objconn.Message.Equals("Unable to connect to any of the specified MySQL hosts.") ? "ERRO:: Sem conexão de rede ou comunicação com banco de Dados" : Objconn.Message;
                        //Limpa grid
                        dataGridViewFunc.Rows.Clear();
                        dataGridViewCesta.Rows.Clear();
                        dataGridViewFrio.Rows.Clear();
                    }

                }
                catch (Exception erro)
                {
                    txtMatricula.Clear();
                    //
                    lbAviso.Visible = true;
                    //              
                    lbAviso.Text = erro.Message;
                    //Limpa grid
                    dataGridViewFunc.Rows.Clear();
                    dataGridViewCesta.Rows.Clear();
                    dataGridViewFrio.Rows.Clear();
                }

            }
            finally
            {
                Objconn.Desconectar();
            }

            //
            return status;

            #endregion
        }

        public void fazerEntrega(string matricula)
        {
            #region CESTA

            if (rdbCesta.Checked)
            {

                if (verificarEntrega("CESTA", matricula) == false)//não foi entregue
                {
                    #region SALVAR ENTREGA

                    MySQLDbConnect Objconn = new MySQLDbConnect();
                    FormataMatricula f = new FormataMatricula();
                    //
                    string data = DateTime.Now.Date.ToString("yyyy-MM-dd ");
                    string hora = String.Format("{0:HH:mm:ss}", DateTime.Now);
                    DateTime date = DateTime.ParseExact(data + hora, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                    int ano = DateTime.Now.Year;
                    int entregue = 1;
                    //
                    try
                    {
                        try
                        {
                            Objconn.Conectar();
                            Objconn.Parametros.Clear();
                            Objconn.AdicionarParametro("@cesta", entregue, MySqlDbType.Int32);
                            Objconn.AdicionarParametro("@dataHora", formattedDate, MySqlDbType.VarChar);
                            Objconn.AdicionarParametro("@ano", ano, MySqlDbType.Int32);
                            //
                            string sql = "update  controle_entrega.entrega set  cesta = @cesta, dataHora_cesta = @dataHora, ano = @ano   where  matricula ='" + matricula + "' and  cesta = 0 ";
                            Objconn.SetarSQL(sql);
                            Objconn.Executar();
                            //
                            if (Objconn.Isvalid)
                            {
                                SomOK();
                                //
                                getCesta(matricula);
                                getFrio(matricula);
                            }
                            else
                            {
                                SomErro();
                                //
                                getCesta(matricula);
                                //
                                lbAviso.Visible = true;
                                lbAviso.Text = "ERRO:: Existe uma data que houve entrega.";
                            }

                        }
                        catch (Exception erro)
                        {
                            lbAviso.Visible = true;
                            //              
                            lbAviso.Text = erro.Message.Equals("Unable to connect to any of the specified MySQL hosts.") ? "ERRO:: Sem conexão de rede ou comunicação com banco de Dados" : erro.Message;
                            //Limpa grid
                            dataGridViewFunc.Rows.Clear();
                            dataGridViewCesta.Rows.Clear();
                            dataGridViewFrio.Rows.Clear();
                        }

                    }
                    finally
                    {
                        Objconn.Desconectar();
                    }

                    #endregion

                }
                else
                {
                    SomErro();
                    //
                    lbAviso.Visible = true;
                    lbAviso.Text = "AVISO:: Funcionário já recebeu CESTA DE NATAL.";
                    //
                    getCesta(matricula);
                    getFrio(matricula);
                }

            }

            #endregion
            //
            #region FRIO

            if (rdbFrio.Checked)
            {

                if (verificarEntrega("FRIO", matricula) == false)//não foi entregue
                {
                    #region SALVAR ENTREGA

                    MySQLDbConnect Objconn = new MySQLDbConnect();
                    FormataMatricula f = new FormataMatricula();
                    //
                    string data = DateTime.Now.Date.ToString("yyyy-MM-dd ");
                    string hora = String.Format("{0:HH:mm:ss}", DateTime.Now);
                    DateTime date = DateTime.ParseExact(data + hora, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                    string formattedDate = date.ToString("yyyy-MM-dd HH:mm:ss");
                    int ano = DateTime.Now.Year;
                    int entregue = 1;
                    //
                    try
                    {
                        try
                        {
                            Objconn.Conectar();
                            Objconn.Parametros.Clear();
                            Objconn.AdicionarParametro("@frio", entregue, MySqlDbType.Int32);
                            Objconn.AdicionarParametro("@dataHora", formattedDate, MySqlDbType.VarChar);
                            Objconn.AdicionarParametro("@ano", ano, MySqlDbType.Int32); ;

                            //
                            string sql = "update  controle_entrega.entrega set  frio = @frio, dataHora_frio = @dataHora, ano = @ano   where  matricula ='" + matricula + "' and  frio = 0";
                            Objconn.SetarSQL(sql);
                            Objconn.Executar();

                            if (Objconn.Isvalid)
                            {
                                SomOK();
                                //
                                getCesta(matricula);
                                getFrio(matricula);
                            }
                            else
                            {
                                SomErro();
                                //
                                getCesta(matricula);
                                //
                                lbAviso.Visible = true;
                                lbAviso.Text = "ERRO:: Existe uma data que houve entrega.";
                            }

                        }
                        catch (Exception erro)
                        {

                            lbAviso.Visible = true;
                            //              
                            lbAviso.Text = erro.Message.Equals("Unable to connect to any of the specified MySQL hosts.") ? "ERRO:: Sem conexão de rede ou comunicação com banco de Dados" : erro.Message;
                            //Limpa grid
                            dataGridViewFunc.Rows.Clear();
                            dataGridViewCesta.Rows.Clear();
                            dataGridViewFrio.Rows.Clear();
                        }

                    }
                    finally
                    {
                        Objconn.Desconectar();
                    }

                    #endregion
                }
                else
                {
                    SomErro();
                    //
                    lbAviso.Visible = true;
                    lbAviso.Text = "AVISO:: Funcionário já recebeu CESTA DE FRIO.";
                    //
                    getFrio(matricula);
                    getCesta(matricula);
                }

            }

            #endregion
            //
            txtMatricula.Clear();
        }
    }
}
