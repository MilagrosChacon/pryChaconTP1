using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChaconTP1
{

        internal class clsAsientos
        {
            // Arreglo para almacenar los botones
            private Button[] botones;

            // Constructor que recibe el arreglo de botones como parámetro
            public clsAsientos(Button[] botones)
            {
                this.botones = botones;

                // Asignando manejadores de eventos a cada botón
                foreach (Button boton in botones)
                {
                    boton.Click += new EventHandler(boton_Click);
                }
            }

            // Evento Click para cada botón
            private void boton_Click(object sender, EventArgs e)
            {
                // Obteniendo el botón presionado
                Button botonPresionado = (Button)sender;

                // Obteniendo la posición del botón en el arreglo
                int indiceBoton = Array.IndexOf(botones, botonPresionado);

                // Calculando el número de fila y asiento
                int fila = indiceBoton / 5;
                int asiento = indiceBoton % 5 + 1;

                // Mostrando la información de la reserva
                MessageBox.Show("Reserva realizada: Asiento " + asiento + " - Fila " + (fila + 1));
            }
        }
}
