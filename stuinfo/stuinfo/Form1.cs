using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stuinfo
{
    public partial class RukaiyaAkram : Form
    {
        DataTable dt = new DataTable();
        public RukaiyaAkram()
        {
            InitializeComponent();

            InitializeDataTable();

        }
        private void RukaiyaAkram_Load(object sender, EventArgs e)
        {

            //MessageBox.Show("Form Loaded!");  // Debug message to check if the event fires


        }

        // Initialize DataTable structure (headers)
        private void InitializeDataTable()
        {
            DataColumn dc1 = new DataColumn("Course Title", typeof(string));
            DataColumn dc2 = new DataColumn("Course Code", typeof(string));
            DataColumn dc3 = new DataColumn("Grade", typeof(string));
            DataColumn dc4 = new DataColumn("Status", typeof(string));
            DataColumn dc6 = new DataColumn("Obtained Marks", typeof(float));    
         
            // Add columns to DataTable
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc6);
        }
        public void CreateNewRow()
        {
            // Basic validation
            if (string.IsNullOrWhiteSpace(txtcoursecode.Text) ||
                string.IsNullOrWhiteSpace(txtcoursetitle.Text) ||
                cmbstatus.SelectedItem == null ||
                cmbgrade.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtobtainmarks.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the method if validation fails
            }

            // Try to parse Obtained Marks
            if (!float.TryParse(txtobtainmarks.Text, out float obtainedmarks))
            {
                MessageBox.Show("Please enter a valid numeric value for Obtained Marks.");
                return; // Exit the method if parsing fails
            }
            string grade = cmbgrade.SelectedItem.ToString();

            // Add the row to the DataTable with values from input fields
            dt.Rows.Add(
                txtcoursecode.Text,             // Course Code (string)
                txtcoursetitle.Text,            // Course Title (string)
                cmbstatus.SelectedItem.ToString(), // Status (string from ComboBox)
                grade,                          // Grade (integer from ComboBox)
                obtainedmarks                   // Obtained Marks (float from TextBox)
            );

            // Clear input fields
            txtcoursecode.Clear();
            txtcoursetitle.Clear();
            cmbstatus.SelectedIndex = -1;
            cmbgrade.SelectedIndex = -1;
            txtobtainmarks.Clear();

            // Bind the updated DataTable to the DataGridView
            dataGridView2.DataSource = dt;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            CreateNewRow();  // Call the method to add a new row

        }
    }
    }



