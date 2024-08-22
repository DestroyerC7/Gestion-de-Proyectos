using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace DEMOPROY
{
    public partial class Postulante : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;

        public Postulante()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Server=LAPTOP-V980KNVQ\SQLEXPRESS;Database=DEMOPROY;Integrated Security=True;");
            LoadPostulantes();

        }
        private void LoadPostulantes()
        {
            try
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para seleccionar todos los postulantes
                string query = "SELECT * FROM POSTULANTE";
                adapter = new SqlDataAdapter(query, connection);
                dt = new DataTable();
                adapter.Fill(dt);

                // Asignar el DataTable al DataGridView
                dataGridViewPostulantes.DataSource = dt;

                // Cerrar la conexión
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar postulantes: " + ex.Message);
            }
        }
        private void dataGridViewPostulantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que se haya hecho clic en una fila y no en el encabezado
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPostulantes.Rows[e.RowIndex];

                // Carga los datos de la fila seleccionada en los TextBoxes
                txtCI.Text = row.Cells["CI"].Value.ToString();
                txtPrimerNombre.Text = row.Cells["PrimerNombre"].Value.ToString();
                txtSegundoNombre.Text = row.Cells["SegundoNombre"].Value.ToString();
                txtPrimerApellido.Text = row.Cells["PrimerApellido"].Value.ToString();
                txtSegundoApellido.Text = row.Cells["SegundoApellido"].Value.ToString();
                txtCarrera.Text = row.Cells["Carrera"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }
        private void ClearTextBoxes()
        {
            txtCI.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtCarrera.Clear();
            txtEmail.Clear();
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;
            try
            {
                // Abrir la conexión
                connection.Open();

                // Crear el comando de SQL para insertar un nuevo postulante
                string query = "INSERT INTO POSTULANTE (CI, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Carrera, Email) " +
                               "VALUES (@CI, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Carrera, @Email)";

                SqlCommand cmd = new SqlCommand(query, connection);

                // Asignar los valores desde los TextBoxes
                cmd.Parameters.AddWithValue("@CI", txtCI.Text);
                cmd.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
                cmd.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
                cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                cmd.Parameters.AddWithValue("@Carrera", txtCarrera.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                // Ejecutar el comando
                cmd.ExecuteNonQuery();

                // Cerrar la conexión
                connection.Close();
                // Limpia los botones
                ClearTextBoxes();

                // Actualizar el DataGridView
                LoadPostulantes();

                MessageBox.Show("Postulante agregado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar postulante: " + ex.Message);




            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
                string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE POSTULANTE SET PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, " +
                                   "PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido, Carrera = @Carrera, Email = @Email " +
                                   "WHERE CI = @CI";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CI", txtCI.Text);
                        cmd.Parameters.AddWithValue("@PrimerNombre", txtPrimerNombre.Text);
                        cmd.Parameters.AddWithValue("@SegundoNombre", txtSegundoNombre.Text);
                        cmd.Parameters.AddWithValue("@PrimerApellido", txtPrimerApellido.Text);
                        cmd.Parameters.AddWithValue("@SegundoApellido", txtSegundoApellido.Text);
                        cmd.Parameters.AddWithValue("@Carrera", txtCarrera.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Postulante editado exitosamente.");
                    }
                }
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCI.Text))
            {
                MessageBox.Show("Por favor, seleccione un postulante para eliminar.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM POSTULANTE WHERE CI = @CI";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CI", txtCI.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Postulante eliminado exitosamente.");
                    }
                    // Limpiar los TextBoxes
                    ClearTextBoxes();
                    // Actualizar el DataGridView
                    LoadPostulantes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar postulante: " + ex.Message);
                }
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {

                try
                {
                    // Abre la conexión
                    connection.Open();

                    // Consulta para buscar al postulante por CI
                    string query = "SELECT * FROM POSTULANTE WHERE CI = @CI";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Añade el valor de CI desde el TextBox de búsqueda
                    cmd.Parameters.AddWithValue("@CI", txtBuscarCI.Text);

                    SqlDataAdapter searchAdapter = new SqlDataAdapter(cmd);
                    DataTable searchResult = new DataTable();
                    searchAdapter.Fill(searchResult);

                    // Si se encuentran resultados, los mostramos en el DataGridView
                    if (searchResult.Rows.Count > 0)
                    {
                        dataGridViewPostulantes.DataSource = searchResult;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún postulante con ese CI.");
                        dataGridViewPostulantes.DataSource = null;
                    }

                    // Cierra la conexión
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar postulante: " + ex.Message);
                }
            

        }

        private void Postulante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dEMOPROYDataSet.POSTULANTE' Puede moverla o quitarla según sea necesario.
            this.pOSTULANTETableAdapter.Fill(this.dEMOPROYDataSet.POSTULANTE);

        }

        private void dataGridViewPostulantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPostulantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
    }
    
}
