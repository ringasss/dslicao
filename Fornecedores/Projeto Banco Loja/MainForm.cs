using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_Banco_Sharpdevelop
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		
		string conexao = "server=localhost;user ID =root; password = root; database = bd_loja";

		
        public void listarFornecedor()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                string sql_select_fornecedores = "select * from tb_fornecedores";


                MySqlCommand executacmdMySql_select = new MySqlCommand(sql_select_fornecedores, con);

                con.Open();
                executacmdMySql_select.ExecuteNonQuery();


                DataTable tb_fornecedores = new DataTable();


                MySqlDataAdapter da_fornecedores = new MySqlDataAdapter(executacmdMySql_select);

                da_fornecedores.Fill(tb_fornecedores);

                DgvListaFornecedores.DataSource = tb_fornecedores;

                con.Close();

            }

            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro: " + erro);
            }

        }
		
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtncadastrarClick(object sender, EventArgs e)
		{
			
			try {
				
				
                MySqlConnection con = new MySqlConnection(conexao);

				  
                string nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado;
                nome = txtnome.Text;
                cnpj = txtcnpj.Text;  
                email = txttemail.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text; 	
                cep = txtcep.Text;	
                endereco = txtendereco.Text;	
                numero = txtnumero.Text;  	
                complemento = txtcomplemento.Text;  	
                bairro = txtbairro.Text;  	
                cidade = txtcidade.Text;  	
                estado = txtestado.Text;  	
                	
                

                string sql_insert = @"insert into tb_fornecedores (tb_fornecedores_nome, 
																	tb_fornecedores_cnpj, 
																	tb_fornecedores_email, 
																	tb_fornecedores_telefone, 
																	tb_fornecedores_celular, 
																	tb_fornecedores_cep, 
																	tb_fornecedores_endereço, 
																	tb_fornecedores_numero, 
																	tb_fornecedores_complemento,
																	tb_fornecedores_bairro,
																	tb_fornecedores_cidade, 
																	tb_fornecedores_estado)
																	
                                    values (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";


                MySqlCommand executacmdMySql_insert = new MySqlCommand(sql_insert, con);
                executacmdMySql_insert.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_insert.Parameters.AddWithValue("@cnpj", cnpj);
                executacmdMySql_insert.Parameters.AddWithValue("@email", email);
				executacmdMySql_insert.Parameters.AddWithValue("@telefone", telefone);
				executacmdMySql_insert.Parameters.AddWithValue("@celular", celular);
				executacmdMySql_insert.Parameters.AddWithValue("@numero", numero);	
				executacmdMySql_insert.Parameters.AddWithValue("@cep", cep);	
				executacmdMySql_insert.Parameters.AddWithValue("@endereco", endereco);	
				executacmdMySql_insert.Parameters.AddWithValue("@complemento", complemento);	
				executacmdMySql_insert.Parameters.AddWithValue("@bairro", bairro);	
				executacmdMySql_insert.Parameters.AddWithValue("@cidade", cidade);	
				executacmdMySql_insert.Parameters.AddWithValue("@estado", estado);	
				
                con.Open();

                executacmdMySql_insert.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Fornecedor Cadastrado com Sucesso!");
				
					
			} catch (Exception erro) {
				
				MessageBox.Show("Aconteceu o erro: " + erro);
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
            listarFornecedor();			
		}
		
		void BtnalterarClick(object sender, EventArgs e)
		{
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

               
				string nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado;
                int id;

                id = int.Parse(txtcodigo.Text);
                nome = txtnome.Text;
                cnpj = txtcnpj.Text;  
                email = txttemail.Text;
                telefone = txttelefone.Text;
                celular = txtcelular.Text; 	
                cep = txtcep.Text;	
                endereco = txtendereco.Text;	
                numero = txtnumero.Text;  	
                complemento = txtcomplemento.Text;  	
                bairro = txtbairro.Text;  	
                cidade = txtcidade.Text;  	
                estado = txtestado.Text;  

                string sql_uptade_fornecedores = @"update tb_fornecedores set tb_fornecedores_nome = @nome, 
																			  tb_fornecedores_cnpj = @cnpj, 
																			  tb_fornecedores_email = @email, 
 																			  tb_fornecedores_telefone = @telefone,
 																			  tb_fornecedores_celular = @celular,
 																		      tb_fornecedores_cep = @cep,
 																			  tb_fornecedores_endereço = @endereco,
 																			  tb_fornecedores_numero = @numero,
																			  tb_fornecedores_complemento = @complemento,
 																			  tb_fornecedores_bairro = @bairro,
 																			  tb_fornecedores_cidade = @cidade,
 																			  tb_fornecedores_estado = @estado

                                                                    where tb_fornecedores_id = @id";



                MySqlCommand executacmdMySql_uptade = new MySqlCommand(sql_uptade_fornecedores, con);

                executacmdMySql_uptade.Parameters.AddWithValue("@nome", nome);
                executacmdMySql_uptade.Parameters.AddWithValue("@cnpj", cnpj);
                executacmdMySql_uptade.Parameters.AddWithValue("@email", email);
				executacmdMySql_uptade.Parameters.AddWithValue("@telefone", telefone);
				executacmdMySql_uptade.Parameters.AddWithValue("@celular", celular);
				executacmdMySql_uptade.Parameters.AddWithValue("@numero", numero);	
				executacmdMySql_uptade.Parameters.AddWithValue("@cep", cep);	
				executacmdMySql_uptade.Parameters.AddWithValue("@endereco", endereco);		
				executacmdMySql_uptade.Parameters.AddWithValue("@complemento", complemento);	
				executacmdMySql_uptade.Parameters.AddWithValue("@bairro", bairro);	
				executacmdMySql_uptade.Parameters.AddWithValue("@cidade", cidade);	
				executacmdMySql_uptade.Parameters.AddWithValue("@estado", estado);	
                executacmdMySql_uptade.Parameters.AddWithValue("@id", id);


                con.Open();


                executacmdMySql_uptade.ExecuteNonQuery();


                con.Close();
                MessageBox.Show("Dados do Fornecedor Alterados  com Sucesso!");


                listarFornecedor();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Deu o erro: " + erro);
            }			
		}
		
		void BtnexcluirClick(object sender, EventArgs e)
		{
            try
            {
                MySqlConnection con = new MySqlConnection(conexao);

                int id = int.Parse(txtcodigo.Text);

                string sql_delete_fornecedores = @"delete from tb_fornecedores where tb_fornecedores_id = @id";

                MySqlCommand executacmdMySql_delete = new MySqlCommand(sql_delete_fornecedores, con);
                executacmdMySql_delete.Parameters.AddWithValue("@id", id);

                con.Open();

                executacmdMySql_delete.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Fornecedores Excluido com Sucesso!");

                listarFornecedor();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Deu o erro: " + erro);
            }			
		}
		
		void DgvListaFornecedoresCellClick(object sender, DataGridViewCellEventArgs e)
		{
            txtcodigo.Text    = DgvListaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text      = DgvListaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text  = DgvListaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txttemail.Text  = DgvListaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text     = DgvListaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text     = DgvListaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text     = DgvListaFornecedores.CurrentRow.Cells[6].Value.ToString();	
            txtendereco.Text     = DgvListaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text     = DgvListaFornecedores.CurrentRow.Cells[8].Value.ToString();	
            txtcomplemento.Text     = DgvListaFornecedores.CurrentRow.Cells[9].Value.ToString();	
            txtbairro.Text     = DgvListaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text     = DgvListaFornecedores.CurrentRow.Cells[11].Value.ToString();	
            txtestado.Text     = DgvListaFornecedores.CurrentRow.Cells[12].Value.ToString();	
            	
            	
            	
            	
            	
            
		}
	}
}
