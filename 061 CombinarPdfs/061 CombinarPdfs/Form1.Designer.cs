
namespace _061_CombinarPdfs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSelecionaPdf1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSelecionaPdf2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnSelecionaPdf1
            // 
            this.btnSelecionaPdf1.Location = new System.Drawing.Point(371, 87);
            this.btnSelecionaPdf1.Name = "btnSelecionaPdf1";
            this.btnSelecionaPdf1.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaPdf1.TabIndex = 1;
            this.btnSelecionaPdf1.Text = "...";
            this.btnSelecionaPdf1.UseVisualStyleBackColor = true;
            this.btnSelecionaPdf1.Click += new System.EventHandler(this.btnSelecionaPdf1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(252, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // btnSelecionaPdf2
            // 
            this.btnSelecionaPdf2.Location = new System.Drawing.Point(371, 132);
            this.btnSelecionaPdf2.Name = "btnSelecionaPdf2";
            this.btnSelecionaPdf2.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionaPdf2.TabIndex = 4;
            this.btnSelecionaPdf2.Text = "...";
            this.btnSelecionaPdf2.UseVisualStyleBackColor = true;
            this.btnSelecionaPdf2.Click += new System.EventHandler(this.btnSelecionaPdf2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Unir pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelecionaPdf2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnSelecionaPdf1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSelecionaPdf1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSelecionaPdf2;
        private System.Windows.Forms.Button button1;
    }
}

