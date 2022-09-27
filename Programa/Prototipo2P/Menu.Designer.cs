
namespace Prototipo2P
{
    partial class Menu
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
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnCatalogos = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú Principal";
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHerramientas.Location = new System.Drawing.Point(319, 266);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(229, 107);
            this.btnHerramientas.TabIndex = 4;
            this.btnHerramientas.Text = "Herramientas";
            this.btnHerramientas.UseVisualStyleBackColor = false;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Location = new System.Drawing.Point(12, 266);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(229, 107);
            this.btnInformes.TabIndex = 5;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCatalogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogos.Location = new System.Drawing.Point(164, 116);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Size = new System.Drawing.Size(229, 107);
            this.btnCatalogos.TabIndex = 6;
            this.btnCatalogos.Text = "Catálogos";
            this.btnCatalogos.UseVisualStyleBackColor = false;
            this.btnCatalogos.Click += new System.EventHandler(this.btnCatalogos_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.Location = new System.Drawing.Point(491, 116);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(229, 107);
            this.btnProcesos.TabIndex = 7;
            this.btnProcesos.Text = "Procesos";
            this.btnProcesos.UseVisualStyleBackColor = false;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(633, 266);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(229, 107);
            this.btnAyuda.TabIndex = 8;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(738, 433);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 49);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 494);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.btnCatalogos);
            this.Controls.Add(this.btnInformes);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnCatalogos;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnSalir;
    }
}