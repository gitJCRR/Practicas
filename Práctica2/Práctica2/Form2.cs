﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2
{
    public partial class frmsobre : Form
    {
        public frmsobre()
        {
            InitializeComponent();
        }

        // botón que cierra el formulario
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
