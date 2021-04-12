using System;
using System.IO;
using System.Globalization;
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
    public partial class frmCredito : Form
    {
        credito credit = new credito();
        frmFondosInsuficientes sinDinero = new frmFondosInsuficientes();
        frmPocosDiasRestantes pocosDias = new frmPocosDiasRestantes();
        frmDiasRestraso diasRetraso = new frmDiasRestraso();
        public frmCredito()
        {
            InitializeComponent();
        }

        private void frmCredito_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.progra3.clientes);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            credit.Id_Cliente = int.Parse(comboID.SelectedValue.ToString());

            DataRow registro = progra3.clientes.FindByid_cliente(credit.Id_Cliente);
            credit.Credito = int.Parse(registro["credito"].ToString());
            credit.Dias_Credito = (registro["dias_credito"].ToString());
            if ((bool)registro["estado"])
            {
                credit.Estado = true;
                checkActivo.Checked = true;
            }
            else
            {
                credit.Estado = false;
                lblInfo.Text = "Cliente no está activo.";
                checkActivo.Checked = false;
            }

            txtCredito.Text = credit.Credito.ToString();

            dtpFechaPago.Value = DateTime.ParseExact(credit.Dias_Credito, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //credit.Dias_Restantes = (DateTime.ParseExact(credit.Dias_Credito, "dd/MM/yyyy", CultureInfo.InvariantCulture) - (DateTime.ParseExact(credit.fechaActual(), "dd/MM/yyyy", CultureInfo.InvariantCulture))).ToString();
            credit.Dias_Restantes = DateTime.ParseExact(credit.Dias_Credito, "dd/MM/yyyy", CultureInfo.InvariantCulture).Subtract(DateTime.ParseExact(credit.fechaActual(), "dd/MM/yyyy", CultureInfo.InvariantCulture)).Days.ToString();
            txtDiasDisponible.Text = credit.Dias_Restantes;

            if (int.Parse(credit.Dias_Restantes) <= 5 && int.Parse(credit.Dias_Restantes) >= 0)
            {
                pocosDias.Show();
            }

            if (int.Parse(credit.Dias_Restantes) < 0)
            {
                btnSaltarDia.Enabled = false;
                lblInfo.Text = "Cliente se pasó de la fecha de pago limite.";
                credit.Estado = false;
                checkActivo.Checked = false;
                diasRetraso.Show();
            }

            btnSaltarDia.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                btnBuscar.PerformClick();
            } catch (Exception error) 
            {
                lblInfo.Text = error.ToString();
            }
            if (checkActivo.Checked == true)
            {
                credit.Credito = int.Parse(txtCredito.Text);
                credit.Consumo = int.Parse(txtConsumo.Text);

                credit.Consumo = credit.Credito - credit.Consumo;

                if (credit.Consumo < 0)
                {
                    lblInfo.Text = "Fondos insuficientes.";
                    sinDinero.Show();
                }
                else
                {
                    credit.Id_Cliente = int.Parse(comboID.SelectedValue.ToString());
                    credit.Credito = credit.Consumo;

                    DataRow registro = progra3.clientes.FindByid_cliente(credit.Id_Cliente);
                    registro["credito"] = credit.Credito;

                    this.clientesTableAdapter.Update(this.progra3.clientes);
                    this.clientesTableAdapter.Fill(this.progra3.clientes);
                }
            }
            else
            {
                lblInfo.Text = "Cliente no está activo.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnSaltarDia_Click(object sender, EventArgs e)
        {
            //credit.Dias_Restantes = (Convert.ToDateTime(credit.Dias_Credito).AddDays(-1)).ToString();
            //credit.Dias_Restantes = (Convert.ToDateTime(credit.fechaActual()).AddDays(1)).ToString(); 

            try
            {
                credit.Dias_Saltar = int.Parse(txtDiasSaltar.Text);
                if (txtDiasSaltar.Text != "")
                {
                    txtDiasDisponible.Text = (Convert.ToInt32(credit.Dias_Restantes) - credit.Dias_Saltar).ToString();
                }
                
            } catch (Exception error)
            {
                lblInfo.Text = error.ToString();
            }

        }
    }
}
