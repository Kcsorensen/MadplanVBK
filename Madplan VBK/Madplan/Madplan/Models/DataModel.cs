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
            ListOfDishes.Add(new Dish()
            {
                Name = "Grovpita med skinke, gulerødder og hytteost",
                Type = DishType.Morgenmad,
                Ratio = 0.6,
                Persons = 1,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Pitabrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.Stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.Stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.Spsk
                    },
                }
            });

            // Ruggrød med æblemost og nødder
            ListOfDishes.Add(new Dish()
            {
                Name = "Ruggrød med æblemost og nødder",
                Type = DishType.Morgenmad,
                Ratio = 0.2,
                Persons = 1,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugflager.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æblemost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.Stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.Spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.Spsk
                    },
                }
            });

            // Knækbrød med æg og hytteost

            // Pink grød med solbør

            // Grød "to go"

            // Syrnet mysli

            // Søndag morgen

            #endregion


            #region Mellemmåltider

            // Rugbolle med chokolade

            // Gulerødder med grønne ærter

            // Røgbrød med AC-spread

            // Nøddespread på knækbrød

            // Æg med knas

            // Æg med hytteost og mandler

            // Hytteost og æbler med fuldkornspitabrød

            // Æble med citron og kakaonibs

            // Pære med peber og mozzarella

            // Kiwi med knæk

            // Mango, mandler og mynte

            #endregion

            #region Frokost

            // Fennikel, parmaskinke og mandler 

            // Korn, aguark, nødder og urter 

            // Kål, kød og ost

            // Tun, kartofler og æg

            // Makrel, kål, rugbrød og skyr

            // Korn, bær, hytteost

            // Kylling, majs og cornichoner

            // Kold tomatsuppe

            // Wontonpakker med hummus og hytteost

            // Rugbrød med torskerogn, sennepsskyr og karse

            // Amar´mad med hummus

            // Æggesalat på sprødt brød

            #endregion

            #region Aftensmåltider


            #endregion

            #region Aftensmåltider

            #endregion

            #region Desserter

            #endregion

            #region Grundopskrifter

            #endregion
        }

    }
}
