using OfficeOpenXml;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel =Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Reflection;


namespace Barkod_One
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

        }



        //SqlConnection ba = new SqlConnection("Data Source=100.100.100.229; Initial Catalog=NewSentezLive; User Id=sa; Password=sa1907sa");
        SqlDataAdapter adtr;
        private string connectionString = "Data Source=100.100.100.229; Initial Catalog=NewSentezLive; User Id=sa; Password=sentez4521515";
        DataTable tablo = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Top;
            txtfis.Text = "Barkod Okutunuz...";
            // TextBox'a týklandýðýnda TextChanged olayýný tetikleyin
            txtfis.Click += new EventHandler(txtfis_Click);
            txtfis.Select();
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.WindowState = FormWindowState.Maximized;

        }



        private void list()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adtr = new SqlDataAdapter(@"
                    Select 

                    Erp_InventoryReceipt.ReceiptNo As [Fiþ No], 
                    Convert(varchar,Erp_InventoryReceipt.ReceiptDate,102) As [Fatura Tarihi],
                    Erp_InventoryReceipt.DocumentNo As [Belge No],

  
                    substring(Erp_CurrentAccount.CurrentAccountName,1,20) As Tedarikçi,
                    Cast(Erp_InventoryReceipt.SubTotal as DECIMAL(18,2)) [KDV'siz Toplam],
                    Convert(varchar,Erp_InventoryReceipt.Ud_Onay,102) as [Onay],

                    Erp_InventoryReceipt.Ud_Onaylayan as[Onaylayan],
                    Erp_InventoryReceipt.Ud_Onayd as[Onayd]


                    From Erp_InventoryReceipt
 
                    Inner Join Erp_CurrentAccount On Erp_CurrentAccount.RecId =Erp_InventoryReceipt.CurrentAccountId
                    WHERE
                    CONVERT(date, Erp_InventoryReceipt.Ud_Onay, 102) = CONVERT(date, GETDATE(), 102)
                    AND ReceiptDate>'2024-01-01' and (ReceiptType='1' or ReceiptType='11')
                     
                    order by [Fiþ No] desc
                    ", connection);
                tablo.Clear();
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
                connection.Close();
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string updateQuery = @"
                        UPDATE Erp_InventoryReceipt
                        SET
                            Ud_Onay = @Ud_Onay,
                            Ud_Onaylayan = @Ud_Onaylayan,
                            Ud_Onayd=@Ud_Onayd
                        WHERE 
                            ReceiptNo = @ReceiptNo";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                try
                {

                    connection.Open(); ;
                    SqlCommand komut = new SqlCommand(updateQuery, connection);

                    // Parametreleri ayarla
                    komut.Parameters.AddWithValue("@ReceiptNo", txtfis.Text);
                    komut.Parameters.AddWithValue("@Ud_Onay", dateonay.Value);
                    komut.Parameters.AddWithValue("@Ud_Onaylayan", comboBox1.Text);
                    komut.Parameters.AddWithValue("@Ud_Onayd", comboBox2.Text);

                    // Komutu çalýþtýr
                    komut.ExecuteNonQuery();
                    sil();
                    MessageBox.Show("Güncelleme baþarýyla tamamlandý.");
                    list();
                    txtfis.Select();




                }


                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme sýrasýnda hata oluþtu: " + ex.Message);
                }
                finally
                {
                    connection.Close();


                }

            }
        }
        private void veriyidolduriki(string fisNo)//bu datagrdiview 2 deki verileri sadece görüntülemek için kullanýlcak
        {
            string query = @"
                SELECT 

                   Erp_InventoryReceipt.ReceiptNo As [Fiþ No], 
                    Erp_Inventory.InventoryName AS [Stok Adý],
                    CONVERT(VARCHAR, Erp_WorkOrder.ShipmentDate, 102) AS [Yükleme Tarihi],

                    Cast(Erp_Requirement.Quantity as DECIMAL(18,2)) [Ýhtiyaç Miktarý],

                    Cast(Erp_InventoryAllocation.Quantity AS DECIMAL(18,2)) [Miktar],

                    Cast(Erp_InventoryAllocation.TopGelen AS DECIMAL(18,2))[Toplam Gelen],

                    Erp_InventoryAllocation.TopGelen - Erp_Requirement.Quantity AS  [Fazla Gelen],
                     

                    (Erp_InventoryAllocation.TopGelen - Erp_Requirement.Quantity)/Erp_Requirement.Quantity  AS [Yüzde %],

                    Cast(Erp_InventoryAllocation.RenkKesim AS DECIMAL(18,2))[Renk Kesim Adeti],
                    Erp_WorkOrder.WorkOrderNo AS [Order No],
                    Erp_WorkOrder.SpecialCode2 AS [Deniz Order],
                    Erp_InventoryAllocation.InventoryVariantId AS [Renk],
                    Erp_InventoryAllocation.PartyNo AS [Parti No]
                    
                   
                FROM 
                    Erp_InventoryAllocation
                    INNER JOIN Erp_WorkOrderItem ON Erp_WorkOrderItem.RecId = Erp_InventoryAllocation.WorkOrderItemId
                    INNER JOIN Erp_WorkOrder ON Erp_WorkOrderItem.WorkOrderId = Erp_WorkOrder.RecId
                    INNER JOIN Erp_InventoryReceiptItem ON Erp_InventoryReceiptItem.RecId = Erp_InventoryAllocation.InventoryReceiptItemId
                    INNER JOIN Erp_InventoryReceipt ON Erp_InventoryReceiptItem.InventoryReceiptId = Erp_InventoryReceipt.RecId
                    INNER JOIN Erp_Inventory ON Erp_InventoryAllocation.InventoryId = Erp_Inventory.RecId
                    INNER JOIN Erp_Requirement ON Erp_InventoryAllocation.RequirementId = Erp_Requirement.RecId
                    INNER JOIN Erp_CurrentAccount ON Erp_CurrentAccount.RecId = Erp_InventoryReceipt.CurrentAccountId
                    WHERE 
        Erp_InventoryReceipt.ReceiptNo = @ReceiptNo
                       ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ReceiptNo", fisNo); // Set parameter value
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable; // Bind data to DataGridView
            }
        }



        private void VeriyiDoldur(string fisNo)
        {
            string query = @"
                SELECT 
        Erp_InventoryReceipt.ReceiptNo As [Fiþ No], 
        Convert(varchar,Erp_InventoryReceipt.ReceiptDate,102) As [Fatura Tarihi],
        Erp_InventoryReceipt.DocumentNo As [Belge No],
        substring(Erp_CurrentAccount.CurrentAccountName,1,20) As Tedarikçi,
        Cast(Erp_InventoryReceipt.SubTotal as DECIMAL(18,2)) [KDV'siz Toplam],
        Convert(varchar,Erp_InventoryReceipt.Ud_Onay,102) as [Onay],
        Erp_InventoryReceipt.Ud_Onaylayan as [Onaylayan],
        Erp_InventoryReceipt.Ud_Onayd as[Onayd]
    
    FROM 
        Erp_InventoryReceipt
    INNER JOIN 
        Erp_CurrentAccount ON Erp_CurrentAccount.RecId = Erp_InventoryReceipt.CurrentAccountId
    WHERE 
        Erp_InventoryReceipt.ReceiptNo = @ReceiptNo

                        ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReceiptNo", fisNo);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtfis.Text = reader["Fiþ No"].ToString();
                            dtarih.Value = DateTime.Parse(reader["Fatura Tarihi"].ToString());
                            txtbelgeno.Text = reader["Belge No"].ToString();
                            txttedarikci.Text = reader["Tedarikçi"].ToString();
                            txtkdviztoplam.Text = reader["KDV'siz Toplam"].ToString();
                            dateonay.Text = reader["Onay"].ToString();
                            comboBox1.Text = reader["Onaylayan"].ToString();
                            comboBox2.Text = reader["Onayd"].ToString();
                            //txtihitiyacmiktar.Text = reader["Ýhtiyaç Miktarý"].ToString();
                            //txtkesadet.Text = reader["Renk Kesim Adeti"].ToString();
                            //txtmiktar.Text = reader["Miktar"].ToString();
                            //txtorderno.Text = reader["Order No"].ToString();
                            //txtparti.Text = reader["Parti No"].ToString();
                            //txtrenk.Text = reader["Renk"].ToString();
                            //txtstokadi.Text = reader["Stok Adý"].ToString() ;
                            //txttgelen.Text = reader["Toplam Gelen"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen fiþ numarasýna göre veri bulunamadý.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veriyi doldurma sýrasýnda hata oluþtu: " + ex.Message);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fisNo = txtfis.Text;
            // TextBox'tan fiþ numarasýný al
            VeriyiDoldur(fisNo);
            veriyidolduriki(fisNo);


        }

        private void sil()
        {
            comboBox1.Text = "";
            txtbelgeno.Text = "";
            txtfis.Text = "";
            txtkdviztoplam.Text = "";
            txttedarikci.Text = "";
            dateonay.ResetText();
            dtarih.ResetText();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satýra týklanmýþsa devam edelim
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // DataGridView'daki seçilen satýrdan ilgili hücrelerin deðerlerini alýp TextBox'lara yazdýrýn
                txtfis.Text = row.Cells["Fiþ No"].Value.ToString();
                dtarih.Value = DateTime.Parse(row.Cells["Fatura Tarihi"].Value.ToString());
                txtbelgeno.Text = row.Cells["Belge No"].Value.ToString();
                txttedarikci.Text = row.Cells["Tedarikçi"].Value.ToString();
                txtkdviztoplam.Text = row.Cells["KDV'siz Toplam"].Value.ToString();
                dateonay.Text = row.Cells["Onay"].Value.ToString();
                comboBox1.Text = row.Cells["Onaylayan"].Value.ToString();
                comboBox2.Text = row.Cells["Onayd"].Value.ToString();


            }
        }
        private void txtfis_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtfis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // TextBox'taki deðeri al ve istediðin iþlemi gerçekleþtir
                VeriyiDoldur(txtfis.Text);
                veriyidolduriki(txtfis.Text);
            }
        }

        private void txtfis_Click(object sender, EventArgs e)
        {
            if (txtfis.Text == "Barkod Okutunuz...")
            {
                txtfis.Text = "";
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
        private void button4_Click(object sender, EventArgs e)
        {
            list();
        }
        private void dosya()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dataRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value ?? DBNull.Value;
                }
                dt.Rows.Add(dataRow);
            }

            // Excel dosyasýna verileri yaz
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // DataTable'daki verileri Excel sayfasýna aktar
                worksheet.Cells["A1"].LoadFromDataTable(dt, true);

                // Excel dosyasýný kaydet
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel Files|*.xlsx";
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo excelFile = new FileInfo(saveDialog.FileName);
                    excelPackage.SaveAs(excelFile);
                    MessageBox.Show("Excel dosyasý baþarýyla oluþturuldu.");
                }


            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

            dosya();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void fasonara_Click(object sender, EventArgs e)
        {
            string fno = txtfasonno.Text;
            fasondoldur(fno);
            fasonlistedoldur(fno);

        }
        private void fasondoldur(string fno)
        {
            string query = @"
                            Select
                Erp_WorkOrderProduction.Ud_Barkod as [Barkod],
                Erp_WorkOrderProduction.DocumentNo as [Belge No],
                Convert(varchar, Erp_WorkOrderProduction.StartProductionDate, 102) As Tarih,


                  substring(Erp_CurrentAccount.CurrentAccountName, 1, 29) As Atölye,
                sum (Erp_WorkOrderProduction.Quantity * Erp_WorkOrderProduction.UnitPrice) as [Tutar TL]

                From Erp_WorkOrderProduction
                  Inner Join Erp_Process
                    On Erp_Process.RecId = Erp_WorkOrderProduction.ProcessId        
                  Inner Join Erp_WorkOrder

                    On Erp_WorkOrder.RecId = Erp_WorkOrderProduction.WorkOrderId
                  Inner Join Erp_CurrentAccount On Erp_CurrentAccount.RecId =
                    Erp_WorkOrderProduction.CurrentAccountId,
                  Inner Join Erp_Inventory
                    On Erp_Inventory.RecId = Erp_WorkOrderProduction.InventoryId
                Where Erp_WorkOrderProduction.InOut = 2



                    group by  Erp_WorkOrderProduction.Ud_Barkod,Erp_WorkOrderProduction.StartProductionDate,Erp_WorkOrderProduction.DocumentNo,Erp_CurrentAccount.CurrentAccountName

                    Order By Barkod Desc";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ud_Barkod", fno);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtfasonno.Text = reader["Barkod"].ToString();
                            fasontarih.Value = DateTime.Parse(reader["Tarih"].ToString());
                            txtfbelge.Text = reader["Belge No"].ToString();
                            ftedarikci.Text = reader["Atölye"].ToString();
                            txtktutar.Text = reader["Tutar TL"].ToString();
                            
                            
                            
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen fiþ numarasýna göre veri bulunamadý.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veriyi doldurma sýrasýnda hata oluþtu: " + ex.Message);
                    }
                }
            }



        }
        private void fasonlistedoldur(string fno)
        {

            string query = @"
                            Select
                Erp_WorkOrderProduction.Ud_Barkod as [Barkod],
                Erp_WorkOrderProduction.DocumentNo as [Belge No],
                Convert(varchar, Erp_WorkOrderProduction.StartProductionDate, 102) As Tarih,
                substring(Erp_CurrentAccount.CurrentAccountName, 1, 29) As Atölye,
                sum (Erp_WorkOrderProduction.Quantity * Erp_WorkOrderProduction.UnitPrice) as [Tutar TL]
                From Erp_WorkOrderProduction

                    Inner Join Erp_Process
                        On Erp_Process.RecId = Erp_WorkOrderProduction.ProcessId
                    Inner Join Erp_WorkOrder
                        On Erp_WorkOrder.RecId = Erp_WorkOrderProduction.WorkOrderId
                     Inner Join Erp_CurrentAccount On Erp_CurrentAccount.RecId =
                        Erp_WorkOrderProduction.CurrentAccountId
                    Inner Join Erp_Inventory
                        xOn Erp_Inventory.RecId = Erp_WorkOrderProduction.InventoryId
                Where Erp_WorkOrderProduction.InOut = 2
                    group by  Erp_WorkOrderProduction.Ud_Barkod,Erp_WorkOrderProduction.StartProductionDate,Erp_WorkOrderProduction.DocumentNo,Erp_CurrentAccount.CurrentAccountName
                    Order By Barkod Desc";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Ud_Barkod",fno); // Set parameter value
                SqlDataAdapter adapter = new SqlDataAdapter(command);


                DataTable dataTable = new DataTable();
                
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable; // Bind data to DataGridView
            }
        }
    }

}
    

