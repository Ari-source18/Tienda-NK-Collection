namespace Sistema_NK
{
    partial class Formdevoluciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            btnmenuprincipal = new Button();
            btnsalir = new Button();
            label11 = new Label();
            btnusuario = new Button();
            btncompras = new Button();
            btnventas = new Button();
            btnproductos = new Button();
            btnproveedores = new Button();
            btncredito = new Button();
            btndevoluciones = new Button();
            btncaja = new Button();
            btnclientes = new Button();
            groupBoxdatos = new GroupBox();
            btnbuscarventa = new Button();
            cmbventa = new ComboBox();
            label3 = new Label();
            txtcliente = new TextBox();
            label2 = new Label();
            txtfactura = new TextBox();
            label1 = new Label();
            btnvalidar = new Button();
            btnprocesar = new Button();
            btnimprimir = new Button();
            groupBoxtipodevolucion = new GroupBox();
            groupBoxnuevoproducto = new GroupBox();
            btnreembolso = new RadioButton();
            btncambio = new RadioButton();
            btnnotadecredito = new RadioButton();
            dataGridViewnuevoproducto = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            groupBoxdatagrid = new GroupBox();
            dataGridViewdevo = new DataGridView();
            columnaproducto = new DataGridViewTextBoxColumn();
            cantvendida = new DataGridViewTextBoxColumn();
            cantdevolver = new DataGridViewTextBoxColumn();
            motivo = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            panel4.SuspendLayout();
            groupBoxdatos.SuspendLayout();
            groupBoxtipodevolucion.SuspendLayout();
            groupBoxnuevoproducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).BeginInit();
            groupBoxdatagrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 0, 0);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(52, 773);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 0, 0);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1195, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(48, 773);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DimGray;
            panel4.Controls.Add(btnmenuprincipal);
            panel4.Controls.Add(btnsalir);
            panel4.Controls.Add(label11);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(52, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1143, 47);
            panel4.TabIndex = 5;
            // 
            // btnmenuprincipal
            // 
            btnmenuprincipal.BackColor = Color.Transparent;
            btnmenuprincipal.FlatStyle = FlatStyle.Flat;
            btnmenuprincipal.Font = new Font("PMingLiU-ExtB", 9F);
            btnmenuprincipal.Location = new Point(11, 7);
            btnmenuprincipal.Name = "btnmenuprincipal";
            btnmenuprincipal.Size = new Size(162, 34);
            btnmenuprincipal.TabIndex = 45;
            btnmenuprincipal.Text = "Menú principal";
            btnmenuprincipal.UseVisualStyleBackColor = false;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.Transparent;
            btnsalir.FlatStyle = FlatStyle.Flat;
            btnsalir.Font = new Font("PMingLiU-ExtB", 9F);
            btnsalir.Location = new Point(1007, 7);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(121, 34);
            btnsalir.TabIndex = 44;
            btnsalir.Text = "Cerrar Sesión";
            btnsalir.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(338, 3);
            label11.Name = "label11";
            label11.Size = new Size(481, 38);
            label11.TabIndex = 43;
            label11.Text = "NK Collection            Devoluciones";
            // 
            // btnusuario
            // 
            btnusuario.BackColor = Color.White;
            btnusuario.FlatAppearance.BorderSize = 0;
            btnusuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnusuario.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnusuario.FlatStyle = FlatStyle.Flat;
            btnusuario.Font = new Font("PMingLiU-ExtB", 10F);
            btnusuario.ForeColor = Color.Black;
            btnusuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnusuario.Location = new Point(62, 53);
            btnusuario.Name = "btnusuario";
            btnusuario.Size = new Size(117, 38);
            btnusuario.TabIndex = 91;
            btnusuario.Text = "Usuarios";
            btnusuario.UseVisualStyleBackColor = false;
            // 
            // btncompras
            // 
            btncompras.BackColor = Color.White;
            btncompras.FlatAppearance.BorderSize = 0;
            btncompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncompras.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncompras.FlatStyle = FlatStyle.Flat;
            btncompras.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncompras.ForeColor = Color.Black;
            btncompras.ImageAlign = ContentAlignment.MiddleLeft;
            btncompras.Location = new Point(308, 53);
            btncompras.Name = "btncompras";
            btncompras.Size = new Size(117, 38);
            btncompras.TabIndex = 90;
            btncompras.Text = "Compras";
            btncompras.UseVisualStyleBackColor = false;
            // 
            // btnventas
            // 
            btnventas.BackColor = Color.MistyRose;
            btnventas.FlatAppearance.BorderSize = 0;
            btnventas.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnventas.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnventas.FlatStyle = FlatStyle.Flat;
            btnventas.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnventas.ForeColor = Color.Black;
            btnventas.ImageAlign = ContentAlignment.MiddleLeft;
            btnventas.Location = new Point(431, 53);
            btnventas.Name = "btnventas";
            btnventas.Size = new Size(117, 38);
            btnventas.TabIndex = 89;
            btnventas.Text = "Ventas";
            btnventas.UseVisualStyleBackColor = false;
            // 
            // btnproductos
            // 
            btnproductos.BackColor = Color.White;
            btnproductos.FlatAppearance.BorderSize = 0;
            btnproductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproductos.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproductos.FlatStyle = FlatStyle.Flat;
            btnproductos.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnproductos.ForeColor = Color.Black;
            btnproductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnproductos.Location = new Point(554, 53);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(117, 38);
            btnproductos.TabIndex = 88;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = false;
            // 
            // btnproveedores
            // 
            btnproveedores.BackColor = Color.MistyRose;
            btnproveedores.FlatAppearance.BorderSize = 0;
            btnproveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnproveedores.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnproveedores.FlatStyle = FlatStyle.Flat;
            btnproveedores.Font = new Font("PMingLiU-ExtB", 10F);
            btnproveedores.ForeColor = Color.Black;
            btnproveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnproveedores.Location = new Point(677, 53);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Size = new Size(117, 38);
            btnproveedores.TabIndex = 87;
            btnproveedores.Text = "Proveedores";
            btnproveedores.UseVisualStyleBackColor = false;
            // 
            // btncredito
            // 
            btncredito.BackColor = Color.White;
            btncredito.FlatAppearance.BorderSize = 0;
            btncredito.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncredito.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncredito.FlatStyle = FlatStyle.Flat;
            btncredito.Font = new Font("PMingLiU-ExtB", 10F);
            btncredito.ForeColor = Color.Black;
            btncredito.ImageAlign = ContentAlignment.MiddleLeft;
            btncredito.Location = new Point(800, 53);
            btncredito.Name = "btncredito";
            btncredito.Size = new Size(117, 38);
            btncredito.TabIndex = 86;
            btncredito.Text = "Crédito";
            btncredito.UseVisualStyleBackColor = false;
            // 
            // btndevoluciones
            // 
            btndevoluciones.BackColor = Color.MistyRose;
            btndevoluciones.FlatAppearance.BorderSize = 0;
            btndevoluciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btndevoluciones.FlatAppearance.MouseOverBackColor = Color.Tan;
            btndevoluciones.FlatStyle = FlatStyle.Flat;
            btndevoluciones.Font = new Font("PMingLiU-ExtB", 10F);
            btndevoluciones.ForeColor = Color.Black;
            btndevoluciones.ImageAlign = ContentAlignment.MiddleLeft;
            btndevoluciones.Location = new Point(923, 53);
            btndevoluciones.Name = "btndevoluciones";
            btndevoluciones.Size = new Size(133, 38);
            btndevoluciones.TabIndex = 85;
            btndevoluciones.Text = "Devoluciones";
            btndevoluciones.UseVisualStyleBackColor = false;
            // 
            // btncaja
            // 
            btncaja.BackColor = Color.White;
            btncaja.FlatAppearance.BorderSize = 0;
            btncaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btncaja.FlatAppearance.MouseOverBackColor = Color.Tan;
            btncaja.FlatStyle = FlatStyle.Flat;
            btncaja.Font = new Font("PMingLiU-ExtB", 10F);
            btncaja.ForeColor = Color.Black;
            btncaja.ImageAlign = ContentAlignment.MiddleLeft;
            btncaja.Location = new Point(1062, 53);
            btncaja.Name = "btncaja";
            btncaja.Size = new Size(117, 38);
            btncaja.TabIndex = 84;
            btncaja.Text = "Caja";
            btncaja.UseVisualStyleBackColor = false;
            // 
            // btnclientes
            // 
            btnclientes.BackColor = Color.MistyRose;
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            btnclientes.FlatAppearance.MouseOverBackColor = Color.Tan;
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("PMingLiU-ExtB", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnclientes.ForeColor = Color.Black;
            btnclientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnclientes.Location = new Point(185, 53);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(117, 38);
            btnclientes.TabIndex = 83;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = false;
            // 
            // groupBoxdatos
            // 
            groupBoxdatos.Controls.Add(btnbuscarventa);
            groupBoxdatos.Controls.Add(cmbventa);
            groupBoxdatos.Controls.Add(label3);
            groupBoxdatos.Controls.Add(txtcliente);
            groupBoxdatos.Controls.Add(label2);
            groupBoxdatos.Controls.Add(txtfactura);
            groupBoxdatos.Controls.Add(label1);
            groupBoxdatos.Location = new Point(64, 108);
            groupBoxdatos.Name = "groupBoxdatos";
            groupBoxdatos.Size = new Size(1125, 74);
            groupBoxdatos.TabIndex = 92;
            groupBoxdatos.TabStop = false;
            // 
            // btnbuscarventa
            // 
            btnbuscarventa.Location = new Point(902, 23);
            btnbuscarventa.Name = "btnbuscarventa";
            btnbuscarventa.Size = new Size(156, 34);
            btnbuscarventa.TabIndex = 86;
            btnbuscarventa.Text = "Buscar Venta";
            btnbuscarventa.UseVisualStyleBackColor = true;
            // 
            // cmbventa
            // 
            cmbventa.FormattingEnabled = true;
            cmbventa.Location = new Point(659, 25);
            cmbventa.Name = "cmbventa";
            cmbventa.Size = new Size(182, 33);
            cmbventa.TabIndex = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(543, 33);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 84;
            label3.Text = "Fecha Venta:";
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(364, 27);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(150, 31);
            txtcliente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(289, 30);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 2;
            label2.Text = "Cliente:";
            // 
            // txtfactura
            // 
            txtfactura.Location = new Point(114, 30);
            txtfactura.Name = "txtfactura";
            txtfactura.Size = new Size(150, 31);
            txtfactura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 27);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "No.Factura:";
            // 
            // btnvalidar
            // 
            btnvalidar.Location = new Point(594, 727);
            btnvalidar.Name = "btnvalidar";
            btnvalidar.Size = new Size(184, 34);
            btnvalidar.TabIndex = 93;
            btnvalidar.Text = "Validar Devolución";
            btnvalidar.UseVisualStyleBackColor = true;
            // 
            // btnprocesar
            // 
            btnprocesar.Location = new Point(784, 727);
            btnprocesar.Name = "btnprocesar";
            btnprocesar.Size = new Size(184, 34);
            btnprocesar.TabIndex = 94;
            btnprocesar.Text = "Procesar Devolución";
            btnprocesar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            btnimprimir.Location = new Point(974, 727);
            btnimprimir.Name = "btnimprimir";
            btnimprimir.Size = new Size(215, 34);
            btnimprimir.TabIndex = 95;
            btnimprimir.Text = "Imprimir Comprobante";
            btnimprimir.UseVisualStyleBackColor = true;
            // 
            // groupBoxtipodevolucion
            // 
            groupBoxtipodevolucion.Controls.Add(btnnotadecredito);
            groupBoxtipodevolucion.Controls.Add(btncambio);
            groupBoxtipodevolucion.Controls.Add(btnreembolso);
            groupBoxtipodevolucion.Location = new Point(84, 416);
            groupBoxtipodevolucion.Name = "groupBoxtipodevolucion";
            groupBoxtipodevolucion.Size = new Size(1038, 77);
            groupBoxtipodevolucion.TabIndex = 96;
            groupBoxtipodevolucion.TabStop = false;
            groupBoxtipodevolucion.Text = "Tipo de Devolución";
            // 
            // groupBoxnuevoproducto
            // 
            groupBoxnuevoproducto.Controls.Add(dataGridViewnuevoproducto);
            groupBoxnuevoproducto.Location = new Point(84, 527);
            groupBoxnuevoproducto.Name = "groupBoxnuevoproducto";
            groupBoxnuevoproducto.Size = new Size(1038, 182);
            groupBoxnuevoproducto.TabIndex = 97;
            groupBoxnuevoproducto.TabStop = false;
            groupBoxnuevoproducto.Text = "Nuevo Producto";
            // 
            // btnreembolso
            // 
            btnreembolso.AutoSize = true;
            btnreembolso.Location = new Point(38, 30);
            btnreembolso.Name = "btnreembolso";
            btnreembolso.Size = new Size(126, 29);
            btnreembolso.TabIndex = 98;
            btnreembolso.TabStop = true;
            btnreembolso.Text = "Reembolso";
            btnreembolso.UseVisualStyleBackColor = true;
            // 
            // btncambio
            // 
            btncambio.AutoSize = true;
            btncambio.Location = new Point(236, 30);
            btncambio.Name = "btncambio";
            btncambio.Size = new Size(203, 29);
            btncambio.TabIndex = 99;
            btncambio.TabStop = true;
            btncambio.Text = "Cambio de producto";
            btncambio.UseVisualStyleBackColor = true;
            // 
            // btnnotadecredito
            // 
            btnnotadecredito.AutoSize = true;
            btnnotadecredito.Location = new Point(510, 30);
            btnnotadecredito.Name = "btnnotadecredito";
            btnnotadecredito.Size = new Size(161, 29);
            btnnotadecredito.TabIndex = 99;
            btnnotadecredito.TabStop = true;
            btnnotadecredito.Text = "Nota de crédito";
            btnnotadecredito.UseVisualStyleBackColor = true;
            // 
            // dataGridViewnuevoproducto
            // 
            dataGridViewnuevoproducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewnuevoproducto.Columns.AddRange(new DataGridViewColumn[] { codigo, producto, cantidad, precio });
            dataGridViewnuevoproducto.Location = new Point(29, 67);
            dataGridViewnuevoproducto.Name = "dataGridViewnuevoproducto";
            dataGridViewnuevoproducto.RowHeadersWidth = 62;
            dataGridViewnuevoproducto.Size = new Size(665, 67);
            dataGridViewnuevoproducto.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 8;
            codigo.Name = "codigo";
            codigo.Width = 150;
            // 
            // producto
            // 
            producto.HeaderText = "Producto";
            producto.MinimumWidth = 8;
            producto.Name = "producto";
            producto.Width = 150;
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.MinimumWidth = 8;
            cantidad.Name = "cantidad";
            cantidad.Width = 150;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 8;
            precio.Name = "precio";
            precio.Width = 150;
            // 
            // groupBoxdatagrid
            // 
            groupBoxdatagrid.Controls.Add(dataGridViewdevo);
            groupBoxdatagrid.Location = new Point(84, 206);
            groupBoxdatagrid.Name = "groupBoxdatagrid";
            groupBoxdatagrid.Size = new Size(1038, 182);
            groupBoxdatagrid.TabIndex = 98;
            groupBoxdatagrid.TabStop = false;
            // 
            // dataGridViewdevo
            // 
            dataGridViewdevo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewdevo.Columns.AddRange(new DataGridViewColumn[] { columnaproducto, cantvendida, cantdevolver, motivo, estado });
            dataGridViewdevo.Location = new Point(19, 68);
            dataGridViewdevo.Name = "dataGridViewdevo";
            dataGridViewdevo.RowHeadersWidth = 62;
            dataGridViewdevo.Size = new Size(814, 67);
            dataGridViewdevo.TabIndex = 0;
            // 
            // columnaproducto
            // 
            columnaproducto.HeaderText = "Producto";
            columnaproducto.MinimumWidth = 8;
            columnaproducto.Name = "columnaproducto";
            columnaproducto.Width = 150;
            // 
            // cantvendida
            // 
            cantvendida.HeaderText = "Cant.Vendida";
            cantvendida.MinimumWidth = 8;
            cantvendida.Name = "cantvendida";
            cantvendida.Width = 150;
            // 
            // cantdevolver
            // 
            cantdevolver.HeaderText = "Cant.Devolver";
            cantdevolver.MinimumWidth = 8;
            cantdevolver.Name = "cantdevolver";
            cantdevolver.Width = 150;
            // 
            // motivo
            // 
            motivo.HeaderText = "Motivo";
            motivo.MinimumWidth = 8;
            motivo.Name = "motivo";
            motivo.Width = 150;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.MinimumWidth = 8;
            estado.Name = "estado";
            estado.Width = 150;
            // 
            // Formdevoluciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 773);
            Controls.Add(groupBoxdatagrid);
            Controls.Add(groupBoxnuevoproducto);
            Controls.Add(groupBoxtipodevolucion);
            Controls.Add(btnimprimir);
            Controls.Add(btnprocesar);
            Controls.Add(btnvalidar);
            Controls.Add(groupBoxdatos);
            Controls.Add(btnusuario);
            Controls.Add(btncompras);
            Controls.Add(btnventas);
            Controls.Add(btnproductos);
            Controls.Add(btnproveedores);
            Controls.Add(btncredito);
            Controls.Add(btndevoluciones);
            Controls.Add(btncaja);
            Controls.Add(btnclientes);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formdevoluciones";
            Text = "Formdevoluciones";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBoxdatos.ResumeLayout(false);
            groupBoxdatos.PerformLayout();
            groupBoxtipodevolucion.ResumeLayout(false);
            groupBoxtipodevolucion.PerformLayout();
            groupBoxnuevoproducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewnuevoproducto).EndInit();
            groupBoxdatagrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewdevo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Button btnmenuprincipal;
        private Button btnsalir;
        private Label label11;
        private Button btnusuario;
        private Button btncompras;
        private Button btnventas;
        private Button btnproductos;
        private Button btnproveedores;
        private Button btncredito;
        private Button btndevoluciones;
        private Button btncaja;
        private Button btnclientes;
        private GroupBox groupBoxdatos;
        private Button btnbuscarventa;
        private ComboBox cmbventa;
        private Label label3;
        private TextBox txtcliente;
        private Label label2;
        private TextBox txtfactura;
        private Label label1;
        private Button btnvalidar;
        private Button btnprocesar;
        private Button btnimprimir;
        private GroupBox groupBoxtipodevolucion;
        private GroupBox groupBoxnuevoproducto;
        private RadioButton btnnotadecredito;
        private RadioButton btncambio;
        private RadioButton btnreembolso;
        private DataGridView dataGridViewnuevoproducto;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private GroupBox groupBoxdatagrid;
        private DataGridView dataGridViewdevo;
        private DataGridViewTextBoxColumn columnaproducto;
        private DataGridViewTextBoxColumn cantvendida;
        private DataGridViewTextBoxColumn cantdevolver;
        private DataGridViewTextBoxColumn motivo;
        private DataGridViewTextBoxColumn estado;
    }
}