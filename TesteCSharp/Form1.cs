using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // VALIDAÇÂO E CADASTRO LISTA DE EMPRESAS
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa();
            

            if (txtNomeFantasia.Text !=string.Empty)
            {
                empresa.NomeFantasia = txtNomeFantasia.Text;
            }
            else
            {
                MessageBox.Show("Campo Obrigatório");
                return;
            }

            if (mskCNPJ.Text != string.Empty)
            {
                empresa.CNPJ = mskCNPJ.Text;
            }
            else
            {
                MessageBox.Show("Campo Obrigatório");
                return;
            }

            if (cbxEstado.Text != string.Empty)
            {
                empresa.Estado = cbxEstado.Text;
            }
            else
            {
                MessageBox.Show("Campo Obrigatório");
                return;
            }

            if (cbxEstado.Text == "PR")
            {
                tabControl1.Enabled = false;

                MessageBox.Show("Empresa do PR , Não é permitido cadastrar Fornecedor!");
            }

            List<Empresa> listaEmpresa = new List<Empresa>();
            listaEmpresa.Add(empresa);

            dtgLista.DataSource = listaEmpresa;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFantasia.Clear();
            mskCNPJ.Clear();
            
        }
        
        
        // VALIDAÇÂO E CADASTRO LISTA DE FORNECEDORES

        private void Button1_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            DateTimePicker dateTime = new DateTimePicker();
                     
           
           //VALIDAÇÂO PJ


            if (rdbPJ.Checked)
            {
                if (txtEmpresa.Text != string.Empty)
                {
                    fornecedor.Empresa = txtEmpresa.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }

                if (mskCnpjFornecedor.Text !=string.Empty)
                {
                    fornecedor.CnpjFornecedor = mskCnpjFornecedor.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }

                if (mskTelefone.Text != string.Empty)
                {
                    fornecedor.Telefone = mskTelefone.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }

               
            }
             //****************************************************            
                       
            // VALIDAÇÃO PESSOA FISICA

            if (rdbPF.Checked)
            {
                if (txtRG.Text !=string.Empty)
                {
                    fornecedor.RG = txtRG.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }

                if (mskDataNascimento.Text !=string.Empty)

                {
                    fornecedor.DataNascimento = mskDataNascimento.Text;
                }

                if (mskTelefone.Text != string.Empty)
                {
                    fornecedor.Telefone = mskTelefone.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }

                if (mskCPF.Text != string.Empty)
                {
                    fornecedor.CPF = mskCPF.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }

                if (txtNome.Text != string.Empty)
                {
                    fornecedor.Nome = txtNome.Text;
                }
                else
                {
                    MessageBox.Show("Campo Obrigatório");
                    return;
                }


            }

            //****************************************************

            List<Fornecedor> listaFornecedor = new List<Fornecedor>();
            listaFornecedor.Add(fornecedor);

                        
            dtgFornecedor.DataSource = listaFornecedor;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtEmpresa.Clear();
            txtNome.Clear();
            mskCPF.Clear();
            mskTelefone.Clear();
            mskCnpjFornecedor.Clear();
            txtRG.Clear();
            mskDataNascimento.Clear();
            

        }

        //private void DtgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        //private void DtpData_ValueChanged(object sender, EventArgs e)
        //{
            
           
        //}
    }
}
