using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_velha
{
    public partial class tela1 : Form
    {
        public tela1()
        {
            InitializeComponent();
        }

        public void Redirect(string url);
        {


        }

        private string Definir_turno()
        {
            if (var_turno.Text == "1")
            {
                return "x";
            }
            else
            {
                return "O";
            }

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (lbl_1.Text == "[ ]"){

                lbl_1.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (lbl_2.Text == "[ ]")
            {

                lbl_2.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (lbl_3.Text == "[ ]")
            {

                lbl_3.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lbl_4.Text == "[ ]")
            {

                lbl_4.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbl_5.Text == "[ ]")
            {

                lbl_5.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbl_6.Text == "[ ]")
            {

                lbl_6.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lbl_7.Text == "[ ]")
            {

                lbl_7.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbl_8.Text == "[ ]")
            {

                lbl_8.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbl_9.Text == "[ ]")
            {

                lbl_9.Text = Definir_turno();
                var_turno.Text = Convert.ToString(Convert.ToInt32(var_turno.Text) * -1);

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
