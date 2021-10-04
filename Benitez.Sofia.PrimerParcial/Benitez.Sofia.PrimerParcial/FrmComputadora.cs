﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CiberCafe;

namespace Benitez.Sofia.PrimerParcial
{
    public partial class FrmComputadora : Form
    {
        public Computadora computadora;
        public Ciber miCiber;
        public Cliente cliente;
        public double tiempoSeleccionado=double.MinValue;


        public FrmComputadora(Ciber ciber, Cliente clienteSeleccionado)
        {
            InitializeComponent();
            miCiber = ciber;
            cliente = clienteSeleccionado;
            lblCliente.Text = clienteSeleccionado.Mostrar();

            rbtnC1.Text = ciber["C01"].ToString();
            rbtnC2.Text = ciber["C02"].ToString();
            rbtnC3.Text = ciber["C03"].ToString();
            rbtnC4.Text = ciber["C04"].ToString();
            rbtnC5.Text = ciber["C05"].ToString();
            rbtnC6.Text = ciber["C06"].ToString();
            rbtnC7.Text = ciber["C07"].ToString();
            rbtnC8.Text = ciber["C08"].ToString();
            rbtnC9.Text = ciber["C09"].ToString();
            rbtnC10.Text = ciber["C10"].ToString();



        }


        /// <summary>
        /// al presional el boton de asignar controla que la computadora seleccionada tenga los elementos que el cliente necesita, sino no permite la asignacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            
            string computadoraSeleccionada = "";
            string tiempo = "";
            
           
            foreach (Control item in gbxCompus.Controls)
            {

                if (item is RadioButton && ((RadioButton)item).Checked is true)
                {
                    computadoraSeleccionada = item.Text;
                }
            }

            if (chbTiempoLibre.Checked)
            {
                tiempo= "tiempo libre";
            }
            else
            {
                tiempo = numMinutos.Value.ToString();
                tiempoSeleccionado= (double)numMinutos.Value;
            }

            computadora = Computadora.BuscarComputadoraSeleccionada(computadoraSeleccionada, miCiber);
            if(computadora.Estado==true && (cliente == computadora))
            {
                string mensaje = $"Desea asignarle la computadora {computadora.Id.ToString()} al cliente {cliente.Nombre.ToString()}?";
                if (MessageBox.Show(mensaje, "Asignar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show(computadora.ToString() + "\n Asignada " + tiempo);
                    this.Close();
                }
               
            }
            else
            {
                MessageBox.Show("La computadora esta ocupada o no cumple con los requisitos del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// maneja el bloqueo de la asignacion de minutos. Solo se puede elegir tiempo libre o la cantidad de minutos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chbTiempoLibre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTiempoLibre.Checked)
            {
                numMinutos.Enabled = false;
            }
            else
            {
                numMinutos.Enabled = true;
            }
        }
    }
}
