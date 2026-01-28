using MaterialSkin;
using MaterialSkin.Controls; 
using Microsoft.VisualBasic.Logging;

namespace Gestión_escolar
{
    public partial class Titulo : MaterialForm
    {
        public Titulo()
        {
            InitializeComponent();

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

        

        private void btnAuxiliar_Click(object sender, EventArgs e)
        {
           
            FormAuxiliar login = new FormAuxiliar("Auxiliar");
            login.Show();
           
        }

        private void btnDirectivo_Click(object sender, EventArgs e)
        {
            
            FormDirectivo login = new FormDirectivo("Directivo");
            login.Show();
            
        }

        private void btndocente_Click(object sender, EventArgs e)
        {

            FormDocente login = new FormDocente("Docente");
            login.Show();
            
        }

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            FormEstudiante login = new FormEstudiante("Estudiante");
            login.Show();
            
        }
    }
}
