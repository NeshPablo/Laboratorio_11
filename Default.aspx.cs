using Laboratorio_11.Clases;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio_11
{
    public partial class _Default : Page
    {
        static public List<Nota> NotasTemp = new List<Nota>();
        static public List<Alumno> AlumnoTemp = new List<Alumno>();
        static public List<Universidad> UniversidadTemp = new List<Universidad>();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (!IsPostBack)
            {
                
                string archivo = Server.MapPath("Alumno.json");
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                alumnos = JsonConvert.DeserializeObject<List<Alumno>>(json);
            }*/
        }
       /* void GuardarDatos()
        {
            string json = JsonConvert.SerializeObject(alumnos);
            string archivo = Server.MapPath("Alumno.json");
            System.IO.File.WriteAllText(archivo, json);
        }
       */
        protected void Button3_Click(object sender, EventArgs e)
        {
            Universidad universidad = new Universidad();
            universidad.universidades = DropDownList1.SelectedValue;
            universidad.Alumnos = AlumnoTemp.ToArray().ToList();


            UniversidadTemp.Add(universidad);

            string json = JsonConvert.SerializeObject(universidad);

            string archivo = Server.MapPath("Alumnos.json");

            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Carne = txt_carne.Text;
            alumno.Apellido = txt_apellido.Text;
            alumno.Nombre = txt_nombre.Text;
            alumno.Notas = NotasTemp.ToArray().ToList();

            AlumnoTemp.Add(alumno);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Curso = txt_punteo.Text;
            nota.Punteo = Convert.ToInt16(txt_punteo);

            NotasTemp.Add(nota);
        }
    }
}