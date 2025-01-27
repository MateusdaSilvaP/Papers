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
using System.Data.SqlClient;

namespace BibliotecaPaper
{
    public partial class CadastroLivro : Form
    {
        public CadastroLivro()
        {
            InitializeComponent();
        }

        SqlConnection sqlcon = null;
        private string srtcon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BibliotecaPaper;Data Source=EVA01\\SQLSERVER\r\n";
          private string strSql = string.Empty;

        private void CadastroLivro_Load(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
           strSql= "insert into Livros"
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
