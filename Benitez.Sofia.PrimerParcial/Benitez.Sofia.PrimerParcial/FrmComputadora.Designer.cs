﻿
namespace Benitez.Sofia.PrimerParcial
{
    partial class FrmComputadora
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
            this.rbtnC1 = new System.Windows.Forms.RadioButton();
            this.rbtnC2 = new System.Windows.Forms.RadioButton();
            this.rbtnC3 = new System.Windows.Forms.RadioButton();
            this.rbtnC4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnC1
            // 
            this.rbtnC1.AutoSize = true;
            this.rbtnC1.Location = new System.Drawing.Point(39, 44);
            this.rbtnC1.Name = "rbtnC1";
            this.rbtnC1.Size = new System.Drawing.Size(94, 19);
            this.rbtnC1.TabIndex = 0;
            this.rbtnC1.TabStop = true;
            this.rbtnC1.Text = "radioButton1";
            this.rbtnC1.UseVisualStyleBackColor = true;
            // 
            // rbtnC2
            // 
            this.rbtnC2.AutoSize = true;
            this.rbtnC2.Location = new System.Drawing.Point(39, 117);
            this.rbtnC2.Name = "rbtnC2";
            this.rbtnC2.Size = new System.Drawing.Size(94, 19);
            this.rbtnC2.TabIndex = 1;
            this.rbtnC2.TabStop = true;
            this.rbtnC2.Text = "radioButton2";
            this.rbtnC2.UseVisualStyleBackColor = true;
            // 
            // rbtnC3
            // 
            this.rbtnC3.AutoSize = true;
            this.rbtnC3.Location = new System.Drawing.Point(39, 191);
            this.rbtnC3.Name = "rbtnC3";
            this.rbtnC3.Size = new System.Drawing.Size(94, 19);
            this.rbtnC3.TabIndex = 2;
            this.rbtnC3.TabStop = true;
            this.rbtnC3.Text = "radioButton3";
            this.rbtnC3.UseVisualStyleBackColor = true;
            // 
            // rbtnC4
            // 
            this.rbtnC4.AutoSize = true;
            this.rbtnC4.Location = new System.Drawing.Point(39, 266);
            this.rbtnC4.Name = "rbtnC4";
            this.rbtnC4.Size = new System.Drawing.Size(94, 19);
            this.rbtnC4.TabIndex = 3;
            this.rbtnC4.TabStop = true;
            this.rbtnC4.Text = "radioButton1";
            this.rbtnC4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(502, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Asignar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(327, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(44, 15);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Cliente";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(502, 215);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 23);
            this.numericUpDown1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiempo";
            // 
            // FrmComputadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbtnC4);
            this.Controls.Add(this.rbtnC3);
            this.Controls.Add(this.rbtnC2);
            this.Controls.Add(this.rbtnC1);
            this.Name = "FrmComputadora";
            this.Text = "FrmComputadora";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnC1;
        private System.Windows.Forms.RadioButton rbtnC2;
        private System.Windows.Forms.RadioButton rbtnC3;
        private System.Windows.Forms.RadioButton rbtnC4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}