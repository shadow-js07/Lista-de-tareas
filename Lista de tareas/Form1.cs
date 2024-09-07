using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string query;
        string titulo;
        string descripcion;

        SqlConnection conect = new SqlConnection("Server=LAPTOP-B0VC381B\\MSSQLSERVER1;Database=ListaTareas;Trusted_Connection=True;");

        public Form1()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            listView1.Columns.Add("ID", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Titulo", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Descripción", 270, HorizontalAlignment.Left);
            listView1.Columns.Add("Estado", 126, HorizontalAlignment.Left);
        }

        private void LoadTasks()
        {
            listView1.Items.Clear();
            {
                conect.Open();
                query = "SELECT tareaID, titulo, descripcion, estado FROM Tareas";
                using (SqlCommand command = new SqlCommand(query, conect))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["tareaID"].ToString());
                        item.SubItems.Add(reader["titulo"].ToString());
                        item.SubItems.Add(reader["descripcion"].ToString());
                        item.SubItems.Add((bool)reader["estado"] ? "Completada" : "Pendiente");
                        listView1.Items.Add(item);
                    }
                }
                conect.Close();
                tituloT.Text = "";
                descripcionT.Text = "";
            }
        }


        private void cargar_Click(object sender, EventArgs e)
        {
            LoadTasks();

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            titulo = tituloT.Text;
            descripcion = descripcionT.Text;

            query = "INSERT INTO Tareas (titulo, descripcion, estado)" + "VALUES(@TITULO, @DESCRIPCION, 0)";
            using (SqlCommand comando = new SqlCommand(query, conect))
            {
                comando.Parameters.AddWithValue("@TITULO", titulo);
                comando.Parameters.AddWithValue("@DESCRIPCION",descripcion);

                conect.Open();
                comando.ExecuteNonQuery();
                conect.Close();
            }
 
            MessageBox.Show("La tarea ha sido agregada correctamente.");
            LoadTasks();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int tareaID = int.Parse(selectedItem.Text);

                DialogResult result = MessageBox.Show("Esta tarea será eliminada de la lista de manera permanente. ¿Desea continuar?", "Confirmación de eliminación", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    query = "DELETE FROM Tareas WHERE tareaID = @ID";
                    using (SqlCommand comando = new SqlCommand(query, conect))
                    {
                        comando.Parameters.AddWithValue("@ID", tareaID);

                        conect.Open();
                        comando.ExecuteNonQuery();
                        conect.Close();
                    }
                    MessageBox.Show("La tarea ha sido eliminada correctamente.");
                    LoadTasks();
                }
                else if (result == DialogResult.Cancel)
                {
                    MessageBox.Show("Eliminación cancelada.");
                }
            }
        }

        private void marcarTarea_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itemSeleccionado = listView1.SelectedItems[0];
                int tareaID = int.Parse(itemSeleccionado.Text);

                DialogResult marca = MessageBox.Show("¿Desea marcar esta tarea como realizada?", "Confirmación para completar tarea", MessageBoxButtons.OKCancel);

                if(marca == DialogResult.OK)
                {
                    query = "UPDATE Tareas SET estado = 1 WHERE tareaID = @ID";
                    using (SqlCommand comando = new SqlCommand(query, conect))
                    {
                        comando.Parameters.AddWithValue("@ID", tareaID);

                        conect.Open();
                        comando.ExecuteNonQuery();
                        conect.Close();
                    }
                    MessageBox.Show("La tarea ha sido marcada como realizada correctamente.");
                    LoadTasks();
                }
                else if(marca == DialogResult.Cancel)
                {
                    MessageBox.Show("La tarea no ha sido marcada como realizada.");
                }
            }

            
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            conect.Open();

            foreach (ListViewItem item in listView1.Items)
            {
                string id = item.SubItems[0].Text;
                string titulo = item.SubItems[1].Text;
                string descripcion = item.SubItems[2].Text;
                int estado = item.SubItems[3].Text.ToLower() == "pendiente" ? 0 : 1;

                string checkQuery = "SELECT COUNT(*) FROM Tareas WHERE tareaID = @ID";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, conect))
                {
                    checkCommand.Parameters.AddWithValue("@ID", id);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count == 0)
                    {
                        string insertQuery = "INSERT INTO Tareas (titulo, descripcion, estado) VALUES (@TITULO, @DESCRIPCION, @ESTADO)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, conect))
                    {
                        insertCommand.Parameters.AddWithValue("@TITULO", titulo);
                        insertCommand.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                        insertCommand.Parameters.AddWithValue("@ESTADO", estado);
                        insertCommand.ExecuteNonQuery();
                    }
                    }
                    else
                    {
                    string updateQuery = "UPDATE Tareas SET titulo = @TITULO, descripcion = @DESCRIPCION, estado = @ESTADO WHERE tareaID = @ID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, conect))
                    {
                         updateCommand.Parameters.AddWithValue("@ID", id);
                         updateCommand.Parameters.AddWithValue("@TITULO", titulo);
                         updateCommand.Parameters.AddWithValue("@DESCRIPCION", descripcion);
                         updateCommand.Parameters.AddWithValue("@ESTADO", estado);
                         updateCommand.ExecuteNonQuery();
                    }
                    }
                }
            }
             MessageBox.Show("Datos guardados correctamente en la Base de Datos.");
           
             conect.Close();
            
        }

        private void cambiarColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }

        }

        private void cambiarTamañoDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog.Font;
                foreach (Control control in this.Controls)
                {
                    control.Font = fontDialog.Font;
                }
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
