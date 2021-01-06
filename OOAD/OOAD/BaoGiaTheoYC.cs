using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace OOAD
{
    public partial class BaoGiaTheoYC : Form
    {
        public BaoGiaTheoYC()
        {
            InitializeComponent();
        }
        private LoaiHangBUS lhbus;
        private HangHoaBUS hhbus;

        private void BaoGiaTheoYC_Load(object sender, EventArgs e)
        {


            lhbus = new LoaiHangBUS();
            hhbus = new HangHoaBUS();

            List<LoaiHangDTO> lslh = lhbus.select();

            List<HangHoaDTO> lshh = hhbus.select();
            Load_Datagridview1(lshh);

            dataGridView1.Columns["MOTA"].Visible = false;
            dataGridView1.Columns["MANHASANXUAT"].Visible = false;
            dataGridView1.Columns["MALOAIHANG"].Visible = false;
            dataGridView1.Columns["SOLUONG"].Visible = false;

            comboBox1.DataSource = lslh;
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[comboBox1.DataSource];
            myCurrencyManager.Refresh();

            comboBox1.DisplayMember = "TenLoaiHang";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* int temp= dataGridView2.RowCount;
            dataGridView2.Rows[temp - 1].Cells[0].Value = "no";
            dataGridView2.Rows[temp - 1].Cells[1].Value = "no";
            dataGridView2.Rows[temp - 1].Cells[2].Value = "no";
            dataGridView2.Rows[temp - 1].Cells[3].Value = "no";
            dataGridView2.Rows.RemoveAt(temp - 1);*/


            if (dataGridView2.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView2.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView2.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView2.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Xuất file thành công");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            string key = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);

            List<HangHoaDTO> lshh2 = hhbus.timkiem(key);
            dataGridView1.AutoGenerateColumns = false;
            Load_Datagridview1(lshh2);

            dataGridView1.Columns["MOTA"].Visible = false;
            dataGridView1.Columns["MANHASANXUAT"].Visible = false;
            dataGridView1.Columns["MALOAIHANG"].Visible = false;
            dataGridView1.Columns["SOLUONG"].Visible = false;

        }

        public void Load_Datagridview1(List<HangHoaDTO> lshh)
        {
            if (lshh == null)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm hàng hóa");
                return;
            }
           
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lshh;

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dataGridView1.DataSource];
            myCurrencyManager.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            int count = dataGridView2.RowCount;
            if (count == 0)
            {
                int rowID = dataGridView2.Rows.Add();
                DataGridViewRow rownew = dataGridView2.Rows[rowID];
            }
            else
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                dataGridView2.Rows.Add(row);
            }

            dataGridView2.Rows[count].Cells[0].Value = dataGridView1.Rows[index].Cells[0].Value.ToString();
            dataGridView2.Rows[count].Cells[1].Value = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dataGridView2.Rows[count].Cells[2].Value = dataGridView1.Rows[index].Cells[3].Value.ToString();
            dataGridView2.Rows[count].Cells[3].Value = dataGridView1.Rows[index].Cells[4].Value.ToString();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;

           /* dataGridView2.Rows[index].Cells[0].Value = null;
            dataGridView2.Rows[index].Cells[1].Value = null;
            dataGridView2.Rows[index].Cells[2].Value = null;
            dataGridView2.Rows[index].Cells[3].Value = null;*/

            dataGridView2.Rows.RemoveAt(index);
        }
    }
}
