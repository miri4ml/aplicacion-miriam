
namespace aplicacion_miriam
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttoningresar = new System.Windows.Forms.Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textcontra = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESA AL SISTEMA";
            // 
            // buttoningresar
            // 
            this.buttoningresar.BackColor = System.Drawing.Color.Beige;
            this.buttoningresar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoningresar.ForeColor = System.Drawing.Color.Tan;
            this.buttoningresar.Location = new System.Drawing.Point(324, 270);
            this.buttoningresar.Name = "buttoningresar";
            this.buttoningresar.Size = new System.Drawing.Size(89, 23);
            this.buttoningresar.TabIndex = 1;
            this.buttoningresar.Text = "INGRESAR";
            this.buttoningresar.UseVisualStyleBackColor = false;
            this.buttoningresar.Click += new System.EventHandler(this.buttoningresar_Click);
            // 
            // textname
            // 
            this.textname.BackColor = System.Drawing.Color.Beige;
            this.textname.Location = new System.Drawing.Point(161, 119);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(198, 20);
            this.textname.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::aplicacion_miriam.Properties.Resources._3741756_bussiness_ecommerce_marketplace_onlinestore_store_user_108907;
            this.pictureBox1.Location = new System.Drawing.Point(58, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textcontra
            // 
            this.textcontra.BackColor = System.Drawing.Color.Beige;
            this.textcontra.Location = new System.Drawing.Point(161, 198);
            this.textcontra.Name = "textcontra";
            this.textcontra.Size = new System.Drawing.Size(198, 20);
            this.textcontra.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::aplicacion_miriam.Properties.Resources.mbrilock_99595__1_;
            this.pictureBox2.Location = new System.Drawing.Point(58, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // buttonsalir
            // 
            this.buttonsalir.BackColor = System.Drawing.Color.Beige;
            this.buttonsalir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsalir.ForeColor = System.Drawing.Color.Tan;
            this.buttonsalir.Location = new System.Drawing.Point(196, 270);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(89, 23);
            this.buttonsalir.TabIndex = 7;
            this.buttonsalir.Text = "SALIR";
            this.buttonsalir.UseVisualStyleBackColor = false;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = global::aplicacion_miriam.Properties.Resources._281b3ac7638a0e17b2dbf6f86cdd10c6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(451, 335);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textcontra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.buttoningresar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttoningresar;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textcontra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonsalir;
    }
}

