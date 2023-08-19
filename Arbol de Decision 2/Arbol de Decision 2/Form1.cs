using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Arbol_de_Decision_2.Form1;
namespace Arbol_de_Decision_2
{

    public partial class Form1 : Form
    {
        private int Neumonia = 0;
        private int Gripe = 0;
        private int Gastroenteritis = 0;
        private int Sinusitis = 0;
        private int Covid = 0;
        private int sinusitus;

        public int Neumonía { get; private set; }

        public Form1()

        {

            InitializeComponent();

            DataGridViewRowsAddedEventHandler dataGridView1_RowsAdded = null;
            
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;

            
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.AutoGenerateColumns = false;
           

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            CalcularEnfermedadMasProbable();
        }
        private void CalcularEnfermedadMasProbable()
        {
            Dictionary<string, int> enfermedades = new Dictionary<string, int>
    {
        { "COVID-19", Covid },
        { "Sinusitis", Sinusitis },
        { "Gripe", Gripe },
        { "Neumonia", Neumonia },
        { "Gastroenteritis", Gastroenteritis }
    };

            int maxPuntos = enfermedades.Values.Max();

           
            List<string> enfermedadesMasProbables = enfermedades.Where(kv => kv.Value == maxPuntos).Select(kv => kv.Key).ToList();

           
            string mensajeEnfermedades = "Enfermedades más probables: " + string.Join(", ", enfermedadesMasProbables) ;

            resultadoLabel.Text = mensajeEnfermedades;
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Abre un cuadro de diálogo para seleccionar la ubicación del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar datos en un archivo CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Abre el archivo seleccionado para escribir
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    // Escribe los encabezados de columna
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        writer.Write(dataGridView1.Columns[i].HeaderText);
                        if (i < dataGridView1.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();

                    // Escribe los datos de las filas
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value);
                            if (i < dataGridView1.Columns.Count - 1)
                            {
                                writer.Write(",");
                            }
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Datos guardados exitosamente.");
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        public void Primera(object sender, EventArgs e)
        {
           
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    Covid += 3;
                    
                }
            }
        }
        public void Segunda(object sender, EventArgs e)
        {
            
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    Sinusitis += 2;
                    Covid++;
                    Gripe++;
                }
            }
        }
        public void Tercera (object sender, EventArgs e)
        {
            
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {   

                    Neumonia ++;
                    Gastroenteritis += 2;
                    Gripe++;
                }
            }
        }
        public void Cuarta(object sender, EventArgs e)
        {
          
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    Covid++;
                    sinusitus++;
                    Neumonía += 2;
                    
                }
            }
        }
        public void Quinta(object sender, EventArgs e)
        {
          
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    Gastroenteritis += 2;
                    Gripe++;
                   
                }
            }
        }

        private void resultadoLabel_Click(object sender, EventArgs e)
        {

        }

    }

}

