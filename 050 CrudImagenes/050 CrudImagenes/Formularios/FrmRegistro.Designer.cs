
namespace _050_CrudImagenes.Formularios
{
    partial class FrmRegistro
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSinFoto = new System.Windows.Forms.Button();
            this.btnSubir = new System.Windows.Forms.Button();
            this.picImgPersona = new System.Windows.Forms.PictureBox();
            this.dtpFechaNaci = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApematerno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opdImagen = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImgPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtpFechaNaci);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApematerno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApePaterno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(315, 188);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 19;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSinFoto);
            this.groupBox2.Controls.Add(this.btnSubir);
            this.groupBox2.Controls.Add(this.picImgPersona);
            this.groupBox2.Location = new System.Drawing.Point(36, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 115);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // btnSinFoto
            // 
            this.btnSinFoto.Location = new System.Drawing.Point(96, 86);
            this.btnSinFoto.Name = "btnSinFoto";
            this.btnSinFoto.Size = new System.Drawing.Size(75, 23);
            this.btnSinFoto.TabIndex = 19;
            this.btnSinFoto.Text = "Sin foto";
            this.btnSinFoto.UseVisualStyleBackColor = true;
            this.btnSinFoto.Click += new System.EventHandler(this.btnSinFoto_Click);
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(15, 86);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(75, 23);
            this.btnSubir.TabIndex = 18;
            this.btnSubir.Text = "Subir";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // picImgPersona
            // 
            this.picImgPersona.InitialImage = null;
            this.picImgPersona.Location = new System.Drawing.Point(36, 18);
            this.picImgPersona.Name = "picImgPersona";
            this.picImgPersona.Size = new System.Drawing.Size(115, 62);
            this.picImgPersona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImgPersona.TabIndex = 17;
            this.picImgPersona.TabStop = false;
            // 
            // dtpFechaNaci
            // 
            this.dtpFechaNaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNaci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNaci.Location = new System.Drawing.Point(169, 186);
            this.dtpFechaNaci.MaxDate = new System.DateTime(2021, 6, 28, 21, 53, 27, 132);
            this.dtpFechaNaci.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNaci.Name = "dtpFechaNaci";
            this.dtpFechaNaci.Size = new System.Drawing.Size(104, 23);
            this.dtpFechaNaci.TabIndex = 16;
            this.dtpFechaNaci.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha nacimiento:";
            // 
            // txtApematerno
            // 
            this.txtApematerno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApematerno.Location = new System.Drawing.Point(691, 134);
            this.txtApematerno.Name = "txtApematerno";
            this.txtApematerno.Size = new System.Drawing.Size(138, 23);
            this.txtApematerno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Materno";
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApePaterno.Location = new System.Drawing.Point(410, 134);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(138, 23);
            this.txtApePaterno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(101, 134);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 289);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegistro";
            this.Text = "FrmRegistro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImgPersona)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.PictureBox picImgPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaNaci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApematerno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSinFoto;
        private System.Windows.Forms.OpenFileDialog opdImagen;
    }
}