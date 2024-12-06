using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keythi.Prototipos.Ejercicio2.DatosDeUnAuto
{
    public partial class DatosDeUnAutoForm : Form
    {
        private DatosDeUnAutoModelo modelo = new();

        public DatosDeUnAutoForm()
        {
            InitializeComponent();

            // Establecer la fecha actual en el label
            TxtFechaHoy.Text = DateTime.Now.ToString("yyyy-MM-dd");
            labelName.Text = "Keythi";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DatosDeUnAutoForm_Load(object sender, EventArgs e)
        {

            // PREPARACION NECESARIA ANTES QUE EL FORMULARIO SE MUESTRE
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var auto = new Auto();

            if (!int.TryParse(TxtPrecio.Text, out int precio))
            {
                MessageBox.Show("El precio no es numérico");
                return;
            }

            if (!int.TryParse(TxtAño.Text, out int año))
            {
                MessageBox.Show("El año no es válida");
                return;
            }

            // le paso los datos de la pantalla:
            var nombreSeleccionado = ComboMarca.SelectedItem.ToString();
            if (Enum.TryParse<TiposMarca>(nombreSeleccionado, out var marca))
            {
                auto.Marca = marca;
            }
            else
            {
                MessageBox.Show("Marca no válida seleccionada.");
            }

            auto.Modelo = TxtModelo.Text;
            auto.Año = año;
            auto.Precio = precio;

            var error = modelo.IngresarAuto(auto);

            if (error == null)
            {
                MessageBox.Show("Datos ingresos correctamente.");
            }
            else
            {
                MessageBox.Show(error);
            }

            // VALIDAR TODO TxtETC y ponerlo en persona, validar numeros o fecha
            // recordar poner TxtFecha como fecha de hoy

            // si es que da error dar mensaje de error
            // o en todo caso darle un return de que acepto correctamente
        }

        private void TxtAño_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtFechaHoy_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
