﻿
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace QuanLyQuanCafe
{
    public partial class Hoadon : Form
    {        
        public Hoadon()
        {
            InitializeComponent();         
            loadTable();
            loadCategory();
            loadComboboxTable(cbSwitchTable);
        }
        
        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void loadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name"; //Price
        }

        void loadTable()
        {
            flptabFood.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.loadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight};
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                //bill

               



                // them ban an
                switch (item.Status)
                {
                    case "Trống":
                            btn.BackColor = Color.White; break;
                    default: btn.BackColor = Color.SkyBlue; break;
                }
                flptabFood.Controls.Add(btn);
            }
        }

        void showBill(int id)
        {
            listBill.Items.Clear();
            List<QuanLyQuanCafe.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (QuanLyQuanCafe.DTO.Menu info in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(info.FoodName.ToString());
                lsvItem.SubItems.Add(info.Count.ToString());
                lsvItem.SubItems.Add(info.Price.ToString());
                lsvItem.SubItems.Add(info.TotalPrice.ToString());
                totalPrice += info.TotalPrice;
                listBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTotalPrice.Text = totalPrice.ToString("c");

           
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            listBill.Tag = (sender as Button).Tag;
            showBill(tableID);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if(cb.SelectedIndex == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            loadFoodListByCategoryID(id);
        }

        private void btnThemmon_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem listBill.Tag có chứa một đối tượng Table hợp lệ không
            Table table = listBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Không tìm thấy bàn. Vui lòng kiểm tra lại.");
                return; // Dừng hàm nếu không có bảng hợp lệ
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value; // số lượng món ăn

            if (idBill == -1)
            {
                // Tạo hóa đơn mới nếu chưa có hóa đơn cho bàn này
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                // Cập nhật hóa đơn nếu đã có hóa đơn cho bàn này
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            // Hiển thị lại hóa đơn cho bàn và tải lại danh sách bàn
            showBill(table.ID);
            loadTable();
        }


        private void tBtnThanhtoan_Click(object sender, EventArgs e)
        {
            Table table = listBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID (table.ID);
            int discount = (int)nmdiscount.Value;
            double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if(idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - (Tổng tiền / 100) x Giảm giá\n=> {1} - ({1} / 100) x {2} = {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.checkOut(idBill, discount, (float)finalTotalPrice);
                    showBill(table.ID);
                    loadTable();
                } 
            }
        }

        void loadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "Name";
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            
            int id1 = (listBill.Tag as Table).ID; 
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
             
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} qua bàn {1} không ?", (listBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.switchTable(id1, id2);
                loadTable();
            }
                
        }
    }
}
