﻿using Capa_Logica;
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
    public partial class consultaempleado : Form
    {

        Logica logic = new Logica();
        public consultaempleado()
        {
            InitializeComponent();
            MostrarConsulta();
        }
        public void MostrarConsulta()
        {
            OdbcDataReader mostrar = logic.consultadeempleado();
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consultaproveedor.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
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
