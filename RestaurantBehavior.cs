using Newtonsoft.Json;
using System.IO;

namespace MealRestaurant
{
    public class RestaurantBehavior
    {
        public Model mealModel { get; set; }
        public string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));

        public RestaurantBehavior()
        {
            this.mealModel = new Model();
        }

        /// <summary>
        /// 將json檔的資料deserialize到mealModel物件裡
        /// </summary>
        public void ReadJson()
        {
            string mealJson = File.ReadAllText(projectPath + "/Resource/mealModel.json");
            this.mealModel = JsonConvert.DeserializeObject<Model>(mealJson);
        }

        /// <summary>
        /// 將mealModel物件Serialize到json檔裡
        /// </summary>
        public void WriteJson()
        {
            string mealJson = JsonConvert.SerializeObject(this.mealModel);
            File.WriteAllText(projectPath + "/Resource/mealModel.json", mealJson);
        }
    }
}
