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
    public partial class frmCatedratico : Form
    {

        catedratico profe = new catedratico();

        public frmCatedratico()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "")
                {
                    profe.Nombre = txtNombre.Text;
                }
                else
                {
                    profe.Nombre = "N/A";
                }

                if (txtApellido.Text != "")
                {
                    profe.Apellido = txtApellido.Text;
                }
                else
                {
                    profe.Apellido = "N/A";
                }

                if (txtEdad.Text != "")
                {
                    profe.Edad = Convert.ToInt32(txtEdad.Text);
                }
                else
                {
                    profe.Edad = 0;
                }

                if (txtProfesion.Text != "")
                {
                    profe.Profession = txtProfesion.Text;
                }
                else
                {
                    profe.Profession = "N/A";
                }

                if (txtPuesto.Text != "")
                {
                    profe.Puesto = txtPuesto.Text;
                }
                else
                {
                    profe.Puesto = "N/A";
                }

                if (txtSueldo.Text != "")
                {
                    profe.Sueldo = Convert.ToDouble(txtSueldo.Text);
                }
                else
                {
                    profe.Sueldo = 0;
                }

                if (txtCurso.Text != "")
                {
                    profe.Curso = txtCurso.Text;
                }
                else
                {
                    profe.Curso = "N/A";
                }

                txtNombre.ReadOnly = true;
                txtApellido.ReadOnly = true;
                txtEdad.ReadOnly = true;
                txtProfesion.ReadOnly = true;
                txtPuesto.ReadOnly = true;
                txtSueldo.ReadOnly = true;
                txtCurso.ReadOnly = true;
            } catch (Exception error)
            {
                txtExtra.Text = error.ToString();
            }
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtExtra.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtEdad.ReadOnly = false;
            txtProfesion.ReadOnly = false;
            txtPuesto.ReadOnly = false;
            txtSueldo.ReadOnly = false;
            txtCurso.ReadOnly = false;
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            btnAceptar.PerformClick();
            btnClear.PerformClick();

            txtExtra.Text = "Nombre: " + profe.Nombre + "\r\n" +
                "Apellido: " + profe.Apellido + "\r\n" +
                "Edad: " + profe.Edad + "\r\n" +
                "Profesion: " + profe.Profession + "\r\n" +
                "Puesto: " + profe.Puesto + "\r\n" +
                "Sueldo: " + profe.Sueldo + "\r\n" +
                "Curso: " + profe.Curso;
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            try
            {
                txtExtra.Text += "\r\nSaludando: " + profe.Saludar();
            }
            catch
            {
                txtExtra.Text += "\r\nError, objeto catedratico no ha sido creado";
            }
        }

        private void btnContestarLlamada_Click(object sender, EventArgs e)
        {
            try
            {
                txtExtra.Text += "\r\nContestando Llamada: " + profe.contestarLlamadas();
            }
            catch
            {
                txtExtra.Text += "\r\nError, objeto catedratico no ha sido creado";
            }
        }

        private void btnCalcularIgss_Click(object sender, EventArgs e)
        {
            try
            {
                txtExtra.Text += "\r\nIGSS: " + profe.calcularIgss().ToString();
            }
            catch
            {
                txtExtra.Text += "\r\nError, objeto catedratico no ha sido creado";
            }
        }

        private void btnCalcularHorasExtra_Click(object sender, EventArgs e)
        {
            try
            {
                txtExtra.Text += "\r\nHoras Extra: " + profe.calcularHoraExtra().ToString();
            }
            catch
            {
                txtExtra.Text += "\r\nError, objeto catedratico no ha sido creado";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtProfesion.Text = "";
            txtPuesto.Text = "";
            txtSueldo.Text = "";
            txtCurso.Text = "";
        }
    }
}
