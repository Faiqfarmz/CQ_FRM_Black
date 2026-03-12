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

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtHasil.Text = "";
        }

        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=PAIQQQQQQQQ\\FAIQ;Initial Catalog=DBAkademikAD0;Integrated Security=True"
            );
        }

