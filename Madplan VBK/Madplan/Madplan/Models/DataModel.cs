using System.Collections.Generic;

namespace Madplan.Models
{
    public class DataModel
    {
        public List<Dish> ListOfDishes { get; set; }

        public DataModel()
        {
            ListOfDishes = new List<Dish>();
        }

        public void PopulateListOfDishes()
        {

            #region Morgenmad

            // Hvid æggepandekage med rød peber og ost
            ListOfDishes.Add(new Dish()
            {
                Name = "Hvid æggepandekage med rød peber og ost",
                Type = DishType.Morgenmad,
                Ratio = 0.9,
                Persons = 1,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Friskæggehvide.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Salt.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Peber.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.GrovvalsedeHavregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.Spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.Stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.RevetOst.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Spsk
                    },
                }
            });

            // Æggepandekage med skinke og ost
            ListOfDishes.Add(new Dish()
            {
                Name = "Æggepandekage med skinke og ost",
                Type = DishType.Morgenmad,
                Ratio = 0.7,
                Persons = 1,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Salt.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Peber.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.GrovvalsedeHavregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.Spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.RevetOst.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.Skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.Stk
                    },
                }
            });

            // Skyr med Granola

            // Klapsammen med nøddespread og æg

            // Grovpita med skinke, gulerødder og hytteost

            // Ruggrød med æblemost og nødder

            // Knækbrød med æg og hytteost

            #endregion


        }

    }
}
