namespace FrmConvertirGrados
{
    partial class FrmConvertirGrados
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
            this.txtNumeroCelcius = new System.Windows.Forms.Label();
            this.lblNumeroFahrenheit = new System.Windows.Forms.Label();
            this.tbCelcius = new System.Windows.Forms.TextBox();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertirCelciusEnFahrenheit = new System.Windows.Forms.Button();
            this.btnConvertirFahrenheitEnCelcius = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroCelcius
            // 
            this.txtNumeroCelcius.AutoSize = true;
            this.txtNumeroCelcius.Location = new System.Drawing.Point(58, 86);
            this.txtNumeroCelcius.Name = "txtNumeroCelcius";
            this.txtNumeroCelcius.Size = new System.Drawing.Size(131, 13);
            this.txtNumeroCelcius.TabIndex = 0;
            this.txtNumeroCelcius.Text = "Número de grados Celcius";
            // 
            // lblNumeroFahrenheit
            // 
            this.lblNumeroFahrenheit.AutoSize = true;
            this.lblNumeroFahrenheit.Location = new System.Drawing.Point(42, 134);
            this.lblNumeroFahrenheit.Name = "lblNumeroFahrenheit";
            this.lblNumeroFahrenheit.Size = new System.Drawing.Size(147, 13);
            this.lblNumeroFahrenheit.TabIndex = 1;
            this.lblNumeroFahrenheit.Text = "Número de grados Fahrenheit";
            // 
            // tbCelcius
            // 
            this.tbCelcius.Location = new System.Drawing.Point(216, 79);
            this.tbCelcius.Name = "tbCelcius";
            this.tbCelcius.Size = new System.Drawing.Size(100, 20);
            this.tbCelcius.TabIndex = 2;
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(216, 127);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.tbFahrenheit.TabIndex = 3;
            // 
            // btnConvertirCelciusEnFahrenheit
            // 
            this.btnConvertirCelciusEnFahrenheit.Location = new System.Drawing.Point(148, 198);
            this.btnConvertirCelciusEnFahrenheit.Name = "btnConvertirCelciusEnFahrenheit";
            this.btnConvertirCelciusEnFahrenheit.Size = new System.Drawing.Size(125, 23);
            this.btnConvertirCelciusEnFahrenheit.TabIndex = 4;
            this.btnConvertirCelciusEnFahrenheit.Text = "Convertir a Fahrenheit";
            this.btnConvertirCelciusEnFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirCelciusEnFahrenheit.Click += new System.EventHandler(this.btnConvertirCelciusEnFahrenheit_Click);
            // 
            // btnConvertirFahrenheitEnCelcius
            // 
            this.btnConvertirFahrenheitEnCelcius.Location = new System.Drawing.Point(148, 250);
            this.btnConvertirFahrenheitEnCelcius.Name = "btnConvertirFahrenheitEnCelcius";
            this.btnConvertirFahrenheitEnCelcius.Size = new System.Drawing.Size(125, 23);
            this.btnConvertirFahrenheitEnCelcius.TabIndex = 5;
            this.btnConvertirFahrenheitEnCelcius.Text = "Convertir a Celcius";
            this.btnConvertirFahrenheitEnCelcius.UseVisualStyleBackColor = true;
            this.btnConvertirFahrenheitEnCelcius.Click += new System.EventHandler(this.btnConvertirFahrenheitEnCelcius_Click);
            // 
            // FrmConvertirGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 331);
            this.Controls.Add(this.btnConvertirFahrenheitEnCelcius);
            this.Controls.Add(this.btnConvertirCelciusEnFahrenheit);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.tbCelcius);
            this.Controls.Add(this.lblNumeroFahrenheit);
            this.Controls.Add(this.txtNumeroCelcius);
            this.Name = "FrmConvertirGrados";
            this.Text = "FrmConvertirGrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumeroCelcius;
        private System.Windows.Forms.Label lblNumeroFahrenheit;
        private System.Windows.Forms.TextBox tbCelcius;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Button btnConvertirCelciusEnFahrenheit;
        private System.Windows.Forms.Button btnConvertirFahrenheitEnCelcius;
    }
}

