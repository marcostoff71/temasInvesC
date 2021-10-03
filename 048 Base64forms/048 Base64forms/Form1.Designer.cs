
namespace _048_Base64forms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCargaImagen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCargaImagenBase64 = new System.Windows.Forms.Button();
            this.btnImageSaveBase64 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(70, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCargaImagen
            // 
            this.btnCargaImagen.Location = new System.Drawing.Point(103, 209);
            this.btnCargaImagen.Name = "btnCargaImagen";
            this.btnCargaImagen.Size = new System.Drawing.Size(174, 23);
            this.btnCargaImagen.TabIndex = 1;
            this.btnCargaImagen.Text = "Cargar imagen";
            this.btnCargaImagen.UseVisualStyleBackColor = true;
            this.btnCargaImagen.Click += new System.EventHandler(this.btnCargaImagen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnCargaImagenBase64
            // 
            this.btnCargaImagenBase64.Location = new System.Drawing.Point(448, 73);
            this.btnCargaImagenBase64.Name = "btnCargaImagenBase64";
            this.btnCargaImagenBase64.Size = new System.Drawing.Size(174, 23);
            this.btnCargaImagenBase64.TabIndex = 3;
            this.btnCargaImagenBase64.Text = "Cargar imagen de base 64";
            this.btnCargaImagenBase64.UseVisualStyleBackColor = true;
            // 
            // btnImageSaveBase64
            // 
            this.btnImageSaveBase64.Location = new System.Drawing.Point(103, 238);
            this.btnImageSaveBase64.Name = "btnImageSaveBase64";
            this.btnImageSaveBase64.Size = new System.Drawing.Size(174, 23);
            this.btnImageSaveBase64.TabIndex = 4;
            this.btnImageSaveBase64.Text = "Guardar imagen a base64";
            this.btnImageSaveBase64.UseVisualStyleBackColor = true;
            this.btnImageSaveBase64.Click += new System.EventHandler(this.btnImageSaveBase64_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImageSaveBase64);
            this.Controls.Add(this.btnCargaImagenBase64);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCargaImagen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCargaImagen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCargaImagenBase64;
        private System.Windows.Forms.Button btnImageSaveBase64;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

