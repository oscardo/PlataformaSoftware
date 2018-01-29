namespace DistriFarmaNet
{
    partial class FormDistriFarma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SplitControl = new System.Windows.Forms.SplitContainer();
            this.rtNotas = new System.Windows.Forms.RichTextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.gbDistribuidor = new System.Windows.Forms.GroupBox();
            this.rbCofarma = new System.Windows.Forms.RadioButton();
            this.rbEmpsephar = new System.Windows.Forms.RadioButton();
            this.rbCemefar = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.chbfarmacia_secundaria = new System.Windows.Forms.CheckBox();
            this.chbfarmacia_principal = new System.Windows.Forms.CheckBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.lblDistribuidor = new System.Windows.Forms.Label();
            this.nDUCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbTipoMedicamento = new System.Windows.Forms.ComboBox();
            this.lblTipoMedicamento = new System.Windows.Forms.Label();
            this.txtMedicamento = new System.Windows.Forms.TextBox();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dgGrilla = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblListado = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SplitControl)).BeginInit();
            this.SplitControl.Panel1.SuspendLayout();
            this.SplitControl.Panel2.SuspendLayout();
            this.SplitControl.SuspendLayout();
            this.gbDistribuidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDUCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // SplitControl
            // 
            this.SplitControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitControl.Location = new System.Drawing.Point(0, 0);
            this.SplitControl.Margin = new System.Windows.Forms.Padding(4);
            this.SplitControl.Name = "SplitControl";
            // 
            // SplitControl.Panel1
            // 
            this.SplitControl.Panel1.Controls.Add(this.rtNotas);
            this.SplitControl.Panel1.Controls.Add(this.lblNotas);
            this.SplitControl.Panel1.Controls.Add(this.gbDistribuidor);
            this.SplitControl.Panel1.Controls.Add(this.btnCancelar);
            this.SplitControl.Panel1.Controls.Add(this.btnAceptar);
            this.SplitControl.Panel1.Controls.Add(this.chbfarmacia_secundaria);
            this.SplitControl.Panel1.Controls.Add(this.chbfarmacia_principal);
            this.SplitControl.Panel1.Controls.Add(this.lblSucursal);
            this.SplitControl.Panel1.Controls.Add(this.lblDistribuidor);
            this.SplitControl.Panel1.Controls.Add(this.nDUCantidad);
            this.SplitControl.Panel1.Controls.Add(this.lblCantidad);
            this.SplitControl.Panel1.Controls.Add(this.cbTipoMedicamento);
            this.SplitControl.Panel1.Controls.Add(this.lblTipoMedicamento);
            this.SplitControl.Panel1.Controls.Add(this.txtMedicamento);
            this.SplitControl.Panel1.Controls.Add(this.lblMedicamento);
            // 
            // SplitControl.Panel2
            // 
            this.SplitControl.Panel2.Controls.Add(this.btnCancelarPedido);
            this.SplitControl.Panel2.Controls.Add(this.btnEnviar);
            this.SplitControl.Panel2.Controls.Add(this.dgGrilla);
            this.SplitControl.Panel2.Controls.Add(this.lblListado);
            this.SplitControl.Size = new System.Drawing.Size(1291, 788);
            this.SplitControl.SplitterDistance = 430;
            this.SplitControl.SplitterWidth = 5;
            this.SplitControl.TabIndex = 0;
            // 
            // rtNotas
            // 
            this.rtNotas.AccessibleDescription = "Notas para llevar";
            this.rtNotas.AccessibleName = "Notas especiales";
            this.rtNotas.Location = new System.Drawing.Point(59, 535);
            this.rtNotas.MaxLength = 200;
            this.rtNotas.Name = "rtNotas";
            this.rtNotas.Size = new System.Drawing.Size(367, 161);
            this.rtNotas.TabIndex = 14;
            this.rtNotas.Text = "";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(55, 506);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(140, 20);
            this.lblNotas.TabIndex = 16;
            this.lblNotas.Text = "Notas Especiales";
            // 
            // gbDistribuidor
            // 
            this.gbDistribuidor.Controls.Add(this.rbCofarma);
            this.gbDistribuidor.Controls.Add(this.rbEmpsephar);
            this.gbDistribuidor.Controls.Add(this.rbCemefar);
            this.gbDistribuidor.Location = new System.Drawing.Point(174, 230);
            this.gbDistribuidor.Margin = new System.Windows.Forms.Padding(4);
            this.gbDistribuidor.Name = "gbDistribuidor";
            this.gbDistribuidor.Padding = new System.Windows.Forms.Padding(4);
            this.gbDistribuidor.Size = new System.Drawing.Size(252, 154);
            this.gbDistribuidor.TabIndex = 15;
            this.gbDistribuidor.TabStop = false;
            // 
            // rbCofarma
            // 
            this.rbCofarma.AutoSize = true;
            this.rbCofarma.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCofarma.Location = new System.Drawing.Point(20, 35);
            this.rbCofarma.Margin = new System.Windows.Forms.Padding(4);
            this.rbCofarma.Name = "rbCofarma";
            this.rbCofarma.Size = new System.Drawing.Size(89, 24);
            this.rbCofarma.TabIndex = 7;
            this.rbCofarma.TabStop = true;
            this.rbCofarma.Text = "Cofarma";
            this.rbCofarma.UseVisualStyleBackColor = true;
            // 
            // rbEmpsephar
            // 
            this.rbEmpsephar.AutoSize = true;
            this.rbEmpsephar.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.rbEmpsephar.Location = new System.Drawing.Point(20, 69);
            this.rbEmpsephar.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmpsephar.Name = "rbEmpsephar";
            this.rbEmpsephar.Size = new System.Drawing.Size(113, 24);
            this.rbEmpsephar.TabIndex = 8;
            this.rbEmpsephar.TabStop = true;
            this.rbEmpsephar.Text = "Empsephar ";
            this.rbEmpsephar.UseVisualStyleBackColor = true;
            // 
            // rbCemefar
            // 
            this.rbCemefar.AutoSize = true;
            this.rbCemefar.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.rbCemefar.Location = new System.Drawing.Point(22, 106);
            this.rbCemefar.Margin = new System.Windows.Forms.Padding(4);
            this.rbCemefar.Name = "rbCemefar";
            this.rbCemefar.Size = new System.Drawing.Size(87, 24);
            this.rbCemefar.TabIndex = 9;
            this.rbCemefar.TabStop = true;
            this.rbCemefar.Text = "Cemefar";
            this.rbCemefar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Location = new System.Drawing.Point(257, 728);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Location = new System.Drawing.Point(73, 728);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(150, 50);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // chbfarmacia_secundaria
            // 
            this.chbfarmacia_secundaria.AutoSize = true;
            this.chbfarmacia_secundaria.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbfarmacia_secundaria.Location = new System.Drawing.Point(175, 467);
            this.chbfarmacia_secundaria.Margin = new System.Windows.Forms.Padding(4);
            this.chbfarmacia_secundaria.Name = "chbfarmacia_secundaria";
            this.chbfarmacia_secundaria.Size = new System.Drawing.Size(173, 24);
            this.chbfarmacia_secundaria.TabIndex = 12;
            this.chbfarmacia_secundaria.Text = "Sucursal Secundaria";
            this.chbfarmacia_secundaria.UseVisualStyleBackColor = true;
            // 
            // chbfarmacia_principal
            // 
            this.chbfarmacia_principal.AutoSize = true;
            this.chbfarmacia_principal.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbfarmacia_principal.Location = new System.Drawing.Point(175, 417);
            this.chbfarmacia_principal.Margin = new System.Windows.Forms.Padding(4);
            this.chbfarmacia_principal.Name = "chbfarmacia_principal";
            this.chbfarmacia_principal.Size = new System.Drawing.Size(161, 24);
            this.chbfarmacia_principal.TabIndex = 11;
            this.chbfarmacia_principal.Text = "Sucursal Principal";
            this.chbfarmacia_principal.UseVisualStyleBackColor = true;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(52, 397);
            this.lblSucursal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(77, 20);
            this.lblSucursal.TabIndex = 10;
            this.lblSucursal.Text = "Sucursal";
            // 
            // lblDistribuidor
            // 
            this.lblDistribuidor.AutoSize = true;
            this.lblDistribuidor.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblDistribuidor.Location = new System.Drawing.Point(52, 215);
            this.lblDistribuidor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistribuidor.Name = "lblDistribuidor";
            this.lblDistribuidor.Size = new System.Drawing.Size(106, 20);
            this.lblDistribuidor.TabIndex = 6;
            this.lblDistribuidor.Text = "Distribuidor";
            // 
            // nDUCantidad
            // 
            this.nDUCantidad.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.nDUCantidad.Location = new System.Drawing.Point(175, 178);
            this.nDUCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nDUCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nDUCantidad.Name = "nDUCantidad";
            this.nDUCantidad.Size = new System.Drawing.Size(251, 26);
            this.nDUCantidad.TabIndex = 5;
            this.nDUCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.Location = new System.Drawing.Point(51, 154);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cbTipoMedicamento
            // 
            this.cbTipoMedicamento.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.cbTipoMedicamento.FormattingEnabled = true;
            this.cbTipoMedicamento.Items.AddRange(new object[] {
            "analgésico",
            "analéptico",
            "anestésico",
            "antiácido",
            "antidepresivo ",
            "antibióticos"});
            this.cbTipoMedicamento.Location = new System.Drawing.Point(175, 112);
            this.cbTipoMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoMedicamento.Name = "cbTipoMedicamento";
            this.cbTipoMedicamento.Size = new System.Drawing.Size(251, 28);
            this.cbTipoMedicamento.TabIndex = 3;
            // 
            // lblTipoMedicamento
            // 
            this.lblTipoMedicamento.AutoSize = true;
            this.lblTipoMedicamento.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblTipoMedicamento.Location = new System.Drawing.Point(48, 84);
            this.lblTipoMedicamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMedicamento.Name = "lblTipoMedicamento";
            this.lblTipoMedicamento.Size = new System.Drawing.Size(176, 20);
            this.lblTipoMedicamento.TabIndex = 2;
            this.lblTipoMedicamento.Text = "Tipo de Medicamento";
            // 
            // txtMedicamento
            // 
            this.txtMedicamento.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.txtMedicamento.Location = new System.Drawing.Point(175, 41);
            this.txtMedicamento.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicamento.MaxLength = 50;
            this.txtMedicamento.Name = "txtMedicamento";
            this.txtMedicamento.Size = new System.Drawing.Size(251, 26);
            this.txtMedicamento.TabIndex = 1;
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(48, 11);
            this.lblMedicamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(112, 20);
            this.lblMedicamento.TabIndex = 0;
            this.lblMedicamento.Text = "Medicamento";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(465, 728);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(280, 50);
            this.btnCancelarPedido.TabIndex = 3;
            this.btnCancelarPedido.Text = "Cancelar Pedido";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(160, 728);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(280, 50);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar Pedido";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // dgGrilla
            // 
            this.dgGrilla.AllowUserToAddRows = false;
            this.dgGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgGrilla.Location = new System.Drawing.Point(27, 41);
            this.dgGrilla.Name = "dgGrilla";
            this.dgGrilla.RowTemplate.Height = 24;
            this.dgGrilla.Size = new System.Drawing.Size(817, 655);
            this.dgGrilla.TabIndex = 16;
            this.dgGrilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGrilla_CellContentClick_2);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::DistriFarmaNet.Properties.Resources.Open_Folder_Delete;
            this.Eliminar.Name = "Eliminar";
            // 
            // lblListado
            // 
            this.lblListado.AutoSize = true;
            this.lblListado.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListado.Location = new System.Drawing.Point(4, 4);
            this.lblListado.Name = "lblListado";
            this.lblListado.Size = new System.Drawing.Size(68, 20);
            this.lblListado.TabIndex = 0;
            this.lblListado.Text = "Listado";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = global::DistriFarmaNet.Properties.Resources.Open_Folder_Delete;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // FormDistriFarma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 788);
            this.Controls.Add(this.SplitControl);
            this.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDistriFarma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DistriFarma Net";
            this.SplitControl.Panel1.ResumeLayout(false);
            this.SplitControl.Panel1.PerformLayout();
            this.SplitControl.Panel2.ResumeLayout(false);
            this.SplitControl.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitControl)).EndInit();
            this.SplitControl.ResumeLayout(false);
            this.gbDistribuidor.ResumeLayout(false);
            this.gbDistribuidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDUCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitControl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chbfarmacia_secundaria;
        private System.Windows.Forms.CheckBox chbfarmacia_principal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.RadioButton rbCemefar;
        private System.Windows.Forms.RadioButton rbEmpsephar;
        private System.Windows.Forms.RadioButton rbCofarma;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.NumericUpDown nDUCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbTipoMedicamento;
        private System.Windows.Forms.Label lblTipoMedicamento;
        private System.Windows.Forms.TextBox txtMedicamento;
        private System.Windows.Forms.Label lblMedicamento;
        private System.Windows.Forms.GroupBox gbDistribuidor;
        private System.Windows.Forms.RichTextBox rtNotas;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.DataGridView dgGrilla;
        private System.Windows.Forms.Label lblListado;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}

