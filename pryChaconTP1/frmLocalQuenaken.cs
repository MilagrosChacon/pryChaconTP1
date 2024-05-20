using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChaconTP1
{
    public partial class frmLocalQuenaken : Form
    {
        private Button[] botonesAsiento; // Arreglo para almacenar los botones de los asientos

        public frmLocalQuenaken()
        {
            InitializeComponent();
            // Inicializando el arreglo de botones
            botonesAsiento = new Button[] { btnF1A1, btnF1A2, btnF1A3, btnF1A4, btnF1A5,
                                         btnF2A6, btnF2A7, btnF2A8, btnF2A9, btnF2A10,
                                         btnF3A11, btnF3A12, btnF3A13, btnF3A14, btnF3A15,
                                         btnF4A16, btnF4A17, btnF4A18, btnF4A19, btnF4A20 };

            // Creando una instancia de la clase clsAsientos
            clsAsientos asientos = new clsAsientos(botonesAsiento);
        }
    }
}
