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

namespace DBCon_Lookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-SEKJRM0;Initial Catalog=Con_Lookup;Integrated Security=True;Encrypt=False");  /* Your connection string*/
            connection.Open();
            string query = "insert into UserDetails (Name, Contact, Occupation, Email) values('" + txtName.Text + "', '" + txtContact.Text + "', '" + txtOccupation.Text + "', '" + txtEmail.Text + "');";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your data have been saved to \n our Database");
            connection.Close();
        }
    }
}
