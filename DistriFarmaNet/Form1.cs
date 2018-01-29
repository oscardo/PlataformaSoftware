using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistriFarmaNet
{
    public partial class FormDistriFarma : Form
    {
        private DataTable tabla;

        public FormDistriFarma()
        {
            InitializeComponent();
            InicializarTabla();
        }

        private void InicializarTabla()
        {
            tabla = new DataTable();
            DataColumn column;
            
            // Medicamento
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Medicamento";
            tabla.Columns.Add(column);

            // Tipo de medicamento
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Tipo de Medicamento";
            tabla.Columns.Add(column);

            // Cantidad
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Cantidad";
            tabla.Columns.Add(column);

            // Distribuidor
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Distribuidor";
            tabla.Columns.Add(column);

            // Sucursal Primaria
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Sucursal Primaria";
            tabla.Columns.Add(column);

            // Sucursal Segundaria
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Sucursal Secundaria";
            tabla.Columns.Add(column);

            // Notas
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Notas Especiales";
            tabla.Columns.Add(column);
        }

        /// <summary>
        /// Aceptar y agregar a la grilla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!RevisionPantalla()){
                Mensaje("Error en pantalla");
            }
            else {
                LlenarGrilla();
                LimpiarPantalla();
            }
        }

        /// <summary>
        /// LLena la grilla
        /// </summary>
        private void LlenarGrilla()
        {
            string Medicamento = string.Empty;
            string TipoMedicamento = string.Empty;
            string Distribuidor = string.Empty;
            string Cantidad = string.Empty;
            string Sucursal_principal = string.Empty;
            string Sucursal_secundaria = string.Empty;
            string Notas = string.Empty;

            Medicamento = this.txtMedicamento.Text.ToString();
            TipoMedicamento = this.cbTipoMedicamento.Text.ToString();
            Cantidad = this.nDUCantidad.Value.ToString();
            if (this.rbCemefar.Checked)
            {
                Distribuidor = this.rbCemefar.Text.ToString();
            }
            if (this.rbCofarma.Checked)
            {
                Distribuidor = this.rbCofarma.Text.ToString();
            }
            if (this.rbEmpsephar.Checked)
            {
                Distribuidor = this.rbEmpsephar.Text.ToString();
            }
            if (this.chbfarmacia_principal.Checked)
            {
                Sucursal_principal = "Calle de la Rosa n. 28";                
            }
            if (this.chbfarmacia_secundaria.Checked)
            {
                Sucursal_secundaria = "Calle Alcazabilla n. 3. ";
            }
            Notas = this.rtNotas.Text.ToString();

            DataRow row = tabla.NewRow();
            row["Medicamento"] = Medicamento;
            row["Tipo de Medicamento"] = TipoMedicamento;
            row["Cantidad"] = Cantidad;
            row["Distribuidor"] = Distribuidor;
            row["Sucursal Primaria"] = Sucursal_principal;
            row["Sucursal Secundaria"] = Sucursal_secundaria;
            row["Notas Especiales"] = Notas;
            tabla.Rows.Add(row);

            // Set a DataGrid control's DataSource to the DataView.
            dgGrilla.DataSource = tabla;
        }

        /// <summary>
        /// revisa los datos de la pantalla, si es correcto deja seguir Y si no, muestra en pantalla el error
        /// </summary>
        /// <returns></returns>
        private bool RevisionPantalla()
        {
            bool respuesta = false;
            try
            {
                if (this.txtMedicamento.Text.Length == 0 || this.txtMedicamento.Text.Length >= 31) {
                    Mensaje("En el campo de Medicamento no puede estar vacio");
                    return respuesta;
                }
                if(this.cbTipoMedicamento.SelectedIndex == -1)
                {
                    Mensaje("En el campo de Tipo de medicamento debe seleccionar uno");
                    return respuesta;
                }
                if (this.rbCemefar.Checked == false && this.rbCofarma.Checked == false && this.rbEmpsephar.Checked == false)
                {
                    Mensaje("Debe seleccionar algún distribuidor");
                    return respuesta;
                }
                if (this.chbfarmacia_principal.Checked == false && this.chbfarmacia_secundaria.Checked == false)
                {
                    Mensaje("Debe seleccionar alguna sucursal");
                    return respuesta;
                }
                respuesta = true;
            }
            catch (Exception ex)
            {
                string error = ex.Message.ToString() + " - " + ex.StackTrace.ToString() + " - " + ex.Source.ToString();
                Mensaje(error);
            }
            return respuesta;
        }

        /// <summary>
        /// mensaje que se desea mostrar
        /// </summary>
        /// <param name="msg"></param>
        private void Mensaje(string msg)
        {
            MessageBox.Show(this, msg, "DistriFarma .Net");
        }

        /// <summary>
        /// simplemente hace el llamado a la función de borra la pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarPantalla();
        }

        /// <summary>
        /// Borra pantalla
        /// </summary>
        private void LimpiarPantalla()
        {
            this.txtMedicamento.Text = string.Empty;
            this.rbCemefar.Checked = false;
            this.rbCofarma.Checked = false;
            this.rbEmpsephar.Checked = false;
            this.cbTipoMedicamento.SelectedIndex = -1;
            this.nDUCantidad.Value = 1;
            this.chbfarmacia_principal.Checked = false;
            this.chbfarmacia_secundaria.Checked = false;
            this.rtNotas.Text = string.Empty;

        }

        /// <summary>
        /// Envia la petición 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if(this.tabla.Rows.Count > 0) { 
                string existencias = this.tabla.Rows.Count.ToString();
                string pedido = "Estas de acuerdo en el pedido de " + existencias + " existencias de la bodega a la sucursal";
                DialogResult dialogResult = MessageBox.Show(pedido, "DistriFarma .Net", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Mensaje("Enviado Correctamente");
                    this.tabla.Clear();
                    this.dgGrilla.DataSource = this.tabla;
                    LimpiarPantalla();
                }
            }
        }

        /// <summary>
        /// cancela el pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            if (this.tabla.Rows.Count > 0)
            {
                string existencias = this.tabla.Rows.Count.ToString();
                string pedido = "Desean cancelar el pedido de " + existencias + " existencias de la bodega a la sucursal";
                DialogResult dialogResult = MessageBox.Show(pedido, "DistriFarma .Net", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.tabla.Clear();
                    this.dgGrilla.DataSource = this.tabla;
                    LimpiarPantalla();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgGrilla_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in this.dgGrilla.SelectedCells)
            {
                if (oneCell.Selected) {
                    int fila = oneCell.RowIndex;
                    string existencias = tabla.Rows[fila]["Medicamento"].ToString();
                    string pedido = "Desean eliminar el pedido de " + existencias + " del listado";
                    DialogResult dialogResult = MessageBox.Show(pedido, "DistriFarma .Net", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        tabla.Rows.RemoveAt(fila);
                        dgGrilla.DataSource = tabla;
                    }
                }
            }
        }
    }
}



