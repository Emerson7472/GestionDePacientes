namespace GestionDePacientes
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatos = new System.Windows.Forms.GroupBox();
            btnLimpiar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnActualizar = new System.Windows.Forms.Button();
            btnRegistrar = new System.Windows.Forms.Button();
            dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            lblFecha = new System.Windows.Forms.Label();
            cmbEstado = new System.Windows.Forms.ComboBox();
            lblEstado = new System.Windows.Forms.Label();
            txtDiagnostico = new System.Windows.Forms.TextBox();
            lblDiagnostico = new System.Windows.Forms.Label();
            cmbSexo = new System.Windows.Forms.ComboBox();
            lblSexo = new System.Windows.Forms.Label();
            txtEdad = new System.Windows.Forms.TextBox();
            lblEdad = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            lblNombre = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblId = new System.Windows.Forms.Label();
            grpBusqueda = new System.Windows.Forms.GroupBox();
            btnListarTodos = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtBuscar = new System.Windows.Forms.TextBox();
            lblBuscar = new System.Windows.Forms.Label();
            dgvPacientes = new System.Windows.Forms.DataGridView();
            btnSalir = new System.Windows.Forms.Button();
            grpDatos.SuspendLayout();
            grpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(btnLimpiar);
            grpDatos.Controls.Add(btnEliminar);
            grpDatos.Controls.Add(btnActualizar);
            grpDatos.Controls.Add(btnRegistrar);
            grpDatos.Controls.Add(dtpFechaIngreso);
            grpDatos.Controls.Add(lblFecha);
            grpDatos.Controls.Add(cmbEstado);
            grpDatos.Controls.Add(lblEstado);
            grpDatos.Controls.Add(txtDiagnostico);
            grpDatos.Controls.Add(lblDiagnostico);
            grpDatos.Controls.Add(cmbSexo);
            grpDatos.Controls.Add(lblSexo);
            grpDatos.Controls.Add(txtEdad);
            grpDatos.Controls.Add(lblEdad);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtId);
            grpDatos.Controls.Add(lblId);
            grpDatos.Font = new System.Drawing.Font("Segoe UI", 9F);
            grpDatos.Location = new System.Drawing.Point(14, 16);
            grpDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpDatos.Size = new System.Drawing.Size(366, 640);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = " Datos del Paciente ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(189, 507);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(154, 40);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new System.Drawing.Point(17, 507);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(154, 40);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new System.Drawing.Point(189, 447);
            btnActualizar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new System.Drawing.Size(154, 40);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new System.Drawing.Point(17, 447);
            btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(154, 40);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new System.Drawing.Point(126, 387);
            dtpFechaIngreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new System.Drawing.Size(217, 27);
            dtpFechaIngreso.TabIndex = 7;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new System.Drawing.Point(17, 391);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new System.Drawing.Size(103, 20);
            lblFecha.TabIndex = 12;
            lblFecha.Text = "Fecha Ingreso:";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new System.Drawing.Point(126, 333);
            cmbEstado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new System.Drawing.Size(217, 28);
            cmbEstado.TabIndex = 6;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new System.Drawing.Point(17, 337);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new System.Drawing.Size(57, 20);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new System.Drawing.Point(126, 249);
            txtDiagnostico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDiagnostico.Multiline = true;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new System.Drawing.Size(217, 65);
            txtDiagnostico.TabIndex = 5;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new System.Drawing.Point(17, 253);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new System.Drawing.Size(92, 20);
            lblDiagnostico.TabIndex = 14;
            lblDiagnostico.Text = "Diagnóstico:";
            // 
            // cmbSexo
            // 
            cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new System.Drawing.Point(126, 196);
            cmbSexo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new System.Drawing.Size(217, 28);
            cmbSexo.TabIndex = 4;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new System.Drawing.Point(17, 200);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new System.Drawing.Size(44, 20);
            lblSexo.TabIndex = 15;
            lblSexo.Text = "Sexo:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new System.Drawing.Point(126, 143);
            txtEdad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new System.Drawing.Size(217, 27);
            txtEdad.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new System.Drawing.Point(17, 147);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new System.Drawing.Size(46, 20);
            lblEdad.TabIndex = 16;
            lblEdad.Text = "Edad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(126, 89);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(217, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(17, 93);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(67, 20);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(126, 36);
            txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(217, 27);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(17, 40);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(87, 20);
            lblId.TabIndex = 18;
            lblId.Text = "ID / Cédula:";
            // 
            // grpBusqueda
            // 
            grpBusqueda.Controls.Add(btnListarTodos);
            grpBusqueda.Controls.Add(btnBuscar);
            grpBusqueda.Controls.Add(txtBuscar);
            grpBusqueda.Controls.Add(lblBuscar);
            grpBusqueda.Font = new System.Drawing.Font("Segoe UI", 9F);
            grpBusqueda.Location = new System.Drawing.Point(398, 16);
            grpBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpBusqueda.Name = "grpBusqueda";
            grpBusqueda.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            grpBusqueda.Size = new System.Drawing.Size(686, 87);
            grpBusqueda.TabIndex = 1;
            grpBusqueda.TabStop = false;
            grpBusqueda.Text = " Consultar Pacientes ";
            // 
            // btnListarTodos
            // 
            btnListarTodos.Location = new System.Drawing.Point(554, 29);
            btnListarTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnListarTodos.Name = "btnListarTodos";
            btnListarTodos.Size = new System.Drawing.Size(114, 35);
            btnListarTodos.TabIndex = 3;
            btnListarTodos.Text = "Ver Todos";
            btnListarTodos.UseVisualStyleBackColor = true;
            btnListarTodos.Click += btnListarTodos_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new System.Drawing.Point(434, 29);
            btnBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(109, 35);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(120, 32);
            txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(297, 27);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new System.Drawing.Point(17, 36);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new System.Drawing.Size(99, 20);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "ID o Nombre:";
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new System.Drawing.Point(398, 113);
            dgvPacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPacientes.MultiSelect = false;
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPacientes.Size = new System.Drawing.Size(686, 480);
            dgvPacientes.TabIndex = 2;
            dgvPacientes.CellClick += dgvPacientes_CellClick;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSalir.Location = new System.Drawing.Point(946, 607);
            btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(137, 47);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir del Sistema";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1099, 669);
            Controls.Add(btnSalir);
            Controls.Add(dgvPacientes);
            Controls.Add(grpBusqueda);
            Controls.Add(grpDatos);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Sistema de Gestión de Pacientes - Centro medico UCE";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            grpBusqueda.ResumeLayout(false);
            grpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListarTodos;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnSalir;
    }
}