namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bt_Vardas = new System.Windows.Forms.Button();
            this.tb_Vardas = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_Vardas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Vardas
            // 
            this.bt_Vardas.Location = new System.Drawing.Point(34, 64);
            this.bt_Vardas.Name = "bt_Vardas";
            this.bt_Vardas.Size = new System.Drawing.Size(198, 23);
            this.bt_Vardas.TabIndex = 0;
            this.bt_Vardas.Text = "Vardas";
            this.bt_Vardas.UseVisualStyleBackColor = true;
            this.bt_Vardas.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Vardas
            // 
            this.tb_Vardas.Location = new System.Drawing.Point(89, 27);
            this.tb_Vardas.Name = "tb_Vardas";
            this.tb_Vardas.Size = new System.Drawing.Size(143, 20);
            this.tb_Vardas.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 93);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(198, 322);
            this.textBox2.TabIndex = 2;
            // 
            // lb_Vardas
            // 
            this.lb_Vardas.AutoSize = true;
            this.lb_Vardas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lb_Vardas.Location = new System.Drawing.Point(31, 27);
            this.lb_Vardas.Name = "lb_Vardas";
            this.lb_Vardas.Size = new System.Drawing.Size(52, 16);
            this.lb_Vardas.TabIndex = 3;
            this.lb_Vardas.Text = "Vardas";
            this.lb_Vardas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Vardas.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 450);
            this.Controls.Add(this.lb_Vardas);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tb_Vardas);
            this.Controls.Add(this.bt_Vardas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Vardas;
        private System.Windows.Forms.TextBox tb_Vardas;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lb_Vardas;
    }
}

