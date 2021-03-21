﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudCSharp
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Login login = new Login();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new HelloWord_Welcome(login.UsuarioLogado));
            }

        }
    }
}
