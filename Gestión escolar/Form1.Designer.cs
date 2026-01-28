namespace Gestión_escolar
{
    partial class Titulo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titulo));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            btnEstudiante = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new PictureBox();
            btnAuxiliar = new MaterialSkin.Controls.MaterialButton();
            btndocente = new MaterialSkin.Controls.MaterialButton();
            btnDirectivo = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.BackgroundImage = (Image)resources.GetObject("materialCard1.BackgroundImage");
            materialCard1.BorderStyle = BorderStyle.FixedSingle;
            materialCard1.Controls.Add(btnEstudiante);
            materialCard1.Controls.Add(pictureBox1);
            materialCard1.Controls.Add(btnAuxiliar);
            materialCard1.Controls.Add(btndocente);
            materialCard1.Controls.Add(btnDirectivo);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(53, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(707, 355);
            materialCard1.TabIndex = 0;
            // 
            // btnEstudiante
            // 
            btnEstudiante.AutoSize = false;
            btnEstudiante.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEstudiante.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEstudiante.Depth = 0;
            btnEstudiante.HighEmphasis = true;
            btnEstudiante.Icon = null;
            btnEstudiante.Location = new Point(376, 234);
            btnEstudiante.Margin = new Padding(4, 6, 4, 6);
            btnEstudiante.MouseState = MaterialSkin.MouseState.HOVER;
            btnEstudiante.Name = "btnEstudiante";
            btnEstudiante.NoAccentTextColor = Color.Empty;
            btnEstudiante.Size = new Size(222, 36);
            btnEstudiante.TabIndex = 6;
            btnEstudiante.Text = "Estudiantes";
            btnEstudiante.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEstudiante.UseAccentColor = false;
            btnEstudiante.UseVisualStyleBackColor = true;
            btnEstudiante.Click += btnEstudiante_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 254);
            pictureBox1.MaximumSize = new Size(100, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnAuxiliar
            // 
            btnAuxiliar.AutoSize = false;
            btnAuxiliar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAuxiliar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAuxiliar.Depth = 0;
            btnAuxiliar.HighEmphasis = true;
            btnAuxiliar.Icon = null;
            btnAuxiliar.Location = new Point(73, 234);
            btnAuxiliar.Margin = new Padding(4, 6, 4, 6);
            btnAuxiliar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAuxiliar.Name = "btnAuxiliar";
            btnAuxiliar.NoAccentTextColor = Color.Empty;
            btnAuxiliar.Size = new Size(222, 36);
            btnAuxiliar.TabIndex = 5;
            btnAuxiliar.Text = "Auxiliar docente";
            btnAuxiliar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAuxiliar.UseAccentColor = false;
            btnAuxiliar.UseVisualStyleBackColor = true;
            btnAuxiliar.Click += btnAuxiliar_Click;
            // 
            // btndocente
            // 
            btndocente.AutoSize = false;
            btndocente.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btndocente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btndocente.Depth = 0;
            btndocente.HighEmphasis = true;
            btndocente.Icon = null;
            btndocente.Location = new Point(376, 125);
            btndocente.Margin = new Padding(4, 6, 4, 6);
            btndocente.MouseState = MaterialSkin.MouseState.HOVER;
            btndocente.Name = "btndocente";
            btndocente.NoAccentTextColor = Color.Empty;
            btndocente.Size = new Size(222, 36);
            btndocente.TabIndex = 4;
            btndocente.Text = "Docente";
            btndocente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btndocente.UseAccentColor = false;
            btndocente.UseVisualStyleBackColor = true;
            btndocente.Click += btndocente_Click;
            // 
            // btnDirectivo
            // 
            btnDirectivo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDirectivo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDirectivo.Depth = 0;
            btnDirectivo.HighEmphasis = true;
            btnDirectivo.Icon = null;
            btnDirectivo.Location = new Point(73, 125);
            btnDirectivo.Margin = new Padding(4, 6, 4, 6);
            btnDirectivo.MouseState = MaterialSkin.MouseState.HOVER;
            btnDirectivo.Name = "btnDirectivo";
            btnDirectivo.NoAccentTextColor = Color.Empty;
            btnDirectivo.Size = new Size(222, 36);
            btnDirectivo.TabIndex = 3;
            btnDirectivo.Text = "Directivo/Administrativo";
            btnDirectivo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDirectivo.UseAccentColor = false;
            btnDirectivo.UseVisualStyleBackColor = true;
            btnDirectivo.Click += btnDirectivo_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.BackColor = Color.FromArgb(255, 192, 192);
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(73, 39);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(320, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Seleccione el perfil con el que desea ingresar:";
            // 
            // Titulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(materialCard1);
            Name = "Titulo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bienvenido/a al Sistema de Gestión Escolar";
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnDirectivo;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnEstudiante;
        private MaterialSkin.Controls.MaterialButton btnAuxiliar;
        private MaterialSkin.Controls.MaterialButton btndocente;
    }
}
