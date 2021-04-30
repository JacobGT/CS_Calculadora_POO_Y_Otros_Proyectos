using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra3
{
    public partial class frmHashTables : Form
    {
        HashTable tablaHash = new HashTable();
        public frmHashTables()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            txtHash.Text = tablaHash.HashFunction(txtKey.Text).ToString();
            txtValueDos.Text = txtValueUno.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tablaHash.ColissionOmitter(int.Parse(txtHash.Text), txtValueDos.Text);
            txtInfo.Text = "Elemento agregado a la Hash Table";
        }

        private void btnIterar_Click(object sender, EventArgs e)
        {
            txtInfo.Text = tablaHash.iterarTabla();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Elementos en la Hash Table: " + tablaHash.countTabla();
        }

        private void btnSearchKey_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "Elementos buscado es: " + tablaHash.searchByKey(int.Parse(txtHash.Text));
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            txtInfo.Text = "El elemenot buscado existe: " + tablaHash.containsElement(int.Parse(txtHash.Text));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            tablaHash.removeElement(int.Parse(txtHash.Text));
            txtInfo.Text = "Elemento eliminado de la Hash Table";
        }
    }
}
