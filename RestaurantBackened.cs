using System.Linq;
using System.Windows.Forms;

namespace MealRestaurant
{
    public class RestaurantBackened : RestaurantBehavior
    {
        /// <summary>
        /// 得到Combox裡所對應的index(category)
        /// </summary>
        /// <param name="pos">Category的text</param>
        /// <returns></returns>
        public int GetComboxIndex(string pos)
        {
            int index = 0;
            foreach (var item in mealModel.mealFoodList.Keys)
            {
                if (item.Equals(pos))
                {
                    return index;
                }
                index++;
            }
            return index;
        }

        /// <summary>
        ///  取得該listmanager的index對應到mealFoodList集合該category的物件陣列裡第幾個index物件
        /// 步驟: 1:listManager顯示的點餐資訊是由category index(0),category index(1)的線性表示，所以迴圈
        /// mealFoodList集合裡的key(category)，將每個key的item(物件)count加到sum變數，若
        /// listmanager的index小於sum變數，則中斷迴圈，若沒有則將sum變數賦值給index變數，
        /// 繼續迴圈。最後將listmanager的index減掉index變數就會等於mealFoodList集合該
        /// category的物件陣列的第index meal物件
        /// </summary>
        /// <param name="pos">listmanager點擊的index</param>
        /// <param name="listManager"></param>
        /// <returns></returns>
        public int GetStartPoint(int pos, ListBox listManager)
        {
            int index = 0;
            int sum = 0;
            foreach (var item in mealModel.mealFoodList.Keys)
            {
                sum += mealModel.mealFoodList[item].Count;
                if (pos < sum)
                    break;
                else
                    index += sum;
            }
            return listManager.SelectedIndex - index;
        }
        public string GetCategory(ListBox listManager)
        {
            string name = listManager.SelectedItem.ToString();
            var pos =
                from p in mealModel.mealFoodList.Keys
                where mealModel.mealFoodList[p][GetStartPoint(listManager.SelectedIndex,listManager)].Name.Equals(name)
                select p;
            return pos.FirstOrDefault();
        }
    }
}
