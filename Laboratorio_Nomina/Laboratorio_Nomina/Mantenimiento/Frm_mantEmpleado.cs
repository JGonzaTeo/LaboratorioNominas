using Capa_Logica;
using Laboratorio_Nomina.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Nomina.Mantenimiento
{
    public partial class Frm_mantEmpleado : Form
    {
        Logica logic = new Logica();
        public Frm_mantEmpleado()
        {
            InitializeComponent();
            Txt_Cod.Text = logic.siguiente("empleado", "codigo_empleado");
        }

        public void limpiar()
        {
            Txt_Cod.Text = "";
            Txt_nombre.Text = "";
            Cbo_estado.Text = "";
            Txt_departamento.Text ="";
            Txt_puesto.Text = "";
            Txt_sueldobase.Text = "";
        }
        public void bloqueartxt()
        {

            Txt_Cod.Enabled = false;
            Txt_nombre.Enabled = false;
            Cbo_estado.Enabled = false;
            Txt_departamento.Enabled = false;
            Txt_puesto.Enabled = false;
            Txt_sueldobase.Enabled = false;
        }
        public void desbloqueartxt()
        {
            Txt_Cod.Enabled = true;
            Txt_nombre.Enabled = true;
            Cbo_estado.Enabled = true;
            Txt_departamento.Enabled = true;
            Txt_puesto.Enabled = true;
            Txt_sueldobase.Enabled = true;
        }

        private void Btn_buscarpuesto_Click(object sender, EventArgs e)
        {
            Consultapuesto concep = new Consultapuesto();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_puesto.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void Btn_consultardepartamento_Click(object sender, EventArgs e)
        {
            consultadepartamento concep = new consultadepartamento();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_departamento.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();

            }
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloqueartxt();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.insertarempleado(Txt_Cod.Text, Txt_nombre.Text, Txt_puesto.Text,Txt_departamento.Text, Txt_sueldobase.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
            Txt_Cod.Text = logic.siguiente("empleado", "codigo_empleado");
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.modificarempleado(Txt_Cod.Text, Txt_nombre.Text, Txt_puesto.Text, Txt_departamento.Text, Txt_sueldobase.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            OdbcDataReader cita = logic.eliminarempleado(Txt_Cod.Text);
            MessageBox.Show("Datos eliminados.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            consultaempleado concep = new consultaempleado();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {

                Txt_Cod.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_nombre.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_puesto.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                     Cells[2].Value.ToString();
                Txt_departamento.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                    Cells[3].Value.ToString();
                Txt_sueldobase.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                    Cells[4].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consultaproveedor.Rows[concep.Dgv_consultaproveedor.CurrentRow.Index].
                     Cells[5].Value.ToString();

            }
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
