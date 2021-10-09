
namespace Benitez.Sofia.PrimerParcial
{
    partial class FrmEstadisticas
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
            this.rtbxEstadisticas = new System.Windows.Forms.RichTextBox();
            this.btnEstadistica1 = new System.Windows.Forms.Button();
            this.btnEstadistica2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxEstadisticas
            // 
            this.rtbxEstadisticas.Location = new System.Drawing.Point(46, 23);
            this.rtbxEstadisticas.Name = "rtbxEstadisticas";
            this.rtbxEstadisticas.Size = new System.Drawing.Size(443, 323);
            this.rtbxEstadisticas.TabIndex = 0;
            this.rtbxEstadisticas.Text = "";
            // 
            // btnEstadistica1
            // 
            this.btnEstadistica1.Location = new System.Drawing.Point(520, 23);
            this.btnEstadistica1.Name = "btnEstadistica1";
            this.btnEstadistica1.Size = new System.Drawing.Size(202, 41);
            this.btnEstadistica1.TabIndex = 1;
            this.btnEstadistica1.Text = "Orden uso computadoras";
            this.btnEstadistica1.UseVisualStyleBackColor = true;
            this.btnEstadistica1.Click += new System.EventHandler(this.btnEstadistica1_Click);
            // 
            // btnEstadistica2
            // 
            this.btnEstadistica2.Location = new System.Drawing.Point(520, 70);
            this.btnEstadistica2.Name = "btnEstadistica2";
            this.btnEstadistica2.Size = new System.Drawing.Size(202, 41);
            this.btnEstadistica2.TabIndex = 2;
            this.btnEstadistica2.Text = "Orden uso cabinas";
            this.btnEstadistica2.UseVisualStyleBackColor = true;
            this.btnEstadistica2.Click += new System.EventHandler(this.btnEstadistica2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(520, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(520, 164);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(202, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(520, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(202, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(520, 258);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(202, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(520, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(202, 41);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 367);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEstadistica2);
            this.Controls.Add(this.btnEstadistica1);
            this.Controls.Add(this.rtbxEstadisticas);
            this.Name = "FrmEstadisticas";
            this.Text = "Estadísticas históricas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxEstadisticas;
        private System.Windows.Forms.Button btnEstadistica1;
        private System.Windows.Forms.Button btnEstadistica2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}