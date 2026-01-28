using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestión_escolar
{
    public partial class FormDocente : MaterialForm
    {
        private string rolRecibido;

        public FormDocente(string rol)
        {
            InitializeComponent();


            this.rolRecibido = rol;
            this.Text = "Acceso - " + rol;


            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);


            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
               Primary.Orange300,
                Primary.Orange200,
                Primary.Orange100,
                Accent.Green200,
                TextShade.WHITE
            );
        }

        private void FormDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}


