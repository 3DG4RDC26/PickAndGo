namespace PickAndGo.Formularios
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrontales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMM = new System.Windows.Forms.NumericUpDown();
            this.nudYY = new System.Windows.Forms.NumericUpDown();
            this.txtSeguridad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelResumen = new System.Windows.Forms.Panel();
            this.dgvResumen = new System.Windows.Forms.DataGridView();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese los numeros frontales de su tarjeta";
            // 
            // txtFrontales
            // 
            this.txtFrontales.Location = new System.Drawing.Point(360, 184);
            this.txtFrontales.Name = "txtFrontales";
            this.txtFrontales.Size = new System.Drawing.Size(395, 20);
            this.txtFrontales.TabIndex = 2;
            this.txtFrontales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFrontales_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "MM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "YY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numeros de seguridad";
            // 
            // nudMM
            // 
            this.nudMM.Location = new System.Drawing.Point(360, 267);
            this.nudMM.Name = "nudMM";
            this.nudMM.Size = new System.Drawing.Size(120, 20);
            this.nudMM.TabIndex = 8;
            // 
            // nudYY
            // 
            this.nudYY.Location = new System.Drawing.Point(360, 349);
            this.nudYY.Name = "nudYY";
            this.nudYY.Size = new System.Drawing.Size(120, 20);
            this.nudYY.TabIndex = 9;
            // 
            // txtSeguridad
            // 
            this.txtSeguridad.Location = new System.Drawing.Point(360, 427);
            this.txtSeguridad.Name = "txtSeguridad";
            this.txtSeguridad.Size = new System.Drawing.Size(202, 20);
            this.txtSeguridad.TabIndex = 10;
            this.txtSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSeguridad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(356, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PickAndGo.Properties.Resources.proyect;
            this.pictureBox1.Location = new System.Drawing.Point(14, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(413, 482);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "label6";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FloralWhite;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(3, 534);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 43);
            this.btnBack.TabIndex = 13;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelResumen
            // 
            this.panelResumen.Controls.Add(this.dgvResumen);
            this.panelResumen.Location = new System.Drawing.Point(821, 103);
            this.panelResumen.Name = "panelResumen";
            this.panelResumen.Size = new System.Drawing.Size(437, 474);
            this.panelResumen.TabIndex = 14;
            // 
            // dgvResumen
            // 
            this.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResumen.Location = new System.Drawing.Point(14, 24);
            this.dgvResumen.Name = "dgvResumen";
            this.dgvResumen.Size = new System.Drawing.Size(410, 437);
            this.dgvResumen.TabIndex = 0;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPagar.Location = new System.Drawing.Point(330, 534);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(440, 43);
            this.btnPagar.TabIndex = 15;
            this.btnPagar.Text = "Proceder al pago";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombre del titular";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(360, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(395, 20);
            this.txtName.TabIndex = 17;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.panelResumen);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSeguridad);
            this.Controls.Add(this.nudYY);
            this.Controls.Add(this.nudMM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrontales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPago";
            this.Text = "FrmPago";
            ((System.ComponentModel.ISupportInitialize)(this.nudMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResumen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrontales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMM;
        private System.Windows.Forms.NumericUpDown nudYY;
        private System.Windows.Forms.TextBox txtSeguridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelResumen;
        private System.Windows.Forms.DataGridView dgvResumen;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
    }
}