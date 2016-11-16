using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// 顯示customer side頁面
/// </summary>
namespace MealRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Action<string> afterSend { get; set; }
        public DataGridView dataGridView;
        private RestaurantBehavior restaurant = new RestaurantFront();
        private void RichText(string text)
        {
            RichTextArea.Text = text;
        }
        /// <summary>
        /// 按下btnNext按鈕後tabMeal板的版面icon排列顯示
        /// 步驟 1: 計算tabMeal(面板)上顯示點餐資訊的button有多少(最多9個button)
        /// 2:匹對tabMeal顯示到json檔(mealModel物件)裡該category第幾個(index)的物件
        /// 3:檢查是否還有多餘的點餐資料可顯示當按下按下btnNext按鈕後
        /// 4:有的話，則將每個button對應的mealFoodList集合裡的index各加9，若可更新顯示的資料少於9，則將多餘
        /// 的button的visible屬性改為false
        /// 5:改完後，更新完後按鈕到底顯示到個mealFoodList集合第幾個(index)物件
        /// 6:顯示頁面資訊
        /// 7:啟動或不啟動btnNext，啟動btnPrev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            //1
            int index = ((RestaurantFront)restaurant).PageCount();
            //2
            int currentPos = ((RestaurantFront)restaurant).GetCurrentPos(index,tabMeal);
            //3
            int tabPageTotal = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count - currentPos - 1;
            //4
            if (tabPageTotal > 0)
            { 
            for (int i = 0; i < ((RestaurantFront)restaurant).btnList.Length; i++)
            {
                    if (i < tabPageTotal)
                    {
                        ((RestaurantFront)restaurant).btnList[i].Text = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][i + 9].Name;
                        if (String.IsNullOrWhiteSpace(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][i + 9].MealImgPos))
                            ((RestaurantFront)restaurant).btnList[i].BackgroundImage = null;
                        else
                            ((RestaurantFront)restaurant).btnList[i].BackgroundImage = Image.FromFile(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][i + 9].MealImgPos);
                        ((RestaurantFront)restaurant).btnList[i].BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                        ((RestaurantFront)restaurant).btnList[i].Visible = false;
            }
            //5
                if (tabPageTotal > 9)
                    tabPageTotal = currentPos + 9;
                else
                    tabPageTotal += 9;
                //6
                //當前頁數除以總頁數
                int firstPage = tabPageTotal / restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count + 1;
                int secondPage = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count / 9 + 1;
                labPage.Text = "Page : " + firstPage + "/" + secondPage;
                //7
                if (firstPage == secondPage)
                    btnNext.Enabled = false;
                else
                    btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
        }
        /// <summary>
        /// 按下btnPrev按鈕後tabMeal板的版面icon排列顯示
        /// 步驟 1: 計算tabMeal(面板)上顯示點餐資訊的button有多少(最多9個button)
        /// 2:匹對tabMeal顯示到son檔(mealModel物件)裡該category第幾個(index)的物件
        /// 3:計算按下(btnPrev)按鈕後匹配到json檔(mealModel物件)裡該category第幾個(index)物件
        /// 4:則將每個button對應的mealFoodList集合index各減9
        /// 5:顯示頁面資訊
        /// 6:啟動或不啟動btnPrev，啟動btnNext 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            //1
            int index = ((RestaurantFront)restaurant).PageCount();
            --index;
            //2
            int currentPos = ((RestaurantFront)restaurant).GetCurrentPos(index,tabMeal);
            //3
            currentPos -= index;
            //4
            for (int i = 0; i < ((RestaurantFront)restaurant).btnList.Length; i++)
            {
                ((RestaurantFront)restaurant).btnList[i].Text = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][currentPos + i - 9].Name;
                if (String.IsNullOrWhiteSpace(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][currentPos + i - 9].MealImgPos))
                    ((RestaurantFront)restaurant).btnList[i].BackgroundImage = null;
                else
                    ((RestaurantFront)restaurant).btnList[i].BackgroundImage = Image.FromFile(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][currentPos + i - 9].MealImgPos);
                ((RestaurantFront)restaurant).btnList[i].BackgroundImageLayout = ImageLayout.Stretch;
                if (i > index)
                    ((RestaurantFront)restaurant).btnList[i].Visible = true;
            }
            //5
            int firstPage = currentPos / restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count + 1;
            int secondPage = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count / 9 + 1;
            labPage.Text = "Page : " + firstPage + "/" + secondPage;
            //6
            if ((currentPos - 9) == 0)
                btnPrev.Enabled = false;
            else
                btnPrev.Enabled = true;
            btnNext.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            restaurant.mealModel = new Model();
            dataGridView = dataGridView1;
            afterSend += SetText;
            ((RestaurantFront)restaurant).btnList[0] = btnList1;
            ((RestaurantFront)restaurant).btnList[1] = btnList2;
            ((RestaurantFront)restaurant).btnList[2] = btnList3;
            ((RestaurantFront)restaurant).btnList[3] = btnList4;
            ((RestaurantFront)restaurant).btnList[4] = btnList5;
            ((RestaurantFront)restaurant).btnList[5] = btnList6;
            ((RestaurantFront)restaurant).btnList[6] = btnList7;
            ((RestaurantFront)restaurant).btnList[7] = btnList8;
            ((RestaurantFront)restaurant).btnList[8] = btnList9;

            for (int i = 0; i < ((RestaurantFront)restaurant).btnList.Length; i++)
            {
                ((RestaurantFront)restaurant).btnList[i].BackgroundImage = Image.FromFile(restaurant.projectPath + "/Img/Fruit" + i + ".gif");
                ((RestaurantFront)restaurant).btnList[i].BackgroundImageLayout = ImageLayout.Stretch;
            }

            restaurant.ReadJson();
            int index = 0;
            //顯示資料
            foreach (var item in restaurant.mealModel.mealFoodList.Keys)
            {
                ++index;
                if(index > 2)
                {
                    string title = item;
                    TabPage myTabPage = new TabPage(title);
                    tabMeal.TabPages.Add(myTabPage);
                }
            }
        }

        private void btnList1_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[0].Text);
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[1].Text);
        }

        /// <summary>
        /// button被按時，datagridview顯示的資料變動
        /// </summary>
        /// <param name="text">該button的text</param>
        private void BtnClick(string text)
        {
            ImportFoodInfo(((RestaurantFront)restaurant).SearchIndex(text,tabMeal));
        }
        /// <summary>
        /// 更新或增加datagridview上的點餐資訊
        /// 步驟 1.先將該meal物件裡的資料更新(Qty(數量),Subtotal(總價))
        /// 2.將datagridview的Row數從0到RowCount-1分別儲存到dataList List集合裡，dataList集合用來幫助接下來的linq查詢
        /// 3.用linq查詢datagridview裡的column 1 資料是否有和mealFoodList陣列裡的meal物件name屬性相同
        /// 4.若有則將步驟1的結果顯示到datagridview(column3 和 column5)上，接者結束這函數
        /// 5.若沒有，則datagridview先create一個新row和物件，再將這新的物件資料顯示到這個row上
        /// 6.執行ShowTotal函數
        /// </summary>
        /// <param name="index">代表該meal物件是在list集合裡第幾個元素</param>
        private void ImportFoodInfo(int index)
        {
            #region 步驟1
            //1
            restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Qty += 1;
            restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Subtotal += restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].UnitPrice;
            #endregion

            #region 步驟2
            //2
            List<int> dataList = new List<int>();
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                dataList.Add(i);
            }
            #endregion

            #region 步驟3
            //3
            var pos =
                from p in dataList
                where dataGridView.Rows[p].Cells[1].Value != null
                && dataGridView.Rows[p].Cells[1].Value.ToString().Equals(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Name)
                select p;
            #endregion

            #region 步驟4
            //4
            if (pos.Any())
            {
                dataGridView.Rows[pos.First()].Cells[2].Value = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Qty.ToString();
                dataGridView.Rows[pos.First()].Cells[4].Value = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Subtotal.ToString();
                ShowTotal();
                return;
            }
            #endregion

            #region 步驟5
            //5
            dataGridView.Rows.Add(new Object[] { "X", restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Name, restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Qty, restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].UnitPrice, restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Subtotal });
            #endregion

            #region 步驟6
            //6
            ShowTotal();
            #endregion
        }

        private void SetText(string text)
        {
            labTotal.Text = text;
        }
        /// <summary>
        /// 顯示點餐所花費的總價格
        /// 步驟:將datagridview上column 5的所有subtotal相加，再用afterSend委託讓labTotal上顯示結果
        /// </summary>
        private void ShowTotal()
        {
            int total = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                total += Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
            }
            afterSend("Total : " + total + " NTD");
        }

        private void btnList3_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[2].Text);
        }

        private void btnList4_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[3].Text);
        }

        private void btnList5_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[4].Text);
        }

        private void btnList6_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[5].Text);
        }

        private void btnList7_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[6].Text);
        }

        private void btnList8_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[7].Text);
        }

        private void btnList9_Click(object sender, EventArgs e)
        {
            BtnClick(((RestaurantFront)restaurant).btnList[8].Text);
        }
        /// <summary>
        /// 當觸發mouseHover事件時，更新label顯示的產品資訊
        /// 步驟:用button的text來比對json檔(mealFoodList物件)
        /// </summary>
        /// <param name="text">該button的text</param>
        private void BtnMouseHover(string text)
        {
            RichText(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][((RestaurantFront)restaurant).SearchIndex(text,tabMeal)].MealDescription);
        }
        private void btnList1_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[0].Text);
        }

        private void btnList2_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[1].Text);
        }

        private void btnList3_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[2].Text);
        }

        private void btnList4_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[3].Text);
        }

        private void btnList5_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[4].Text);
        }

        private void btnList6_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[5].Text);
        }

        private void btnList7_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[6].Text);
        }

        private void btnList8_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[7].Text);
        }

        private void btnList9_MouseHover(object sender, EventArgs e)
        {
            BtnMouseHover(((RestaurantFront)restaurant).btnList[8].Text);
        }

        /// <summary>
        /// 若點擊delete button，該行點餐資料將刪除，且更新labtotal上顯示的資料
        /// 步驟 用if來判斷是否點擊delete button和datagridview上是否已有點餐資料，若有則刪除該行且更新labtotal顯示的
        /// 總花費量(ShowTotal函數)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0 && dataGridView1.RowCount > 1)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                ShowTotal();
            }
        }
        /// <summary>
        /// 當datagridview上的numericupdown button被按時，該row的點餐資訊(總價錢和點餐數量)會更新
        /// 步驟: 1.檢查datagridview是否有該點餐資訊，有的話則執行if敘述，沒有則結束
        /// 2.匹配mealList字串陣列是否有該datagridview該row column1 name的資料，有的話則傳回該mealList陣列的index
        /// 3.將已變動的datagridview上Qty的資訊儲存到mealFoodList陣列的第index(步驟2結果)個Meal物件裡，且重新計算該物件的Subtotal值
        /// 4.將該物件的Subtotal資料重新寫到datagridview上並且執行ShowTotal函數
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                //1
                if (dataGridView1.RowCount > 1)
                {
                    //2
                    string columnMealName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    int index;
                    var pos =
                    from p in restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text]
                    select p.Name;
                    index = Array.IndexOf(pos.ToArray(), columnMealName);
                //3
                restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Qty = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Subtotal = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Qty * restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].UnitPrice;
                    //4
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][index].Subtotal.ToString();
                    ShowTotal();
                }
        }
        /// <summary>
        /// 該事件發生時，tabMeal(面板)要顯示的點餐資料會隨者tabMeal的tabPage text(category)改變
        /// 步驟 1:初始化button的img和text，並且將生成的button加到tabPage裡
        /// 2:啟動或不啟動btnNext,不啟動btnPrev
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1
            for (int i = 0; i < restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count; i++)
            {
                if (i < ((RestaurantFront)restaurant).btnList.Length)
                {
                    ((RestaurantFront)restaurant).btnList[i].Visible = true;
                    ((RestaurantFront)restaurant).btnList[i].Text = restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][i].Name;
                    try
                    {
                        if (String.IsNullOrWhiteSpace(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][i].MealImgPos))
                            ((RestaurantFront)restaurant).btnList[i].BackgroundImage = null;
                        else
                            ((RestaurantFront)restaurant).btnList[i].BackgroundImage = Image.FromFile(restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text][i].MealImgPos);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                    tabMeal.SelectedTab.Controls.Add(((RestaurantFront)restaurant).btnList[i]);
                }
            }
            //2
            if (restaurant.mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count < 9)
            {
                btnNext.Enabled = false;
            }
            else
                btnNext.Enabled = true;
            btnPrev.Enabled = false;
        }
    }
}
