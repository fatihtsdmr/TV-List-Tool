using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class home_Page : Form
    {
        public home_Page()
        {
            InitializeComponent();
        }
        static SqlConnection connectionString = new SqlConnection(@"Data Source=VTITUL14756\SQLEXPRESS;Initial Catalog=Tv_List;User ID=sa;Password=Pass1234 ");
        private void home_Page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tv_ListDataSet2.Tbl_Tv_List' table. You can move, or remove it, as needed.
           // SqlConnection.tbl_Tv_ListTableAdapter.Fill(this.tv_ListDataSet2.Tbl_Tv_List);
           

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
        }

        public static DataTable dataAdapterSelect(string sqlQuery)
        {
            // This method will convert any Select string to a query.
            SqlDataAdapter DataAdapter = new SqlDataAdapter(sqlQuery, connectionString);
            DataTable dt = new DataTable();

            DataAdapter.Fill(dt);
            return dt;
        }
    }
}
