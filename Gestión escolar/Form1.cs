using MaterialSkin.Controls; 
using MaterialSkin;

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

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click_1(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            FormDocente ventanaDocente = new FormDocente();
            ventanaDocente.Show();
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
