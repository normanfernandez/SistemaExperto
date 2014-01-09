namespace SistemaExperto.Ventanas
{
    partial class CantidadPiezas
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
            this.label1 = new System.Windows.Forms.Label();
            this.BotonConfirmarPieza = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Piezas:";
            // 
            // BotonConfirmarPieza
            // 
            this.BotonConfirmarPieza.Location = new System.Drawing.Point(103, 80);
            this.BotonConfirmarPieza.Name = "BotonConfirmarPieza";
            this.BotonConfirmarPieza.Size = new System.Drawing.Size(75, 23);
            this.BotonConfirmarPieza.TabIndex = 2;
            this.BotonConfirmarPieza.Text = "Aceptar";
            this.BotonConfirmarPieza.UseVisualStyleBackColor = true;
            this.BotonConfirmarPieza.Click += new System.EventHandler(this.BotonConfirmarPieza_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(132, 40);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // CantidadPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 124);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BotonConfirmarPieza);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(277, 151);
            this.MinimumSize = new System.Drawing.Size(277, 151);
            this.Name = "CantidadPiezas";
            this.Text = "CantidadPiezas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BotonConfirmarPieza;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}