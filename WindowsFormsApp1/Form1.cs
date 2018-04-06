using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cria uma lista para a inserção dos itens do ListBox
            List<string> stringListBox = new List<string>();

            //Percorre o ListBox
            foreach (var item in ListBox.SelectedItems)
            {
                //Insere os itens selecionados na lista
                stringListBox.Add(item.ToString());
            }

            //Separa os Itens por virgula e atribui a uma string
            string ItensSelecionados = String.Join(",", stringListBox);

            //pega o texto do TextBox
            string TextoDoTextBox = textBox1.Text;

            //Compara o comteúdo das strings
            if (String.Compare(ItensSelecionados, textBox1.Text, true) == 0)
            {
                MessageBox.Show(this, "Item(s) encontrado: " + ItensSelecionados, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label1.Text = string.Empty;
            }
            else
            {
                label1.Text = "Item não encontrado encontrado ";
            }

        }
    }
}