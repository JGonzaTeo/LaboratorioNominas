using Capa_Logica;
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

namespace Laboratorio_Nomina.Consultas
{
    public partial class Consultapuesto : Form
    {
        Logica logic = new Logica();
        public Consultapuesto()
        {
            InitializeComponent();
            MostrarConsulta();
        }
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultapuesto();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaproveedor.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
        private void Consultapuesto_Load(object sender, EventArgs e)
        {
            Dgv_consultaproveedor.Rows.Clear();
            MostrarConsulta();

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaproveedor.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaproveedor.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
