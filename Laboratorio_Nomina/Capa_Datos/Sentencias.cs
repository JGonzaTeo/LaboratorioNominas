using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
   public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        //--------------------------------------------------------------------Metodos General--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }
        public OdbcDataReader consultaayudas(string id)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from ayudas where pkcodigoayuda =" + id + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------//


        //-------------------------------------------------------------------------Foemulario de conceptos----------------------------------------------------------
        public OdbcDataReader Insertarpuesto(string sCodigo, string sNombre, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into puesto values(" + sCodigo + ", '" + sNombre + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarpuesto(string sCodigo, string sNombre, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE puesto set nombre='" + sNombre + "',estado='" + sestado + "' where codigo_puesto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarpuesto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE puesto set estatus_puesto='0' where codigo_puesto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultapuesto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM puesto;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        public OdbcDataReader Insertardepartamento(string sCodigo, string sNombre, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into departamento values(" + sCodigo + ", '" + sNombre + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificardepartamento(string sCodigo, string sNombre, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamento set nombre_departamento='" + sNombre + "',estatus_departamento='" + sestado + "' where codigo_departamento='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminardepartamento(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE departamento set estatus_departamento='0' where codigo_departamento='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultadepartamento()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM departamento;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader Insertarconcepto(string sCodigo, string sNombre, string sefecto,string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into concepto values(" + sCodigo + ", '" + sNombre + "' , '" + sefecto + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarconcepto(string sCodigo, string sNombre, string sefecto,string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set nombre_concepto='" + sNombre + "',efecto_concepto='" + sefecto + "',estatus_concepto='" + sestado + "' where codigo_concepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE concepto set estatus_concepto='0' where codigo_concepto='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultaconcepto()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM concepto;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader Insertarempleado(string sCodigo, string sNombre, string spuesto, string sdepartamento,string ssueldo, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into empleado values(" + sCodigo + ", '" + sNombre + "' , '" + spuesto + "' , '" + sdepartamento + "' , '" + ssueldo + "' ,'" + sestado + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader modificarempleado(string sCodigo, string sNombre, string spuesto, string sdepartamento, string ssueldo, string sestado)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set nombre_empleado='" + sNombre + "',codigo_puesto='" + spuesto + "',codigo_departamento='" + sdepartamento + "',sueldo_empleado='" + ssueldo + "',estatus_empleado='" + sestado + "' where codigo_empleado='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader eliminarempleado(string sCodigo)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE empleado set estatus_empleado='0' where codigo_empleado='" + sCodigo + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultacempleadoo()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM empleado;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

    }
}
