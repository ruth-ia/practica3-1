namespace P3_1_RIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lTexto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.lCoste = new System.Windows.Forms.Label();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.rbOrdinario = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(98, 40);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(558, 205);
            this.txtTelegrama.TabIndex = 0;
            // 
            // lTexto
            // 
            this.lTexto.AutoSize = true;
            this.lTexto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTexto.Location = new System.Drawing.Point(98, 9);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(39, 15);
            this.lTexto.TabIndex = 1;
            this.lTexto.Text = "Texto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(203, 336);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(162, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(465, 286);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(191, 73);
            this.bCalcular.TabIndex = 4;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // lCoste
            // 
            this.lCoste.AutoSize = true;
            this.lCoste.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lCoste.Location = new System.Drawing.Point(98, 339);
            this.lCoste.Name = "lCoste";
            this.lCoste.Size = new System.Drawing.Size(38, 15);
            this.lCoste.TabIndex = 5;
            this.lCoste.Text = "Coste";
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(98, 283);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(67, 19);
            this.rbUrgente.TabIndex = 6;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            // 
            // rbOrdinario
            // 
            this.rbOrdinario.AutoSize = true;
            this.rbOrdinario.Location = new System.Drawing.Point(214, 286);
            this.rbOrdinario.Name = "rbOrdinario";
            this.rbOrdinario.Size = new System.Drawing.Size(75, 19);
            this.rbOrdinario.TabIndex = 7;
            this.rbOrdinario.Text = "Ordinario";
            this.rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbOrdinario);
            this.Controls.Add(this.rbUrgente);
            this.Controls.Add(this.lCoste);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lTexto);
            this.Controls.Add(this.txtTelegrama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTelegrama;
        private Label lTexto;
        private TextBox txtPrecio;
        private Button bCalcular;
        private Label lCoste;
        private RadioButton rbUrgente;
        private RadioButton rbOrdinario;
    }
}