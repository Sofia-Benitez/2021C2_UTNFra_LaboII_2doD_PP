
namespace Benitez.Sofia.PrimerParcial
{
    partial class FrmImpresora
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstbColaImpresiones = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.grbxImpresoras = new System.Windows.Forms.GroupBox();
            this.lstbImpresoras = new System.Windows.Forms.ListBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbxPropiedades = new System.Windows.Forms.GroupBox();
            this.lblCopias = new System.Windows.Forms.Label();
            this.numCantCopias = new System.Windows.Forms.NumericUpDown();
            this.rbtnByN = new System.Windows.Forms.RadioButton();
            this.rbtnColor = new System.Windows.Forms.RadioButton();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grbxImpresoras.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbxPropiedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCopias)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lstbColaImpresiones);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(670, 352);
            this.splitContainer1.SplitterDistance = 241;
            this.splitContainer1.TabIndex = 0;
            // 
            // lstbColaImpresiones
            // 
            this.lstbColaImpresiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbColaImpresiones.BackColor = System.Drawing.Color.Gainsboro;
            this.lstbColaImpresiones.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstbColaImpresiones.FormattingEnabled = true;
            this.lstbColaImpresiones.ItemHeight = 15;
            this.lstbColaImpresiones.Location = new System.Drawing.Point(0, 0);
            this.lstbColaImpresiones.Name = "lstbColaImpresiones";
            this.lstbColaImpresiones.Size = new System.Drawing.Size(241, 349);
            this.lstbColaImpresiones.TabIndex = 0;
            this.lstbColaImpresiones.SelectedValueChanged += new System.EventHandler(this.lstbColaImpresiones_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAyuda);
            this.panel2.Controls.Add(this.grbxImpresoras);
            this.panel2.Controls.Add(this.lblArchivo);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.MinimumSize = new System.Drawing.Size(425, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 173);
            this.panel2.TabIndex = 5;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyuda.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAyuda.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAyuda.Location = new System.Drawing.Point(385, 3);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(37, 36);
            this.btnAyuda.TabIndex = 10;
            this.btnAyuda.Text = "?";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // grbxImpresoras
            // 
            this.grbxImpresoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbxImpresoras.Controls.Add(this.lstbImpresoras);
            this.grbxImpresoras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grbxImpresoras.Location = new System.Drawing.Point(0, 86);
            this.grbxImpresoras.Name = "grbxImpresoras";
            this.grbxImpresoras.Size = new System.Drawing.Size(425, 87);
            this.grbxImpresoras.TabIndex = 0;
            this.grbxImpresoras.TabStop = false;
            this.grbxImpresoras.Text = "Seleccionar impresora";
            // 
            // lstbImpresoras
            // 
            this.lstbImpresoras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbImpresoras.FormattingEnabled = true;
            this.lstbImpresoras.ItemHeight = 15;
            this.lstbImpresoras.Location = new System.Drawing.Point(3, 19);
            this.lstbImpresoras.Name = "lstbImpresoras";
            this.lstbImpresoras.Size = new System.Drawing.Size(419, 64);
            this.lstbImpresoras.TabIndex = 0;
            // 
            // lblArchivo
            // 
            this.lblArchivo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArchivo.Location = new System.Drawing.Point(0, 0);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(136, 19);
            this.lblArchivo.TabIndex = 3;
            this.lblArchivo.Text = "Archivo seleccionado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbxPropiedades);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 179);
            this.panel1.TabIndex = 4;
            // 
            // gbxPropiedades
            // 
            this.gbxPropiedades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPropiedades.Controls.Add(this.lblCopias);
            this.gbxPropiedades.Controls.Add(this.numCantCopias);
            this.gbxPropiedades.Controls.Add(this.rbtnByN);
            this.gbxPropiedades.Controls.Add(this.rbtnColor);
            this.gbxPropiedades.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gbxPropiedades.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxPropiedades.Location = new System.Drawing.Point(0, 0);
            this.gbxPropiedades.Name = "gbxPropiedades";
            this.gbxPropiedades.Size = new System.Drawing.Size(425, 109);
            this.gbxPropiedades.TabIndex = 1;
            this.gbxPropiedades.TabStop = false;
            this.gbxPropiedades.Text = "Propiedades";
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Location = new System.Drawing.Point(238, 52);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(43, 15);
            this.lblCopias.TabIndex = 3;
            this.lblCopias.Text = "Copias";
            // 
            // numCantCopias
            // 
            this.numCantCopias.Location = new System.Drawing.Point(238, 70);
            this.numCantCopias.Name = "numCantCopias";
            this.numCantCopias.Size = new System.Drawing.Size(95, 23);
            this.numCantCopias.TabIndex = 2;
            this.numCantCopias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnByN
            // 
            this.rbtnByN.AutoSize = true;
            this.rbtnByN.Location = new System.Drawing.Point(21, 74);
            this.rbtnByN.Name = "rbtnByN";
            this.rbtnByN.Size = new System.Drawing.Size(104, 19);
            this.rbtnByN.TabIndex = 1;
            this.rbtnByN.TabStop = true;
            this.rbtnByN.Text = "Blanco y negro";
            this.rbtnByN.UseVisualStyleBackColor = true;
            // 
            // rbtnColor
            // 
            this.rbtnColor.AutoSize = true;
            this.rbtnColor.Location = new System.Drawing.Point(21, 32);
            this.rbtnColor.Name = "rbtnColor";
            this.rbtnColor.Size = new System.Drawing.Size(54, 19);
            this.rbtnColor.TabIndex = 0;
            this.rbtnColor.TabStop = true;
            this.rbtnColor.Text = "Color";
            this.rbtnColor.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnImprimir.Location = new System.Drawing.Point(297, 127);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 40);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(670, 352);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinimumSize = new System.Drawing.Size(686, 391);
            this.Name = "FrmImpresora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imprimir";
            this.Load += new System.EventHandler(this.FrmImpresora_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grbxImpresoras.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gbxPropiedades.ResumeLayout(false);
            this.gbxPropiedades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantCopias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbxPropiedades;
        private System.Windows.Forms.Label lblCopias;
        private System.Windows.Forms.NumericUpDown numCantCopias;
        private System.Windows.Forms.RadioButton rbtnByN;
        private System.Windows.Forms.RadioButton rbtnColor;
        private System.Windows.Forms.GroupBox grbxImpresoras;
        private System.Windows.Forms.ListBox lstbColaImpresiones;
        private System.Windows.Forms.ListBox lstbImpresoras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAyuda;
    }
}