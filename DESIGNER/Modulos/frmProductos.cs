using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
namespace DESIGNER.Modulos
{
    public partial class frmProductos : Form
    {   /// <summary>
        /// llamamos
        /// </summary>
        Producto producto = new Producto();
        Categoria categroia = new Categoria();
        Subcategoria subcategoria = new Subcategoria();
        Marca marca = new Marca();
        //bandera=variable logica que controla estados;
        bool categoriasListas = false;
        public frmProductos()
        {
            InitializeComponent();
        }
        private void actualizarmarcas()
        {

            cbomarca.DataSource = marca.listar();
            cbomarca.Refresh();
            cbomarca.DisplayMember = "marca"; //mostrar
            cbomarca.ValueMember = "idmarca"; //pk(guarda)
            cbomarca.Refresh();
        }
        private void actualizarProducto()
        {
            gridproductos.DataSource = producto.listar();
            gridproductos.Refresh();

            #region
        }
        private void actualizarcategorias()
        {
            cbocategoria.DataSource = categroia.lista();
            cbocategoria.Refresh();
            cbocategoria.DisplayMember = "categoria";
            cbocategoria.ValueMember = "idcategoria";
            cbocategoria.Refresh();



        }


        private void frmProductos_Load(object sender, EventArgs e)
        {
            actualizarProducto();
            actualizarmarcas();
            actualizarcategorias();
            categoriasListas = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbomarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbocategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriasListas)
            {
                //invocar al metodo que carga las subcategorias
                int idcategoria = Convert.ToInt32(cbocategoria.SelectedValue.ToString());
                cbosubcateoria.DataSource = subcategoria.listar(idcategoria);
                cbosubcateoria.DisplayMember = "subcategoria";
                cbosubcateoria.ValueMember = "idsubcategoria";
                cbosubcateoria.Refresh();
                cbosubcateoria.Text = "";
            }


        }
    }
}
    

