using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    public partial class Form2 : MaterialForm
    {
        public string Endereco
        {
            get { return txtEndereco.Text; }
        }
        public Form2()

        {
            InitializeComponent();
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //criar uma variavel ws dos correios
                var webService = new ConsultaCEP.WScorreio.AtendeClienteClient();
                //executa o metudo que consulta o CEP
                //pareamento: string cep
                var res = webService.consultaCEP(txtCEP.Text);

                txtEndereco.Text = res.end;
                txtBairro.Text = res.bairro;
                txtComplemento2.Text = res.complemento2;
                txtCidade.Text = res.cidade;
                txtEstado.Text = res.uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //fecha a telea
            this.Close();
        }
    }
}