using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Data.OleDb;
using System.Data;

namespace CapaDatos
{
    public class Datos
    {
        private static OleDbCommand cmd;
        private static OleDbDataAdapter da;
        private static OleDbConnection con;

        private static DataSet ds;
        private static string strCon;

        public static void preparar(string x)
        {
            strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + x + @"\Datos\Fiesta.mdb";

            //strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\proyectoFacu\\visstu\\WindowsFormsApp1\\bin\\Debug\\datos\\infracciones.mdb";
        }
        public static bool recuperarAutos(List<ArrayList> datos)
        {
            ArrayList autos;
            bool ok;
            string consulta = "SELECT * FROM autos";
            try
            {
                con = new OleDbConnection(strCon);
                con.Open();
                da = new OleDbDataAdapter(consulta, con);
                ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    autos = new ArrayList();
                    IEnumerator en = ds.Tables[0].Rows[i].ItemArray.GetEnumerator();
                    while (en.MoveNext())
                    {
                        autos.Add(en.Current);
                    }
                    datos.Add(autos);
                }
                ok = true;
                con.Close();
            }

            catch (Exception ex)
            {
                string error = ex.Message;
                ok = false;
            }
            finally
            {


            }
            return ok;
        }

        public static bool guardarPersona(ArrayList p)
        {
            bool ok = false;
            int dni = (int)p[0];
            string nombre = p[1].ToString();
            string fNac = p[2].ToString();
            string parenLugar = p[3].ToString();
            int tipo = (int)p[4];
            string consulta = "INSERT INTO Personas(dni,Nombre,FechaNacimiento,Otro,tipo) Values (" + dni.ToString() + ",'" + nombre + "','" + fNac + "','" + parenLugar + "'," + tipo.ToString() + ");";
            try
            {
                con = new OleDbConnection(strCon);
                con.Open();
                //da = new OleDbDataAdapter(consulta, con);
                cmd = new OleDbCommand(consulta, Datos.con);
                cmd.ExecuteNonQuery();
                Datos.con.Close();
                ok = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
            finally
            {

                //Datos.con.Dispose();
                //Datos.cmd.Dispose();
            }

            return ok;
        }


    }
}
