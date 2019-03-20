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

namespace Bill
{
    public partial class Form1 : Form
    {
        private double totalMaterial;

        public Form1()
        {
            InitializeComponent();
        }

        private void RefForm()
        {

           
            object o = Ezzat.ExecutedScalar("EXPayback_selectID");
            txt_BillNumber.Text = o + "";


            

            dataGridView1.Rows.Clear();

           
            txt_MaterialTotal.Text = "0";

            totalMaterial = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text != "0" && txtQuantity.Text != "0" && txtProduct.Text != "")
            {
                AddRow();
            }
        }

        private void AddRow()
        {
                dataGridView1.Rows.Add();
                dataGridView1[1, dataGridView1.Rows.Count - 1].Value = txtProduct.Text;
                //dataGridView1[1, dataGridView1.Rows.Count - 1].Value = comboProduct.Text;
                dataGridView1[2, dataGridView1.Rows.Count - 1].Value = txtQuantity.Text;
                dataGridView1[3, dataGridView1.Rows.Count - 1].Value = txtPrice.Text;
                dataGridView1[4, dataGridView1.Rows.Count - 1].Value = String.Format("{0:0.00}", Math.Round((double.Parse(txtPrice.Text) * double.Parse(txtQuantity.Text)), 2));


            totalMaterial += double.Parse(dataGridView1[4, dataGridView1.Rows.Count - 1].Value.ToString());
            Calcolate();

        }

        private void Calcolate()
        {
            txt_MaterialTotal.Text = String.Format("{0:0.00}", totalMaterial);
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            totalMaterial -= double.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            Calcolate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && txtName.Text != "")
            {
                SaveBill();
                AddIMBill_Details();
                MessageBox.Show("تم بنجاح");


                Form_Bill_Customer_Purchasing print = new Form_Bill_Customer_Purchasing(int.Parse(txt_BillNumber.Text),
                                                     txtName.Text,
                                                     double.Parse(txt_MaterialTotal.Text)
                                                     );
                print.ShowDialog();
                RefForm();



            }
        }

        private void SaveBill()
        {
            Ezzat.ExecutedNoneQuery("insertTotalBill", new SqlParameter("@Name",txtName.Text), new SqlParameter("@Total",totalMaterial));
        }

        private void AddIMBill_Details()
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                Ezzat.ExecutedNoneQuery("insertDetailsBill"
                    , new SqlParameter("@ID", txt_BillNumber.Text)
                    , new SqlParameter("@PName", item.Cells[1].Value.ToString())
                    , new SqlParameter("@PQuantity", float.Parse(item.Cells[2].Value + ""))
                    , new SqlParameter("@PPrice", float.Parse(item.Cells[3].Value + ""))
                    , new SqlParameter("@PTotal", float.Parse(item.Cells[4].Value + ""))
                    );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefForm();
        }
    }
}
