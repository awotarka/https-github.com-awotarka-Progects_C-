using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectApp
{
    public partial class ToDoItem : UserControl
    {
        public ToDoItem()
        {
            InitializeComponent();
        }

        public ToDoItem(string text)
        {
            InitializeComponent();
            lbl.Text = text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=targets;Integrated Security=True;Pooling=False;");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("DELETE FROM TargetTable WHERE TargetText = '" + lbl.Text + "'", SQL);
                command.ExecuteNonQuery();
            }

            this.BackColor = Color.FromArgb(160, 22, 237);
            
            lbl.Text = "Deleted";
        }//40, 177, 231 
    }
}
