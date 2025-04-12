namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly TextBox txtEmail; // Corrected type from 'object' to 'TextBox'  
        private static readonly Estudiante estudiante;
        private ListBox listBox1; // Changed type from 'object' to 'ListBox'

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Nombre = txtNombre.Text; // Updated property to match 'Nombre'  
            estudiante.Carnet = Convert.ToInt32(txtCarnet.Text); // Updated property to match 'Carnet'  
            estudiante.Seccion = Convert.ToInt32(txtSeccion.Text); // Fixed conversion from 'string' to 'int'  
            estudiante.Correo = txtEmail.Text; // Updated property to match 'Correo'  

            int result = EstudianteDAL.AgregarEstudiante(estudiante); // Moved inside the method to fix 'IDE1007'

            if (result > 0) // Fixed placement of 'if' statement to resolve 'CS1519' and 'CS1026'
            {
                MessageBox.Show("Éxito al Guardar"); // Fixed typo in 'MessageBox'
            }
            else
            {
                MessageBox.Show("Error al Guardar"); // Corrected typo in 'MessageBox'
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Estudiante> lista = EstudianteDAL.ObtenerEstudiantes(); // Fixed method call to 'ObtenerEstudiantes'
            foreach (var item in lista)
            {
                listBox1.Items.Add(item.Nombre); // Added 'Nombre' property to display in the list
            }
        }
        public void refressPantalla()
        {
            dataGridView1.DataSource = Estudiante.PresentarRegistro();
            dataGridView1.Refresh();
        }
    }
               
    }
}
