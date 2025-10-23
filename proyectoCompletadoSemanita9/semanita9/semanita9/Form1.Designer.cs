namespace semanita9
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxNid = new System.Windows.Forms.TextBox();
            this.labelNid = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.labelNombres = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Estudiantes";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.textBoxCorreo);
            this.groupBox2.Controls.Add(this.labelCorreo);
            this.groupBox2.Controls.Add(this.textBoxNid);
            this.groupBox2.Controls.Add(this.labelNid);
            this.groupBox2.Controls.Add(this.textBoxApellidos);
            this.groupBox2.Controls.Add(this.labelApellidos);
            this.groupBox2.Controls.Add(this.textBoxNombres);
            this.groupBox2.Controls.Add(this.labelNombres);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(2, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 401);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(86, 258);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(178, 26);
            this.textBoxCorreo.TabIndex = 10;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            this.textBoxCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCorreo_KeyPress);
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCorreo.Location = new System.Drawing.Point(10, 260);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(64, 18);
            this.labelCorreo.TabIndex = 9;
            this.labelCorreo.Text = "Correo";
            this.labelCorreo.Click += new System.EventHandler(this.labelCorreo_Click);
            // 
            // textBoxNid
            // 
            this.textBoxNid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNid.Location = new System.Drawing.Point(86, 305);
            this.textBoxNid.Name = "textBoxNid";
            this.textBoxNid.Size = new System.Drawing.Size(178, 26);
            this.textBoxNid.TabIndex = 8;
            this.textBoxNid.TextChanged += new System.EventHandler(this.textBoxNid_TextChanged);
            this.textBoxNid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNid_KeyPress);
            // 
            // labelNid
            // 
            this.labelNid.AutoSize = true;
            this.labelNid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNid.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelNid.Location = new System.Drawing.Point(22, 307);
            this.labelNid.Name = "labelNid";
            this.labelNid.Size = new System.Drawing.Size(34, 18);
            this.labelNid.TabIndex = 7;
            this.labelNid.Text = "Nid";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxApellidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidos.Location = new System.Drawing.Point(86, 211);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(178, 26);
            this.textBoxApellidos.TabIndex = 6;
            this.textBoxApellidos.TextChanged += new System.EventHandler(this.textBoxApellidos_TextChanged);
            this.textBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidos_KeyPress);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelApellidos.Location = new System.Drawing.Point(4, 213);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(81, 18);
            this.labelApellidos.TabIndex = 5;
            this.labelApellidos.Text = "Apellidos";
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombres.Location = new System.Drawing.Point(86, 166);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(178, 26);
            this.textBoxNombres.TabIndex = 4;
            this.textBoxNombres.TextChanged += new System.EventHandler(this.textBoxNombres_TextChanged);
            this.textBoxNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombres_KeyPress);
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.ForeColor = System.Drawing.Color.GhostWhite;
            this.labelNombres.Location = new System.Drawing.Point(4, 168);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(80, 18);
            this.labelNombres.TabIndex = 3;
            this.labelNombres.Text = "Nombres";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBoxImage);
            this.groupBox5.Location = new System.Drawing.Point(72, 37);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Informacion del estudiante";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.Thistle;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(298, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 401);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(161, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lista de estudiantes";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.Thistle;
            this.groupBox4.Controls.Add(this.textBoxBuscar);
            this.groupBox4.Controls.Add(this.labelBuscar);
            this.groupBox4.Location = new System.Drawing.Point(2, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(681, 75);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuscar.Location = new System.Drawing.Point(86, 30);
            this.textBoxBuscar.Multiline = true;
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(595, 18);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.DeepPink;
            this.labelBuscar.Location = new System.Drawing.Point(10, 30);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(75, 18);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Buscar: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Pink;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::semanita9.Properties.Resources.cancelar;
            this.button3.Location = new System.Drawing.Point(195, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 31);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::semanita9.Properties.Resources.eliminar;
            this.button2.Location = new System.Drawing.Point(99, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 31);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Pink;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::semanita9.Properties.Resources.Add;
            this.btnAgregar.Location = new System.Drawing.Point(6, 354);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 31);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxImage.Image = global::semanita9.Properties.Resources.logo_del_proyecto_semana_9;
            this.pictureBoxImage.Location = new System.Drawing.Point(6, 13);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(100, 81);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::semanita9.Properties.Resources._1_logo_design;
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de estudiantes ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxNid;
        private System.Windows.Forms.Label labelNid;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

