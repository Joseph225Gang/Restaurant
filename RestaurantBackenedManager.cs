using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/// <summary>
/// login成功後的backened頁面
/// </summary>
namespace MealRestaurant
{
    public partial class RestaurantBackenedManager : Form
    {
        public RestaurantBackenedManager()
        {
            InitializeComponent();
        }

        private RestaurantBehavior restaurant = new RestaurantBackened();
        private void RestaurantBackenedManager_Load(object sender, EventArgs e)
        {
            //更新listManager裡的items
            reNewTabPageContext();

            //將category加到combox裡
            Object[] category = new Object[restaurant.mealModel.mealFoodList.Keys.Count];
            int categroyIndex = 0;
            foreach (var item in restaurant.mealModel.mealFoodList.Keys)
            {
                category[categroyIndex] = item;
                categroyIndex++;
            }
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(category);
        }

        /// <summary>
        /// 當tabControl的index變動時(Index是Meal時)，更新listManager(listbox)裡的items
        /// 步驟:1:listManager(listbox)加入tabMeal，且將原listManager裡的items先刪除
        /// 2:Deserialize json檔到mealModel物件裡
        /// 3:將json檔到mealModel物件裡mealFoodList集合的所有物件都讀到listManager(listbox)裡
        /// </summary>
        private void reNewTabPageContext()
        {
            //1
            tabMeal.SelectedTab.Controls.Add(listManager);
            listManager.Items.Clear();
            //2
            restaurant.ReadJson();
            //3
            foreach (var item in restaurant.mealModel.mealFoodList.Keys)
            {
                for (int i = 0; i < restaurant.mealModel.mealFoodList[item].Count; i++)
                {
                    listManager.Items.Add(restaurant.mealModel.mealFoodList[item][i].Name);
                }
            }
        }

        /// <summary>
        /// 當listManager index變化時，gboManager(GroupBox)裡的items顯示的資料也會變化
        /// 步驟: 1:tabPage為MealManager，則會對照json檔的各個meal物件(MealIndexChanged方法)
        /// 2:tabPage為Category,則會json檔的各個category(CategoryIndexChanged方法)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1
            if (tabMeal.SelectedIndex == 0)
                MealIndexChanged();
            //2
            else
                CategoryIndexChanged();
        }

        /// <summary>
        /// listManager(listbox)裡的index變動，且tabPage的index的text為CategoryManager時GroupBox的變動和更新
        /// 步驟:將所有json檔的category當寫到tboDescription label裡
        /// </summary>
        private void CategoryIndexChanged()
        {
            gboManager.Text = "Edit Category";
            tboName.Text = listManager.SelectedItem.ToString();
            string category = "";
            for (int i = 0; i < restaurant.mealModel.mealFoodList[tboName.Text].Count; i++)
            {
                category += restaurant.mealModel.mealFoodList[tboName.Text][i].Name + "\r\n";
            }
            tboDescription.Text = category;
        }

