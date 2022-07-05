
namespace C_Hello_World
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblnumb1 = new System.Windows.Forms.Label();
            this.lblnumb2 = new System.Windows.Forms.Label();
            this.lblResul = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblRe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnSoma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoma.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSoma.ForeColor = System.Drawing.Color.White;
            this.btnSoma.Location = new System.Drawing.Point(190, 244);
            this.btnSoma.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(133, 30);
            this.btnSoma.TabIndex = 0;
            this.btnSoma.Text = "Soma";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // lblnumb1
            // 
            this.lblnumb1.AutoSize = true;
            this.lblnumb1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumb1.ForeColor = System.Drawing.Color.White;
            this.lblnumb1.Location = new System.Drawing.Point(45, 48);
            this.lblnumb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumb1.Name = "lblnumb1";
            this.lblnumb1.Size = new System.Drawing.Size(99, 16);
            this.lblnumb1.TabIndex = 1;
            this.lblnumb1.Text = "Primeiro Número:";
            this.lblnumb1.Click += new System.EventHandler(this.lblnumb1_Click);
            // 
            // lblnumb2
            // 
            this.lblnumb2.AutoSize = true;
            this.lblnumb2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblnumb2.ForeColor = System.Drawing.Color.White;
            this.lblnumb2.Location = new System.Drawing.Point(45, 119);
            this.lblnumb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnumb2.Name = "lblnumb2";
            this.lblnumb2.Size = new System.Drawing.Size(105, 16);
            this.lblnumb2.TabIndex = 2;
            this.lblnumb2.Text = "Segundo Número:";
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblResul.ForeColor = System.Drawing.Color.White;
            this.lblResul.Location = new System.Drawing.Point(84, 203);
            this.lblResul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(66, 16);
            this.lblResul.TabIndex = 3;
            this.lblResul.Text = "Resultado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 23);
            this.textBox2.TabIndex = 5;
            // 
            // lblRe
            // 
            this.lblRe.AutoSize = true;
            this.lblRe.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRe.ForeColor = System.Drawing.Color.White;
            this.lblRe.Location = new System.Drawing.Point(187, 203);
            this.lblRe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRe.Name = "lblRe";
            this.lblRe.Size = new System.Drawing.Size(0, 16);
            this.lblRe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(369, 305);
            this.Controls.Add(this.lblRe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.lblnumb2);
            this.Controls.Add(this.lblnumb1);
            this.Controls.Add(this.btnSoma);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblnumb1;
        private System.Windows.Forms.Label lblnumb2;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblRe;
    }
}

