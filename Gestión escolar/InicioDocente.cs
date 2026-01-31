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
    public partial class InicioDocente : MaterialForm
    {
        private string rolRecibido;

        public InicioDocente(string rol)
        {
            InitializeComponent();


            this.rolRecibido = rol;
            this.Text = "Inicio  " + rol;


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

       

        
           
        
    }
}