        /// <summary>
        /// listManager(listbox)裡的index變動，且tabPage的index的text為meal時GroupBox的變動和更新
        /// 步驟:將所對應的json檔meal物件裡的各個屬性寫到GroupBox裡的item裡根據listManager index
        /// 顯示的text
        /// </summary>
        private void MealIndexChanged()
        {
            gboManager.Text = "Edit Meal";
            string name = listManager.SelectedItem.ToString();
            tboName.Text = name;
            string pos = ((RestaurantBackened)restaurant).GetCategory(listManager);
            cboCategory.SelectedIndex = ((RestaurantBackened)restaurant).GetComboxIndex(pos);
            tboPrice.Text = restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].UnitPrice.ToString();
            tboPath.Text = restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].MealImgPos;
            tboDescription.Text = restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].MealDescription;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (gboManager.Text.Equals("Edit Meal"))
                EditMeal();
            else if (gboManager.Text.Equals("Add New Meal"))
                AddMeal();
            else if (gboManager.Text.Equals("Edit Category"))
                EditCategory();
            else
                AddCategory();
        }

        /// <summary>
        /// 當btnSave按鈕被按時，且tabPage為Category和gboManager的text為Add Category時,，會增加Category
        /// 且更新listManager items顯示
        /// </summary>
        private void AddCategory()
        {
            restaurant.mealModel.mealFoodList.Add(tboName.Text, new List<Meal>());
            restaurant.WriteJson();
            ReNewTabCategory();
        }

        private void AddMeal()
        {
            restaurant.mealModel.mealFoodList[cboCategory.SelectedItem.ToString()].Add(new Meal()
            {
                Name = tboName.Text,
                UnitPrice = Convert.ToInt32(tboPrice.Text),
                MealDescription = tboDescription.Text,
                MealImgPos = tboPath.Text
            });
            restaurant.WriteJson();
            reNewTabPageContext();
        }

        private void EditCategory()
        {
            try
            {
                string text = listManager.SelectedItem.ToString();
                List<Meal> mealList = new List<Meal>();
                mealList = restaurant.mealModel.mealFoodList[text];
                restaurant.mealModel.mealFoodList.Remove(text);
                restaurant.mealModel.mealFoodList.Add(tboName.Text, mealList);
                restaurant.WriteJson();
                ReNewTabCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditMeal()
        {
            try
            {
                string pos = ((RestaurantBackened)restaurant).GetCategory(listManager);
                restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].Name = tboName.Text;
                restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].UnitPrice = Convert.ToInt32(tboPrice.Text);
                restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].MealDescription = tboDescription.Text;
                restaurant.mealModel.mealFoodList[pos][((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex, listManager)].MealImgPos = tboPath.Text;
                restaurant.WriteJson();
                MessageBox.Show("存檔成功");
                reNewTabPageContext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 當按下btnDelete時，會有兩種情況(tabPage的text為meal或category)分別刪除該meal物件或category該key的物件集合
        /// 步驟:1:if敘述,tabPage index為meal時
        /// 2:tabPage的index為category時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //1
            if(tabMeal.SelectedIndex == 0)
            {
                string pos = ((RestaurantBackened)restaurant).GetCategory(listManager);
                restaurant.mealModel.mealFoodList[pos].RemoveAt(((RestaurantBackened)restaurant).GetStartPoint(listManager.SelectedIndex,listManager));
                restaurant.WriteJson();
                //更新listManager的items
                reNewTabPageContext();
            }
            //2
            else
            {
                if(restaurant.mealModel.mealFoodList.ContainsKey(listManager.SelectedItem.ToString()))
                {
                    MessageBox.Show(listManager.SelectedItem.ToString());
                    restaurant.mealModel.mealFoodList.Remove(listManager.SelectedItem.ToString());
                    restaurant.WriteJson();
                    //更新listManager的items
                    ReNewTabCategory();
                }
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabMeal.SelectedIndex == 0)
            {
                gboManager.Text = "Add New Meal";
                tboDescription.Text = "";
                tboName.Text = "";
                tboPrice.Text = "";
                tboPath.Text = "";
                cboCategory.SelectedIndex = 0;
            }
            else
            {
                tboDescription.Text = "";
                tboName.Text = ""; 
                gboManager.Text = "Add Category";
            }
        }

        private void tabMeal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabPage的index為meal時
            if (tabMeal.SelectedIndex == 0)
            {
                reNewTabPageContext();
                ControlPosReChange();
            }
            //tabPage的index為category時 
            else if (tabMeal.SelectedIndex == 1)
            {
                ReNewTabCategory();
                ControlPosChange();
            }          
        }

        /// <summary>
        /// 當tabMeal的index變動時(該tabPage的text為category),該listManager顯示的items也跟者變動
        /// 步驟:1:將listManager加到tabMeal裡且先清除listManager裡的items
        /// 2:Deserialize json檔的資料到mealModel物件裡
        /// 3:將mealModel物件裡的mealFoodList集合的key都讀到listManager裡
        /// </summary>
        private void ReNewTabCategory()
        {
            //1
            tabMeal.SelectedTab.Controls.Add(listManager);
            listManager.Items.Clear();
            //2
            restaurant.ReadJson();
            //3
            foreach (var item in restaurant.mealModel.mealFoodList.Keys)
            {
                listManager.Items.Add(item);
            }

        }

        /// <summary>
        /// 當tabPage的text為CategoryManager, groupBox裡的items的屬性更新
        /// </summary>
        private void ControlPosChange()
        {
            gboManager.Text = "Edit Category";
            btnAdd.Text = "Add Category";
            btnDelete.Text = "Delete Selected Category";
            label1.Text = "Category Name";
            label6.Text = "Meal Using this category";
            label2.Left -= 5000;
            tboPath.Left -= 5000;
            label4.Left -= 5000;
            cboCategory.Left -= 5000;
            tboPath.Left -= 5000;
            btnBrowse.Left -= 5000;
            label3.Left -= 5000;
            label5.Left -= 5000;
            tboPrice.Left -= 5000;
            label6.Top -= 90;
            tboDescription.Top -= 90;
            tboDescription.Height += 100;
            tboDescription.Text = "";
            tboName.Text = "";
            tboPrice.Text = "";
            tboPath.Text = "";
        }

        /// <summary>
        /// 當tabPage的text為MealManager, groupBox裡的items的屬性更新
        /// </summary>
        private void ControlPosReChange()
        {
            gboManager.Text = "Edit Meal";
            btnAdd.Text = "Add Meal";
            btnDelete.Text = "Delete Selected Meal";
            label1.Text = "Meal Name (*)";
            label6.Text = "Meal Description";
            tboDescription.Text = "";
            tboName.Text = "";
            tboPrice.Text = "";
            tboPath.Text = "";
            label2.Left += 5000;
            tboPath.Left += 5000;
            label4.Left += 5000;
            cboCategory.Left += 5000;
            tboPath.Left += 5000;
            btnBrowse.Left += 5000;
            label3.Left += 5000;
            label5.Left += 5000;
            tboPrice.Left += 5000;
            label6.Top += 90;
            tboDescription.Top += 90;
            tboDescription.Height -= 100;
        }

        /// <summary>
        /// 電腦讀img檔，且儲存該檔路徑到tboPath textBox裡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openImageDialog = new System.Windows.Forms.OpenFileDialog();
            string projectPath =
            Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            _openImageDialog.InitialDirectory = projectPath;
            _openImageDialog.Multiselect = false;
            _openImageDialog.Filter = "Image|*.png;*.jpg;*.jpeg";
            DialogResult result = _openImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                //開啟檔案成功
                tboPath.Text = _openImageDialog.FileName;
            }
            else
            {
                //開啟檔案失敗
                MessageBox.Show("檔案開起失敗");
            }

        }
    }
}
