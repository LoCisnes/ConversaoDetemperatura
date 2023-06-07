namespace ConversaoDetemperaturaJoao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbCelsius1 = new System.Windows.Forms.RadioButton();
            this.rbKelvin1 = new System.Windows.Forms.RadioButton();
            this.rbFahrenheit1 = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSaida = new System.Windows.Forms.RadioButton();
            this.rbCelsius2 = new System.Windows.Forms.RadioButton();
            this.rbKelvin2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbEntrada.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(92, 21);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(498, 24);
            this.txtValor.TabIndex = 0;
            // 
            // rbCelsius1
            // 
            this.rbCelsius1.AutoSize = true;
            this.rbCelsius1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius1.Location = new System.Drawing.Point(6, 24);
            this.rbCelsius1.Name = "rbCelsius1";
            this.rbCelsius1.Size = new System.Drawing.Size(79, 21);
            this.rbCelsius1.TabIndex = 0;
            this.rbCelsius1.TabStop = true;
            this.rbCelsius1.Text = "Celsius";
            this.rbCelsius1.UseVisualStyleBackColor = true;
            // 
            // rbKelvin1
            // 
            this.rbKelvin1.AutoSize = true;
            this.rbKelvin1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin1.Location = new System.Drawing.Point(6, 63);
            this.rbKelvin1.Name = "rbKelvin1";
            this.rbKelvin1.Size = new System.Drawing.Size(71, 21);
            this.rbKelvin1.TabIndex = 1;
            this.rbKelvin1.TabStop = true;
            this.rbKelvin1.Text = "Kelvin";
            this.rbKelvin1.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheit1
            // 
            this.rbFahrenheit1.AutoSize = true;
            this.rbFahrenheit1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFahrenheit1.Location = new System.Drawing.Point(91, 24);
            this.rbFahrenheit1.Name = "rbFahrenheit1";
            this.rbFahrenheit1.Size = new System.Drawing.Size(105, 21);
            this.rbFahrenheit1.TabIndex = 2;
            this.rbFahrenheit1.TabStop = true;
            this.rbFahrenheit1.Text = "Fahrenheit";
            this.rbFahrenheit1.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbFahrenheit1);
            this.gbEntrada.Controls.Add(this.rbCelsius1);
            this.gbEntrada.Controls.Add(this.rbKelvin1);
            this.gbEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntrada.Location = new System.Drawing.Point(24, 83);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(200, 100);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Entrada";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(381, 261);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(130, 41);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbSaida);
            this.groupBox1.Controls.Add(this.rbCelsius2);
            this.groupBox1.Controls.Add(this.rbKelvin2);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(381, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saída";
            // 
            // gbSaida
            // 
            this.gbSaida.AutoSize = true;
            this.gbSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaida.Location = new System.Drawing.Point(91, 24);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(105, 21);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = true;
            this.gbSaida.Text = "Fahrenheit";
            this.gbSaida.UseVisualStyleBackColor = true;
            // 
            // rbCelsius2
            // 
            this.rbCelsius2.AutoSize = true;
            this.rbCelsius2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCelsius2.Location = new System.Drawing.Point(6, 24);
            this.rbCelsius2.Name = "rbCelsius2";
            this.rbCelsius2.Size = new System.Drawing.Size(79, 21);
            this.rbCelsius2.TabIndex = 0;
            this.rbCelsius2.TabStop = true;
            this.rbCelsius2.Text = "Celsius";
            this.rbCelsius2.UseVisualStyleBackColor = true;
            // 
            // rbKelvin2
            // 
            this.rbKelvin2.AutoSize = true;
            this.rbKelvin2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKelvin2.Location = new System.Drawing.Point(6, 63);
            this.rbKelvin2.Name = "rbKelvin2";
            this.rbKelvin2.Size = new System.Drawing.Size(71, 21);
            this.rbKelvin2.TabIndex = 1;
            this.rbKelvin2.TabStop = true;
            this.rbKelvin2.Text = "Kelvin";
            this.rbKelvin2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(92, 211);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(502, 24);
            this.txtResultado.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(94, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbCelsius1;
        private System.Windows.Forms.RadioButton rbKelvin1;
        private System.Windows.Forms.RadioButton rbFahrenheit1;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton gbSaida;
        private System.Windows.Forms.RadioButton rbCelsius2;
        private System.Windows.Forms.RadioButton rbKelvin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button button1;
    }
}

