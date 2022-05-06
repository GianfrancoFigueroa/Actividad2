using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using Conexiones;


namespace Actividad2
{
    public partial class Cargar_Articulo : Form
    {
        public Cargar_Articulo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)  
        {
            ClassArticulo Articulo = new ClassArticulo();
            ArticulosListado Agregar = new ArticulosListado();
            try
            {
                Articulo.Codigo = int.Parse(TxbCodigo.Text);
                Articulo.Nombre = TxbNombre.Text;
                Articulo.Descripción = TxbDescrip.Text;
                Articulo.Marcas.Marca = CbMarcar.Text;
                Articulo.Categorias.Categoria = CbCategoria.Text;
                Articulo.Precio = decimal.Parse(TxbPrecio.Text);

            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cargar_Articulo_Load(object sender, EventArgs e)
        {
            CbCategoria.Items.Add("Celulares");
            CbCategoria.Items.Add("Televisores");
            CbCategoria.Items.Add("Media");
            CbCategoria.Items.Add("Audios");
            CbMarcar.Items.Add("Samsung");
            CbMarcar.Items.Add("Apple");
            CbMarcar.Items.Add("Sony");
            CbMarcar.Items.Add("Huawei");
            CbMarcar.Items.Add("Motorola");
        }
    }
}
