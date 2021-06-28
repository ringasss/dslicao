/*
 * Created by SharpDevelop.
 * User: Caio Malheiros
 * Date: 26/04/2021
 * Time: 13:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Projeto_Banco_Sharpdevelop
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txttelefone = new System.Windows.Forms.TextBox();
			this.txttemail = new System.Windows.Forms.TextBox();
			this.txtcnpj = new System.Windows.Forms.TextBox();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.btnexcluir = new System.Windows.Forms.Button();
			this.btnalterar = new System.Windows.Forms.Button();
			this.btncadastrar = new System.Windows.Forms.Button();
			this.DgvListaFornecedores = new System.Windows.Forms.DataGridView();
			this.txtcomplemento = new System.Windows.Forms.TextBox();
			this.txtendereco = new System.Windows.Forms.TextBox();
			this.txtcep = new System.Windows.Forms.TextBox();
			this.txtcelular = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtestado = new System.Windows.Forms.TextBox();
			this.txtcidade = new System.Windows.Forms.TextBox();
			this.txtbairro = new System.Windows.Forms.TextBox();
			this.txtnumero = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DgvListaFornecedores)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(34, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 25);
			this.label4.TabIndex = 10;
			this.label4.Text = "E-mail:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 25);
			this.label3.TabIndex = 9;
			this.label3.Text = "Telefone:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(39, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "CNPJ:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(27, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "Código:";
			// 
			// txttelefone
			// 
			this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttelefone.Location = new System.Drawing.Point(128, 174);
			this.txttelefone.Name = "txttelefone";
			this.txttelefone.Size = new System.Drawing.Size(331, 31);
			this.txttelefone.TabIndex = 14;
			// 
			// txttemail
			// 
			this.txttemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttemail.Location = new System.Drawing.Point(128, 122);
			this.txttemail.Name = "txttemail";
			this.txttemail.Size = new System.Drawing.Size(155, 31);
			this.txttemail.TabIndex = 13;
			// 
			// txtcnpj
			// 
			this.txtcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcnpj.Location = new System.Drawing.Point(128, 71);
			this.txtcnpj.Name = "txtcnpj";
			this.txtcnpj.Size = new System.Drawing.Size(331, 31);
			this.txtcnpj.TabIndex = 12;
			// 
			// txtcodigo
			// 
			this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcodigo.Location = new System.Drawing.Point(128, 20);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.Size = new System.Drawing.Size(123, 31);
			this.txtcodigo.TabIndex = 11;
			// 
			// btnexcluir
			// 
			this.btnexcluir.Location = new System.Drawing.Point(325, 596);
			this.btnexcluir.Name = "btnexcluir";
			this.btnexcluir.Size = new System.Drawing.Size(130, 42);
			this.btnexcluir.TabIndex = 17;
			this.btnexcluir.Text = "Excluir";
			this.btnexcluir.UseVisualStyleBackColor = true;
			this.btnexcluir.Click += new System.EventHandler(this.BtnexcluirClick);
			// 
			// btnalterar
			// 
			this.btnalterar.Location = new System.Drawing.Point(180, 596);
			this.btnalterar.Name = "btnalterar";
			this.btnalterar.Size = new System.Drawing.Size(139, 42);
			this.btnalterar.TabIndex = 16;
			this.btnalterar.Text = "Alterar";
			this.btnalterar.UseVisualStyleBackColor = true;
			this.btnalterar.Click += new System.EventHandler(this.BtnalterarClick);
			// 
			// btncadastrar
			// 
			this.btncadastrar.Location = new System.Drawing.Point(27, 597);
			this.btncadastrar.Name = "btncadastrar";
			this.btncadastrar.Size = new System.Drawing.Size(147, 41);
			this.btncadastrar.TabIndex = 15;
			this.btncadastrar.Text = "Cadastrar";
			this.btncadastrar.UseVisualStyleBackColor = true;
			this.btncadastrar.Click += new System.EventHandler(this.BtncadastrarClick);
			// 
			// DgvListaFornecedores
			// 
			this.DgvListaFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvListaFornecedores.Location = new System.Drawing.Point(29, 650);
			this.DgvListaFornecedores.Name = "DgvListaFornecedores";
			this.DgvListaFornecedores.Size = new System.Drawing.Size(592, 198);
			this.DgvListaFornecedores.TabIndex = 18;
			this.DgvListaFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaFornecedoresCellClick);
			// 
			// txtcomplemento
			// 
			this.txtcomplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcomplemento.Location = new System.Drawing.Point(178, 387);
			this.txtcomplemento.Name = "txtcomplemento";
			this.txtcomplemento.Size = new System.Drawing.Size(331, 31);
			this.txtcomplemento.TabIndex = 26;
			// 
			// txtendereco
			// 
			this.txtendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtendereco.Location = new System.Drawing.Point(128, 332);
			this.txtendereco.Name = "txtendereco";
			this.txtendereco.Size = new System.Drawing.Size(155, 31);
			this.txtendereco.TabIndex = 25;
			// 
			// txtcep
			// 
			this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcep.Location = new System.Drawing.Point(128, 281);
			this.txtcep.Name = "txtcep";
			this.txtcep.Size = new System.Drawing.Size(331, 31);
			this.txtcep.TabIndex = 24;
			// 
			// txtcelular
			// 
			this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcelular.Location = new System.Drawing.Point(128, 230);
			this.txtcelular.Name = "txtcelular";
			this.txtcelular.Size = new System.Drawing.Size(123, 31);
			this.txtcelular.TabIndex = 23;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 387);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 25);
			this.label5.TabIndex = 22;
			this.label5.Text = "Complemento:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(15, 335);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 25);
			this.label6.TabIndex = 21;
			this.label6.Text = "Endereço:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(39, 278);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(61, 25);
			this.label7.TabIndex = 20;
			this.label7.Text = "CEP:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(27, 230);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(86, 25);
			this.label8.TabIndex = 19;
			this.label8.Text = "Celular:";
			// 
			// txtestado
			// 
			this.txtestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtestado.Location = new System.Drawing.Point(128, 531);
			this.txtestado.Name = "txtestado";
			this.txtestado.Size = new System.Drawing.Size(331, 31);
			this.txtestado.TabIndex = 34;
			// 
			// txtcidade
			// 
			this.txtcidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcidade.Location = new System.Drawing.Point(128, 489);
			this.txtcidade.Name = "txtcidade";
			this.txtcidade.Size = new System.Drawing.Size(155, 31);
			this.txtcidade.TabIndex = 33;
			// 
			// txtbairro
			// 
			this.txtbairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbairro.Location = new System.Drawing.Point(128, 447);
			this.txtbairro.Name = "txtbairro";
			this.txtbairro.Size = new System.Drawing.Size(331, 31);
			this.txtbairro.TabIndex = 32;
			// 
			// txtnumero
			// 
			this.txtnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnumero.Location = new System.Drawing.Point(496, 335);
			this.txtnumero.Name = "txtnumero";
			this.txtnumero.Size = new System.Drawing.Size(123, 31);
			this.txtnumero.TabIndex = 31;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(32, 531);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(85, 25);
			this.label9.TabIndex = 30;
			this.label9.Text = "Estado:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(34, 489);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(86, 25);
			this.label10.TabIndex = 29;
			this.label10.Text = "Cidade:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(39, 447);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(75, 25);
			this.label11.TabIndex = 28;
			this.label11.Text = "Bairro:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(394, 338);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 25);
			this.label12.TabIndex = 27;
			this.label12.Text = "Número:";
			// 
			// txtnome
			// 
			this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnome.Location = new System.Drawing.Point(380, 20);
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(241, 31);
			this.txtnome.TabIndex = 36;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(300, 20);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(74, 25);
			this.label13.TabIndex = 35;
			this.label13.Text = "Nome:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 881);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtestado);
			this.Controls.Add(this.txtcidade);
			this.Controls.Add(this.txtbairro);
			this.Controls.Add(this.txtnumero);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtcomplemento);
			this.Controls.Add(this.txtendereco);
			this.Controls.Add(this.txtcep);
			this.Controls.Add(this.txtcelular);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DgvListaFornecedores);
			this.Controls.Add(this.btnexcluir);
			this.Controls.Add(this.btnalterar);
			this.Controls.Add(this.btncadastrar);
			this.Controls.Add(this.txttelefone);
			this.Controls.Add(this.txttemail);
			this.Controls.Add(this.txtcnpj);
			this.Controls.Add(this.txtcodigo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Projeto Banco Sharpdevelop";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.DgvListaFornecedores)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtnumero;
		private System.Windows.Forms.TextBox txtbairro;
		private System.Windows.Forms.TextBox txtcidade;
		private System.Windows.Forms.TextBox txtestado;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtcelular;
		private System.Windows.Forms.TextBox txtcep;
		private System.Windows.Forms.TextBox txtendereco;
		private System.Windows.Forms.TextBox txtcomplemento;
		private System.Windows.Forms.DataGridView DgvListaFornecedores;
		private System.Windows.Forms.Button btncadastrar;
		private System.Windows.Forms.Button btnalterar;
		private System.Windows.Forms.Button btnexcluir;
		private System.Windows.Forms.TextBox txtcodigo;
		private System.Windows.Forms.TextBox txtcnpj;
		private System.Windows.Forms.TextBox txttemail;
		private System.Windows.Forms.TextBox txttelefone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		

	}
}
