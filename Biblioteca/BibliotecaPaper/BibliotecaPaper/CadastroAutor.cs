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

namespace BibliotecaPaper
{
    public partial class CadastrarAutor : Form
    {
        public CadastrarAutor()
        {
            InitializeComponent();
        }
    }
    private void CadastroAutor(object sender, EventArgs e)
    {
        // Conectar ao banco de dados
        string connectionString = "Data Source=meuServidor;Initial Catalog=meuBancoDados;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);

        // Criar um DataTable
        DataTable dataTable = new DataTable();

        try
        {
            // Abrir a conexão com o banco de dados
            connection.Open();

            // Criar um comando SQL para selecionar dados da tabela
            string sql = "SELECT * FROM Autor";
            SqlCommand command = new SqlCommand(sql, connection);

            // Executar o comando e preencher o DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            // Vincular o DataTable ao DataGridView
            dataGridView1.DataSource = dataTable;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        finally
        {
            // Fechar a conexão com o banco de dados
            connection.Close();
        }
    }
}
}
}
