using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operaciones obj = new Operaciones();
        private void btn_sumar_Click(object sender, EventArgs e)
        {
            if(!obj.IsNUmeric(txt_num1.Text) && !obj.IsNUmeric(txt_num2.Text))
            {
                txt_resultados.Text = "INGRSE UN VALOR VALIDO";
            }
            else
            {
                int suma = obj.Sumar(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultados.Text = Convert.ToString(suma);
            }
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNUmeric(txt_num1.Text) && !obj.IsNUmeric(txt_num2.Text))
            {
                txt_resultados.Text = "INGRSE UN VALOR VALIDO";
            }
            else
            {
                int resta = obj.resta(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultados.Text = Convert.ToString(resta);
            }
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if (!obj.IsNUmeric(txt_num1.Text) && !obj.IsNUmeric(txt_num2.Text))
            {
                txt_resultados.Text = "INGRSE UN VALOR VALIDO";
            }
            else
            {
                int mult = obj.multiplicacion(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultados.Text = Convert.ToString(mult);
            }
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            if (!obj.IsNUmeric(txt_num1.Text) && !obj.IsNUmeric(txt_num2.Text))
            {
                txt_resultados.Text = "INGRSE UN VALOR VALIDO";
            }
            else
            {
                int division = obj.division(Convert.ToInt32(txt_num1.Text), Convert.ToInt32(txt_num2.Text));
                txt_resultados.Text = Convert.ToString(division);
            }
        }
    }
}
