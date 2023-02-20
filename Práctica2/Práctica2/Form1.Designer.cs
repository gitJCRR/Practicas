
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
            this.clbIdiomas = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picfoto)).BeginInit();
            this.gbfoto.SuspendLayout();
            this.gbidiomas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btninsertar
            // 
            this.btninsertar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninsertar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btninsertar.Location = new System.Drawing.Point(17, 148);
            this.btninsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(127, 24);
            this.btninsertar.TabIndex = 0;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // btnborrarlista
            // 
            this.btnborrarlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrarlista.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnborrarlista.Location = new System.Drawing.Point(119, 192);
            this.btnborrarlista.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnborrarlista.Name = "btnborrarlista";
            this.btnborrarlista.Size = new System.Drawing.Size(128, 33);
            this.btnborrarlista.TabIndex = 2;
            this.btnborrarlista.Text = "Borrar la lista";
            this.btnborrarlista.UseVisualStyleBackColor = true;
            this.btnborrarlista.Click += new System.EventHandler(this.btnborrarlista_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnborrar.Location = new System.Drawing.Point(10, 192);
            this.btnborrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(97, 33);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnanadir
            // 
            this.btnanadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanadir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnanadir.Location = new System.Drawing.Point(10, 152);
            this.btnanadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnanadir.Name = "btnanadir";
            this.btnanadir.Size = new System.Drawing.Size(97, 33);
            this.btnanadir.TabIndex = 4;
            this.btnanadir.Text = "Añadir";
            this.btnanadir.UseVisualStyleBackColor = true;
            this.btnanadir.Click += new System.EventHandler(this.btnanadir_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Location = new System.Drawing.Point(368, 380);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(97, 33);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnsobre
            // 
            this.btnsobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsobre.Location = new System.Drawing.Point(368, 342);
            this.btnsobre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsobre.Name = "btnsobre";
            this.btnsobre.Size = new System.Drawing.Size(97, 33);
            this.btnsobre.TabIndex = 6;
            this.btnsobre.Text = "Sobre";
            this.btnsobre.UseVisualStyleBackColor = true;
            this.btnsobre.Click += new System.EventHandler(this.btnsobre_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.Location = new System.Drawing.Point(368, 305);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(97, 33);
            this.btnlimpiar.TabIndex = 7;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnvalidar
            // 
            this.btnvalidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvalidar.Location = new System.Drawing.Point(368, 268);
            this.btnvalidar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(97, 33);
            this.btnvalidar.TabIndex = 8;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnregistrar.Location = new System.Drawing.Point(368, 231);
            this.btnregistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(97, 33);
            this.btnregistrar.TabIndex = 9;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // picfoto
            // 
            this.picfoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picfoto.Location = new System.Drawing.Point(17, 28);
            this.picfoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picfoto.Name = "picfoto";
            this.picfoto.Size = new System.Drawing.Size(127, 109);
            this.picfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfoto.TabIndex = 10;
            this.picfoto.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(21, 75);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(163, 22);
            this.txtnombre.TabIndex = 11;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(21, 127);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(236, 22);
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
            this.cbciudad.Location = new System.Drawing.Point(21, 178);
            this.cbciudad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbciudad.Name = "cbciudad";
            this.cbciudad.Size = new System.Drawing.Size(145, 24);
            this.cbciudad.TabIndex = 13;
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbnombre.Location = new System.Drawing.Point(17, 57);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(64, 17);
            this.lbnombre.TabIndex = 14;
            this.lbnombre.Text = "Nombre";
            // 
            // lbdireccion
            // 
            this.lbdireccion.AutoSize = true;
            this.lbdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdireccion.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbdireccion.Location = new System.Drawing.Point(17, 109);
            this.lbdireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbdireccion.Name = "lbdireccion";
            this.lbdireccion.Size = new System.Drawing.Size(76, 17);
            this.lbdireccion.TabIndex = 15;
            this.lbdireccion.Text = "Dirección";
            // 
            // lbciudad
            // 
            this.lbciudad.AutoSize = true;
            this.lbciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbciudad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbciudad.Location = new System.Drawing.Point(17, 160);
            this.lbciudad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbciudad.Name = "lbciudad";
            this.lbciudad.Size = new System.Drawing.Size(58, 17);
            this.lbciudad.TabIndex = 16;
            this.lbciudad.Text = "Ciudad";
            // 
            // lbfichapersonal
            // 
            this.lbfichapersonal.AutoSize = true;
            this.lbfichapersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbfichapersonal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbfichapersonal.Location = new System.Drawing.Point(8, 6);
            this.lbfichapersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbfichapersonal.Name = "lbfichapersonal";
            this.lbfichapersonal.Size = new System.Drawing.Size(188, 29);
            this.lbfichapersonal.TabIndex = 17;
            this.lbfichapersonal.Text = "Ficha Personal";
            // 
            // gbfoto
            // 
            this.gbfoto.Controls.Add(this.picfoto);
            this.gbfoto.Controls.Add(this.btninsertar);
            this.gbfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbfoto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbfoto.Location = new System.Drawing.Point(331, 17);
            this.gbfoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbfoto.Name = "gbfoto";
            this.gbfoto.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbfoto.Size = new System.Drawing.Size(160, 189);
            this.gbfoto.TabIndex = 19;
            this.gbfoto.TabStop = false;
            this.gbfoto.Text = "Foto";
            // 
            // gbidiomas
            // 
            this.gbidiomas.Controls.Add(this.clbIdiomas);
            this.gbidiomas.Controls.Add(this.txtidioma);
            this.gbidiomas.Controls.Add(this.btnanadir);
            this.gbidiomas.Controls.Add(this.btnborrar);
            this.gbidiomas.Controls.Add(this.btnborrarlista);
            this.gbidiomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbidiomas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.gbidiomas.Location = new System.Drawing.Point(21, 211);
            this.gbidiomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbidiomas.Name = "gbidiomas";
            this.gbidiomas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbidiomas.Size = new System.Drawing.Size(303, 240);
            this.gbidiomas.TabIndex = 20;
            this.gbidiomas.TabStop = false;
            this.gbidiomas.Text = "Idiomas";
            // 
            // txtidioma
            // 
            this.txtidioma.Location = new System.Drawing.Point(119, 159);
            this.txtidioma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtidioma.Name = "txtidioma";
            this.txtidioma.Size = new System.Drawing.Size(166, 22);
            this.txtidioma.TabIndex = 5;
            // 
            // clbIdiomas
            // 
            this.clbIdiomas.FormattingEnabled = true;
            this.clbIdiomas.Location = new System.Drawing.Point(10, 29);
            this.clbIdiomas.Name = "clbIdiomas";
            this.clbIdiomas.Size = new System.Drawing.Size(275, 89);
            this.clbIdiomas.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 494);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.CheckedListBox clbIdiomas;
    }
}

