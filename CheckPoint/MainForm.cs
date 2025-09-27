using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPoint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Entrada_Click(object sender, EventArgs e) { RegistrarPonto("Entrada");}


        private void Saida_Click(object sender, EventArgs e) { RegistrarPonto("Saída");}
        

        private void RegistrarPonto(string tipo)
        {
         try
            {
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                var fileName = $"{tipo}_{DateTime.Now:MM}.txt";
                var pathCombined = System.IO.Path.Combine(desktop, fileName);
                var linha = $"Dia - {DateTime.Now:dd - HH:mm}{Environment.NewLine}";
                
                File.AppendAllText(pathCombined, linha);
                MessageBox.Show($"Ponto de {tipo} Registrado com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar ponto de {tipo}: {ex.Message}");
            }
        }
    }
}
