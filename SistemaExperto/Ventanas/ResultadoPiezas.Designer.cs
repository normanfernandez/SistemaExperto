namespace SistemaExperto.Ventanas
{
    partial class ResultadoPiezas
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
            this.dataPiezas = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNombreEnsable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPiezas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPiezas
            // 
            this.dataPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPiezas.Location = new System.Drawing.Point(12, 45);
            this.dataPiezas.Name = "dataPiezas";
            this.dataPiezas.Size = new System.Drawing.Size(844, 150);
            this.dataPiezas.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 1;
            // 
            // labelNombreEnsable
            // 
            this.labelNombreEnsable.AutoSize = true;
            this.labelNombreEnsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEnsable.Location = new System.Drawing.Point(13, 13);
            this.labelNombreEnsable.Name = "labelNombreEnsable";
            this.labelNombreEnsable.Size = new System.Drawing.Size(165, 20);
            this.labelNombreEnsable.TabIndex = 3;
            this.labelNombreEnsable.Text = "Nombre Ensamble: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eficiencia %:";
            // 
            // ResultadoPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(902, 264);
            this.Controls.Add(this.labelNombreEnsable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataPiezas);
            this.Name = "ResultadoPiezas";
            this.Text = "ResultadoPiezas";
            ((System.ComponentModel.ISupportInitialize)(this.dataPiezas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPiezas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNombreEnsable;
        private System.Windows.Forms.Label label1;
    }
}