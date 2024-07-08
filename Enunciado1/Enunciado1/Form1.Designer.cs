namespace Enunciado1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstDesordenado = new System.Windows.Forms.ListBox();
            this.lstOrdenado = new System.Windows.Forms.ListBox();
            this.btnOrdenarArray = new System.Windows.Forms.Button();
            this.btnIngresarDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(13, 52);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(994, 29);
            this.txtInput.TabIndex = 0;
            // 
            // lstDesordenado
            // 
            this.lstDesordenado.FormattingEnabled = true;
            this.lstDesordenado.ItemHeight = 24;
            this.lstDesordenado.Location = new System.Drawing.Point(13, 132);
            this.lstDesordenado.Margin = new System.Windows.Forms.Padding(4);
            this.lstDesordenado.Name = "lstDesordenado";
            this.lstDesordenado.Size = new System.Drawing.Size(328, 292);
            this.lstDesordenado.TabIndex = 1;
            // 
            // lstOrdenado
            // 
            this.lstOrdenado.FormattingEnabled = true;
            this.lstOrdenado.ItemHeight = 24;
            this.lstOrdenado.Location = new System.Drawing.Point(412, 132);
            this.lstOrdenado.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrdenado.Name = "lstOrdenado";
            this.lstOrdenado.Size = new System.Drawing.Size(328, 292);
            this.lstOrdenado.TabIndex = 2;
            // 
            // btnOrdenarArray
            // 
            this.btnOrdenarArray.Location = new System.Drawing.Point(789, 293);
            this.btnOrdenarArray.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenarArray.Name = "btnOrdenarArray";
            this.btnOrdenarArray.Size = new System.Drawing.Size(206, 68);
            this.btnOrdenarArray.TabIndex = 4;
            this.btnOrdenarArray.Text = "Ordenar Array";
            this.btnOrdenarArray.UseVisualStyleBackColor = true;
            this.btnOrdenarArray.Click += new System.EventHandler(this.btnOrdenarArray_Click);
            // 
            // btnIngresarDatos
            // 
            this.btnIngresarDatos.Location = new System.Drawing.Point(789, 182);
            this.btnIngresarDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnIngresarDatos.Name = "btnIngresarDatos";
            this.btnIngresarDatos.Size = new System.Drawing.Size(206, 68);
            this.btnIngresarDatos.TabIndex = 3;
            this.btnIngresarDatos.Text = "Ingresar Datos";
            this.btnIngresarDatos.UseVisualStyleBackColor = true;
            this.btnIngresarDatos.Click += new System.EventHandler(this.btnIngresarDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el texto.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Array desordenado.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Array ordenado.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 437);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIngresarDatos);
            this.Controls.Add(this.btnOrdenarArray);
            this.Controls.Add(this.lstOrdenado);
            this.Controls.Add(this.lstDesordenado);
            this.Controls.Add(this.txtInput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstDesordenado;
        private System.Windows.Forms.ListBox lstOrdenado;
        private System.Windows.Forms.Button btnOrdenarArray;
        private System.Windows.Forms.Button btnIngresarDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

