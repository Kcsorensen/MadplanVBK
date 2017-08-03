using Madplan.Extensions;
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
                Type = DishType.Breakfast,
                Ratio = 0.9,
                Persons = 1,
                Page = 96,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Friskæggehvide.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.RevetOst.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Æggepandekage med skinke og ost
            ListOfDishes.Add(new Dish()
            {
                Name = "Æggepandekage med skinke og ost",
                Type = DishType.Breakfast,
                Ratio = 0.7,
                Persons = 1,
                Page = 98,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.RevetOst.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
            });

            // Skyr med Granola
            ListOfDishes.Add(new Dish()
            {
                Name = "Skyr med Granola",
                Type = DishType.Breakfast,
                Ratio = 0.6,
                Persons = 1,
                Page = 100,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1.5,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Granola.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
            });

            // Klapsammen med nøddespread og æg
            ListOfDishes.Add(new Dish()
            {
                Name = "Klapsammen med nøddespread og æg",
                Type = DishType.Breakfast,
                Ratio = 0.3,
                Persons = 1,
                Page = 101,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Nøddepread.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
            });

            // Grovpita med skinke, gulerødder og hytteost
            ListOfDishes.Add(new Dish()
            {
                Name = "Grovpita med skinke, gulerødder og hytteost",
                Type = DishType.Breakfast,
                Ratio = 0.6,
                Persons = 1,
                Page = 102,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Pitabrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
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
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Ruggrød med æblemost og nødder
            ListOfDishes.Add(new Dish()
            {
                Name = "Ruggrød med æblemost og nødder",
                Type = DishType.Breakfast,
                Ratio = 0.2,
                Persons = 1,
                Page = 102,
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
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Knækbrød med æg og hytteost
            ListOfDishes.Add(new Dish()
            {
                Name = "Knækbrød med æg og hytteost",
                Type = DishType.Breakfast,
                Ratio = 0.4,
                Persons = 1,
                Page = 106,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fuldkornsknækbrød.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 6,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Pink grød med solbær
            ListOfDishes.Add(new Dish()
            {
                Name = "Pink grød med solbær",
                Type = DishType.Breakfast,
                Ratio = 0.3,
                Persons = 1,
                Page = 108,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Solbærsaft.GetDescription(),
                        Quantity =0.5,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },

                }
            });

            // Grød "to go"
            ListOfDishes.Add(new Dish()
            {
                Name = "Grød \"to go\"",
                Type = DishType.Breakfast,
                Ratio = 0.4,
                Persons = 1,
                Page = 110,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Chiafrø.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 0.75,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kanel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.knsp
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 5,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citronskal.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },

                }
            });

            // Syrnet mysli
            ListOfDishes.Add(new Dish()
            {
                Name = "Syrnet mysli",
                Type = DishType.Breakfast,
                Ratio = 0.4,
                Persons = 2,
                Page = 112,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mælk.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Bær.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Søndag morgen
            ListOfDishes.Add(new Dish()
            {
                Name = "Søndag morgen",
                Type = DishType.Breakfast,
                Ratio = 0.8,
                Persons = 1,
                Page = 114,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hummus.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Granola.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
            });

            #endregion

            #region Mellemmåltider

            // Rugbolle med chokolade

            // Gulerødder med grønne ærter
            ListOfDishes.Add(new Dish()
            {
                Name = "Søndag morgen",
                Type = DishType.Snack,
                Ratio = 0.5,
                Persons = 1,
                Page = 120,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.TørrendeGrønneÆrter.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hvidløg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Spidskommen.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Græskarkerner.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                }
            });

            // Røgbrød med AC-spread
            ListOfDishes.Add(new Dish()
            {
                Name = "Røgbrød med AC-spread",
                Type = DishType.Snack,
                Ratio = 0.3,
                Persons = 1,
                Page = 122,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.ACspread.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
            });

            // Nøddespread på knækbrød
            ListOfDishes.Add(new Dish()
            {
                Name = "Nøddespread på knækbrød",
                Type = DishType.Snack,
                Ratio = 0.2,
                Persons = 1,
                Page = 123,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fuldkornsknækbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Nøddepread.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
            });

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
            ListOfDishes.Add(new Dish()
            {
                Name = "Fennikel, parmaskinke og mandler",
                Type = DishType.Lunch,
                Ratio = 0.5,
                Persons = 1,
                Page = 138,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fennikel.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Parmaskinke.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                }
            });

            // Korn, aguark, nødder og urter 
            ListOfDishes.Add(new Dish()
            {
                Name = "Korn, aguark, nødder og urter",
                Type = DishType.Lunch,
                Ratio = 0.6,
                Persons = 1,
                Page = 140,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugkerner.GetDescription(),
                        Quantity = 50,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fishsauce.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Basilikum.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skæreost.GetDescription(),
                        Quantity = 30,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æbleeddike.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

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

            // Wrap med kylling, kål og karry
            ListOfDishes.Add(new Dish()
            {
                Name = "Korn, aguark, nødder og urter",
                Type = DishType.Dinner,
                Ratio = 1.0,
                Persons = 1,
                Page = 160,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fuldkornswrap.GetDescription(),
                        Quantity = 50,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Karry.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tabasco.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                }
            });

            // Kyllingelår med rødder, lakrids og linser
            ListOfDishes.Add(new Dish()
            {
                Name = "Kyllingelår med rødder, lakrids og linser",
                Type = DishType.Dinner,
                Ratio = 1.0,
                Persons = 1,
                Page = 162,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kyllingelår.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Lakridspulver.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.GrønneLinser.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Timian.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
            });

            #endregion

            #region Desserter

            #endregion

            #region Grundopskrifter

            #endregion
        }

    }
}
