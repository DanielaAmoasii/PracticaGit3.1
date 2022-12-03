namespace PracticaGit3._1_2022_23
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();

            this.label3 = new System.Windows.Forms.Label();

            this.rb_ord = new System.Windows.Forms.RadioButton();
            this.rb_urg = new System.Windows.Forms.RadioButton();

            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(106, 237);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(68, 84);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(309, 95);
            this.txtTelegrama.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 

            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Coste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Texto";
            // 

            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(43, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(362, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Daniela Amoasii Marin y Olga F. Civieta Bermejo 2022-23";

            // rb_ord
            // 
            this.rb_ord.AutoSize = true;
            this.rb_ord.Location = new System.Drawing.Point(90, 239);
            this.rb_ord.Name = "rb_ord";
            this.rb_ord.Size = new System.Drawing.Size(83, 20);
            this.rb_ord.TabIndex = 18;
            this.rb_ord.TabStop = true;
            this.rb_ord.Text = "Ordinario";
            this.rb_ord.UseVisualStyleBackColor = true;
            // 
            // rb_urg
            // 
            this.rb_urg.AutoSize = true;
            this.rb_urg.Location = new System.Drawing.Point(197, 239);
            this.rb_urg.Name = "rb_urg";
            this.rb_urg.Size = new System.Drawing.Size(76, 20);
            this.rb_urg.TabIndex = 19;
            this.rb_urg.TabStop = true;
            this.rb_urg.Text = "Urgente";
            this.rb_urg.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 318);
            this.Controls.Add(this.label3);
            this.ClientSize = new System.Drawing.Size(589, 391);
            this.Controls.Add(this.rb_urg);
            this.Controls.Add(this.rb_ord);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "P3.1_DAM_y_OFCB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_ord;
        private System.Windows.Forms.RadioButton rb_urg;
    }
}

