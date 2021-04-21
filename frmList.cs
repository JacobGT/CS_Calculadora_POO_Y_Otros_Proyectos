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
    public partial class frmList : Form
    {
        list lista = new list();
        public frmList()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Trabaja como una lista ligada de tipo generico, como si fuera un arreglo " +
                "\ndinamico en el cual podemos agregar o eliminar elementos en tiempo de \nejecucion.";
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Agrega un elemento a la lista.";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lista.addLista(int.Parse(txtValor.Text));
            txtMostrar.Text = "Valor ingresado a la Lista";
        }

        private void btnIterar_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Itera la lista para ver su contenido";
        }

        private void btnIterar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = lista.iteracionLista();
        }

        private void btnCount_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Muestra cuantos elementos existen adentro de la Lista";
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = lista.countLista().ToString();
        }

        private void btnContains_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Detecta si existe determinado elemento en la Lista. Regresa un booleano.";
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = lista.containsLista(int.Parse(txtValor.Text)).ToString();
        }

        private void btnIndexOf_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Obtener el indice de un elemento en particular. De no existir devuelve \"-1\"";
        }

        private void btnIndexOf_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = lista.indexOfLista(int.Parse(txtValor.Text)).ToString();
        }

        private void btnInsert_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Inserta un elemento en un indice dado. Se requiere un valor y un indeice.";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lista.insertLista(int.Parse(txtIndex.Text), int.Parse(txtValor.Text));
            txtMostrar.Text = "Se inserto el valor " + txtValor.Text + "en la posicion " + txtIndex.Text;
        }

        private void btnRemoveAt_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Elimina un valor en un idice en especifico.";
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lista.removeAtLista(int.Parse(txtIndex.Text));
            txtMostrar.Text = "Se removio el elemento en la posicion " + txtIndex.Text;
        }

        private void btnRemove_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Elimina el primer ocurrencia del elemento en la lista dado un valor\n" +
                "Elimina el primer elemento(según valor ingresado) encontrado en la lista.";
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lista.removeLista(int.Parse(txtValor.Text));
            txtMostrar.Text = "Se removio el elemento en la posicion " + txtIndex.Text;
        }

        private void btnReverse_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Se inverte el orden de la lista.";
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lista.reverseLista();
            txtMostrar.Text = "Se ha invertido el orden de la lista.";
        }

        private void btnSort_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Se ordena la lista. Si no es de tipo número tiene que incluir iComparable.";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            lista.sortLista();
            txtMostrar.Text = "Se ha ordenado la lista de menor a mayor.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lista.clearLista();
            txtMostrar.Text = "Se ha vaciado la lista.";
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Vacía toda la lista pero conserva su capacidad.";
        }
    }
}
