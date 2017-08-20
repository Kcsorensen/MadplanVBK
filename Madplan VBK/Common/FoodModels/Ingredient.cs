using Common.Extensions;

namespace Common.FoodModels
{
    public class Ingredient : BaseModel
    {
        public double Quantity { get; set; }
        public double QuantityType { get; set; }

        public bool QuantityVisible { get; set; }
        public bool BasicRecipe { get; set; }
        public bool ShoppingListChecked { get; set; }

        public Food Food { get; set; }

        public Ingredient(Food food)
        {
            Food = food;
        }
    }
}
