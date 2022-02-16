namespace FACT_SC
{
    partial class usuarios
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuarios = new System.Windows.Forms.Button();
            this.btnAgregarUsuarios = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(326, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.apellidos,
            this.email,
            this.rol,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(27, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 275);
            this.dataGridView1.TabIndex = 6;
            // 
            // codigo
            // 
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            // 
            // password
            // 
            this.password.HeaderText = "Contraseña";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "USUARIOS";
            // 
            // btnAtras
            // 
            this.btnAtras.BackgroundImage = global::FACT_SC.Properties.Resources.icoAtras;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(599, 9);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(43, 45);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Tag = "";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackgroundImage = global::FACT_SC.Properties.Resources.icoModificar;
            this.btnModificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Location = new System.Drawing.Point(227, 81);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(64, 39);
            this.btnModificarUsuario.TabIndex = 12;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUsuarios
            // 
            this.btnEliminarUsuarios.BackgroundImage = global::FACT_SC.Properties.Resources.icoEliminar;
            this.btnEliminarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnEliminarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuarios.Location = new System.Drawing.Point(130, 81);
            this.btnEliminarUsuarios.Name = "btnEliminarUsuarios";
            this.btnEliminarUsuarios.Size = new System.Drawing.Size(64, 39);
            this.btnEliminarUsuarios.TabIndex = 11;
            this.btnEliminarUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnAgregarUsuarios
            // 
            this.btnAgregarUsuarios.BackgroundImage = global::FACT_SC.Properties.Resources.icoAgregar;
            this.btnAgregarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsuarios.Location = new System.Drawing.Point(27, 81);
            this.btnAgregarUsuarios.Name = "btnAgregarUsuarios";
            this.btnAgregarUsuarios.Size = new System.Drawing.Size(64, 39);
            this.btnAgregarUsuarios.TabIndex = 7;
            this.btnAgregarUsuarios.UseVisualStyleBackColor = true;
            this.btnAgregarUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::FACT_SC.Properties.Resources.icoBuscador;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(472, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 446);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnEliminarUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarUsuarios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.Button btnAgregarUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarUsuarios;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnAtras;
    }
}