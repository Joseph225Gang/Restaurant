using System.Windows.Forms;

namespace MealRestaurant
{
    public class RestaurantFront : RestaurantBehavior
    {
        //tabMeal上顯示的9個按鈕
        public Button[] btnList = new Button[9];
        /// <summary>
        /// 顯示該tabMeal的tabPage的text能顯示多少頁，每頁最多9個buttons
        /// </summary>
        /// <returns></returns>
        public int PageCount()
        {
            int index = -1;
            for (int i = 0; i < btnList.Length; i++)
            {
                ++index;
                if (btnList[i].Visible == false)
                {
                    break;
                }
            }
            return index;
        }
        /// <summary>
        /// 該tabMeal的頁面的button對應到mealFoodList集合裡第幾個(index)meal物件
        /// </summary>
        /// <param name="index"></param>
        /// <param name="tabMeal"></param>
        /// <returns></returns>
        public int GetCurrentPos(int index,TabControl tabMeal)
        {
            int currentPos = 0;
            for (int i = 8; i < mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count; i++)
            {
                if (mealModel.mealFoodList[tabMeal.SelectedTab.Text][i].Name.Equals(btnList[index].Text))
                {
                    currentPos = i;
                    break;
                }
            }
            return currentPos;
        }
        /// <summary>
        /// 匹配該button顯示資訊等於json檔(mealModel物件)裡該category第幾個index物件
        /// </summary>
        /// <param name="text"></param>
        /// <param name="tabMeal"></param>
        /// <returns></returns>
        public int SearchIndex(string text,TabControl tabMeal)
        {
            int index = 0;
            for (int i = 0; i < mealModel.mealFoodList[tabMeal.SelectedTab.Text].Count; i++)
            {
                if (mealModel.mealFoodList[tabMeal.SelectedTab.Text][i].Name.Equals(text))
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }
    }
}
