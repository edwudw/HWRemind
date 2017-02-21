using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HWRemind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            selectedLabel.Text = "English";
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
            string sql = "CREATE TABLE TODO (SUBJECT VARCHAR(10), INFO VARCHAR(300)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            ListItems listForm = new ListItems();
            DialogResult dr = listForm.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                englishButton.BackColor = Color.Lime;
            }
            else
            {
                englishButton.BackColor = Color.Red;
            }
            
        }
    }
}
