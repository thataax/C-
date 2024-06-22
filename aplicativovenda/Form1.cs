using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicativovenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            txt_total.Text = Convert.ToString(Convert.ToDecimal(txt_preco.Text) * Convert.ToDecimal(txt_quant.Text));
            btn_carrinho.Enabled = true;

        }

        private void cob_produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_produto.Text = cob_produto.Text;
        }

        private void cob_preco_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_preco.Text = cob_preco.Text;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_produto.Clear();
            txt_preco.Text = "0";
            txt_quant.Text = "0";
            txt_total.Text = "0";

            lst_carrinho.Items.Clear();
            lbl_totalprod.Text = "0";
            lbl_totalquant.Text = "0";
            lbl_totalpagar.Text = "0";
        }

        private void btn_carrinho_Click(object sender, EventArgs e)
        {
            lbl_mens.Text = txt_quant.Text + " " + txt_produto.Text + " R$" + txt_preco.Text + " | Valor total: R$" + txt_total.Text;
            lst_carrinho.Items.Add(lbl_mens.Text);
            btn_carrinho.Enabled = false;
            lbl_totalprod.Text = Convert.ToString(Convert.ToInt32(lbl_totalprod.Text)+1);
            lbl_totalquant.Text = Convert.ToString(Convert.ToDecimal(lbl_totalquant.Text) + Convert.ToDecimal(txt_quant.Text));
            lbl_totalpagar.Text = Convert.ToString(Convert.ToDecimal(lbl_totalpagar.Text) + Convert.ToDecimal(txt_total.Text));
        }
    }
}
