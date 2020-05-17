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
    public partial class Argently : UserControl
    {
        public Argently()
        {
            InitializeComponent();
            getTargets();
        }

        int poss = 10;

        public void addItem(string text)
        {
            ToDoItem item = new ProjectApp.ToDoItem(text);
            panel2.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            string tarName = textBox.Text;
            addItem(tarName);
            addTargets(tarName);
            textBox.Text = "";
        }


        void getTargets()
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=targets;Integrated Security=True; Pooling=False;");
            using (SQL)
            {
                SQL.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM TargetTable WHERE TargerID = 1", SQL);
                
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        addItem(""+reader["TargetText"]);
                    }
                }
            }
        }
        public void addTargets(string insert)
        {
            SqlConnection SQL = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=targets;Integrated Security=True;Pooling=False;");
            using (SQL)
            {
                SQL.Open();
                SqlCommand commandsec = new SqlCommand("INSERT INTO TargetTable (TargetText, TargerID) VALUES ('"+insert+"','1')", SQL);
                commandsec.ExecuteNonQuery();
            }
        }
    }
}
