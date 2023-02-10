
namespace Práctica2
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
            this.btninsertar = new System.Windows.Forms.Button();
            this.btnborrarlista = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnanadir = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnsobre = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.picfoto = new System.Windows.Forms.PictureBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.cbciudad = new System.Windows.Forms.ComboBox();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbdireccion = new System.Windows.Forms.Label();
            this.lbciudad = new System.Windows.Forms.Label();
            this.lbfichapersonal = new System.Windows.Forms.Label();
            this.gbfoto = new System.Windows.Forms.GroupBox();
            this.gbidiomas = new System.Windows.Forms.GroupBox();
            this.txtidioma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.gbfoto.SuspendLayout();
            this.gbidiomas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninsertar
            // 
            this.btninsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsertar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btninsertar.Location = new System.Drawing.Point(25, 232);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(190, 38);
            this.btninsertar.TabIndex = 0;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnborrarlista
            // 
            this.btnborrarlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrarlista.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnborrarlista.Location = new System.Drawing.Point(179, 300);
            this.btnborrarlista.Name = "btnborrarlista";
            this.btnborrarlista.Size = new System.Drawing.Size(192, 52);
            this.btnborrarlista.TabIndex = 2;
            this.btnborrarlista.Text = "Borrar la lista";
            this.btnborrarlista.UseVisualStyleBackColor = true;
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnborrar.Location = new System.Drawing.Point(15, 300);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(145, 52);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // btnanadir
            // 
            this.btnanadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanadir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnanadir.Location = new System.Drawing.Point(15, 237);
            this.btnanadir.Name = "btnanadir";
            this.btnanadir.Size = new System.Drawing.Size(145, 52);
            this.btnanadir.TabIndex = 4;
            this.btnanadir.Text = "Añadir";
            this.btnanadir.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Location = new System.Drawing.Point(552, 593);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(145, 52);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnsobre
            // 
            this.btnsobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsobre.Location = new System.Drawing.Point(552, 535);
            this.btnsobre.Name = "btnsobre";
            this.btnsobre.Size = new System.Drawing.Size(145, 52);
            this.btnsobre.TabIndex = 6;
            this.btnsobre.Text = "Sobre";
            this.btnsobre.UseVisualStyleBackColor = true;
            this.btnsobre.Click += new System.EventHandler(this.btnsobre_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.Location = new System.Drawing.Point(552, 477);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(145, 52);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnvalidar
            // 
            this.btnvalidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalidar.Location = new System.Drawing.Point(552, 419);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(145, 52);
            this.btnvalidar.TabIndex = 8;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.Location = new System.Drawing.Point(552, 361);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(145, 52);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // picfoto
            // 
            this.picfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picfoto.Location = new System.Drawing.Point(25, 43);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(190, 169);
            this.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfoto.TabIndex = 10;
            this.picfoto.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(31, 117);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(243, 31);
            this.txtnombre.TabIndex = 11;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(31, 198);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(352, 31);
            this.txtdireccion.TabIndex = 12;
            // 
            // cbciudad
            // 
            this.cbciudad.FormattingEnabled = true;
            this.cbciudad.Items.AddRange(new object[] {
            "Alicante",
            "Barcelona",
            "Madrid",
            "Murcia",
            "Zaragoza"});
            this.cbciudad.Location = new System.Drawing.Point(31, 278);
            this.cbciudad.Name = "cbciudad";
            this.cbciudad.Size = new System.Drawing.Size(216, 33);
            this.cbciudad.TabIndex = 13;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbnombre.Location = new System.Drawing.Point(26, 89);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(93, 25);
            this.lbnombre.TabIndex = 14;
            this.lbnombre.Text = "Nombre";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbdireccion.Location = new System.Drawing.Point(26, 170);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(111, 25);
            this.lbdireccion.TabIndex = 15;
            this.lbdireccion.Text = "Dirección";
            // 
            // lbciudad
            // 
            this.lbciudad.AutoSize = true;
            this.lbciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbciudad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbciudad.Location = new System.Drawing.Point(26, 250);
            this.lbciudad.Name = "lbciudad";
            this.lbciudad.Size = new System.Drawing.Size(86, 25);
            this.lbciudad.TabIndex = 16;
            this.lbciudad.Text = "Ciudad";
            // 
            // lbfichapersonal
            // 
            this.lbfichapersonal.AutoSize = true;
            this.lbfichapersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfichapersonal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbfichapersonal.Location = new System.Drawing.Point(12, 9);
            this.lbfichapersonal.Name = "lbfichapersonal";
            this.lbfichapersonal.Size = new System.Drawing.Size(282, 42);
            this.lbfichapersonal.TabIndex = 17;
            this.lbfichapersonal.Text = "Ficha Personal";
            // 
            // gbfoto
            // 
            this.gbfoto.Controls.Add(this.picfoto);
            this.gbfoto.Controls.Add(this.btninsertar);
            this.gbfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfoto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbfoto.Location = new System.Drawing.Point(497, 27);
            this.gbfoto.Name = "gbfoto";
            this.gbfoto.Size = new System.Drawing.Size(240, 295);
            this.gbfoto.TabIndex = 19;
            this.gbfoto.TabStop = false;
            this.gbfoto.Text = "Foto";
            this.gbfoto.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbidiomas
            // 
            this.gbidiomas.Controls.Add(this.txtidioma);
            this.gbidiomas.Controls.Add(this.btnanadir);
            this.gbidiomas.Controls.Add(this.btnborrar);
            this.gbidiomas.Controls.Add(this.btnborrarlista);
            this.gbidiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbidiomas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbidiomas.Location = new System.Drawing.Point(31, 330);
            this.gbidiomas.Name = "gbidiomas";
            this.gbidiomas.Size = new System.Drawing.Size(454, 375);
            this.gbidiomas.TabIndex = 20;
            this.gbidiomas.TabStop = false;
            this.gbidiomas.Text = "Idiomas";
            // 
            // txtidioma
            // 
            this.txtidioma.Location = new System.Drawing.Point(179, 248);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.Size = new System.Drawing.Size(247, 31);
            this.txtidioma.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 772);
            this.Controls.Add(this.gbidiomas);
            this.Controls.Add(this.gbfoto);
            this.Controls.Add(this.lbfichapersonal);
            this.Controls.Add(this.lbciudad);
            this.Controls.Add(this.lbdireccion);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.cbciudad);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsobre);
            this.Controls.Add(this.btnsalir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).EndInit();
            this.gbfoto.ResumeLayout(false);
            this.gbidiomas.ResumeLayout(false);
            this.gbidiomas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.Button btnborrarlista;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnanadir;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnsobre;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.PictureBox picfoto;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ComboBox cbciudad;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbdireccion;
        private System.Windows.Forms.Label lbciudad;
        private System.Windows.Forms.Label lbfichapersonal;
        private System.Windows.Forms.GroupBox gbfoto;
        private System.Windows.Forms.GroupBox gbidiomas;
        private System.Windows.Forms.TextBox txtidioma;
    }
}

