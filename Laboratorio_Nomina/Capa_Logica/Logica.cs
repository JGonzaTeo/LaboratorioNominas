using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica
    {
        Sentencias sn = new Sentencias();
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }

        public OdbcDataReader consultaayuda(string id)
        {
            return sn.consultaayudas(id);
        }





        public OdbcDataReader insertarpuesto(string sCodigo, string sNombre, string sestado)
        {
            return sn.Insertarpuesto(sCodigo, sNombre,sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarpuesto(string sCodigo, string sNombre, string sestado)
        {
            return sn.modificarpuesto(sCodigo, sNombre, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarpuesto(string sCodigo)
        {
            return sn.eliminarpuesto(sCodigo);

        }
        //------------------------------------------------------------------------------------------------------sucursal-------------------------------------------------------//
        public OdbcDataReader consultapuesto()
        {
            return sn.consultapuesto();
        }

        public OdbcDataReader insertardepartamento(string sCodigo, string sNombre, string sestado)
        {
            return sn.Insertardepartamento(sCodigo, sNombre, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificardepartamento(string sCodigo, string sNombre, string sestado)
        {
            return sn.modificardepartamento(sCodigo, sNombre, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminardepartamento(string sCodigo)
        {
            return sn.eliminardepartamento(sCodigo);

        }
        //------------------------------------------------------------------------------------------------------sucursal-------------------------------------------------------//
        public OdbcDataReader consultadepartamento()
        {
            return sn.consultadepartamento();
        }

        public OdbcDataReader insertarconcepto(string sCodigo, string sNombre, string sefecto, string sestado)
        {
            return sn.Insertarconcepto(sCodigo, sNombre, sefecto,sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarconcepto(string sCodigo, string sNombre, string sefecto, string sestado)
        {
            return sn.modificarconcepto(sCodigo, sNombre, sefecto,sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarconcepto(string sCodigo)
        {
            return sn.eliminarconcepto(sCodigo);

        }
        //------------------------------------------------------------------------------------------------------sucursal-------------------------------------------------------//
        public OdbcDataReader consultadeconcepto()
        {
            return sn.consultaconcepto();
        }


        public OdbcDataReader insertarempleado(string sCodigo, string sNombre, string spuesto, string sdepartamento, string ssueldo, string sestado)
        {
            return sn.Insertarempleado(sCodigo, sNombre, spuesto, sdepartamento, ssueldo, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader modificarempleado(string sCodigo, string sNombre, string spuesto, string sdepartamento, string ssueldo, string sestado)
        {
            return sn.modificarempleado(sCodigo, sNombre, spuesto, sdepartamento, ssueldo, sestado);

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------//
        //------------------------------------------------------------------------------------------------------UPDATE-------------------------------------------------------//
        public OdbcDataReader eliminarempleado(string sCodigo)
        {
            return sn.eliminarempleado(sCodigo);

        }
        //------------------------------------------------------------------------------------------------------sucursal-------------------------------------------------------//
        public OdbcDataReader consultadeempleado()
        {
            return sn.consultacempleadoo();
        }

    }
}
