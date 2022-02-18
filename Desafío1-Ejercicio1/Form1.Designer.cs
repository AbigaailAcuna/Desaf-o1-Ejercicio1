
namespace Desafío1_Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupvalor = new System.Windows.Forms.NumericUpDown();
            this.btnencolar = new System.Windows.Forms.Button();
            this.btndesencolar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupvalor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Cola";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // nupvalor
            // 
            this.nupvalor.Location = new System.Drawing.Point(340, 52);
            this.nupvalor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupvalor.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupvalor.Name = "nupvalor";
            this.nupvalor.Size = new System.Drawing.Size(61, 22);
            this.nupvalor.TabIndex = 2;
            this.nupvalor.ValueChanged += new System.EventHandler(this.nupvalor_ValueChanged);
            // 
            // btnencolar
            // 
            this.btnencolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnencolar.Location = new System.Drawing.Point(502, 54);
            this.btnencolar.Name = "btnencolar";
            this.btnencolar.Size = new System.Drawing.Size(99, 34);
            this.btnencolar.TabIndex = 3;
            this.btnencolar.Text = "Encolar";
            this.btnencolar.UseVisualStyleBackColor = true;
            this.btnencolar.Click += new System.EventHandler(this.btnencolar_Click);
            // 
            // btndesencolar
            // 
            this.btndesencolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndesencolar.Location = new System.Drawing.Point(620, 54);
            this.btndesencolar.Name = "btndesencolar";
            this.btndesencolar.Size = new System.Drawing.Size(99, 34);
            this.btndesencolar.TabIndex = 4;
            this.btndesencolar.Text = "Desencolar";
            this.btndesencolar.UseVisualStyleBackColor = true;
            this.btndesencolar.Click += new System.EventHandler(this.btndesencolar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(31, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 214);
            this.panel1.TabIndex = 5;
            // 
            // btnsalir
            // 
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.Location = new System.Drawing.Point(739, 54);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(99, 34);
            this.btnsalir.TabIndex = 6;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1041, 414);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndesencolar);
            this.Controls.Add(this.btnencolar);
            this.Controls.Add(this.nupvalor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simulador de cola";
            ((System.ComponentModel.ISupportInitialize)(this.nupvalor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupvalor;
        private System.Windows.Forms.Button btnencolar;
        private System.Windows.Forms.Button btndesencolar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

