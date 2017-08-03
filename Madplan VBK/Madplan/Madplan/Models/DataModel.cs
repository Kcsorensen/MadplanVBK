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
                Page = 104,
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
            ListOfDishes.Add(new Dish()
            {
                Name = "Æg med knas",
                Type = DishType.Snack,
                Ratio = 1.9,
                Persons = 1,
                Page = 124,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Græskarkerner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Solsikkekerner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
            });

            // Æg med hytteost og mandler
            ListOfDishes.Add(new Dish()
            {
                Name = "Æg med hytteost og mandler",
                Type = DishType.Snack,
                Ratio = 2.3,
                Persons = 1,
                Page = 126,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
            });

            // Hytteost og æbler med fuldkornspitabrød
            ListOfDishes.Add(new Dish()
            {
                Name = "Hytteost og æbler med fuldkornspitabrød",
                Type = DishType.Snack,
                Ratio = 0.3,
                Persons = 1,
                Page = 128,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Sesamfrø.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fuldkornspitabrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                    },
                }
            });

            // Æble med citron og kakaonibs
            ListOfDishes.Add(new Dish()
            {
                Name = "Æble med citron og kakaonibs",
                Type = DishType.Snack,
                Ratio = 0.8,
                Persons = 1,
                Page = 130,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kakaonibs.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                }
            });

            // Pære med peber og mozzarella
            ListOfDishes.Add(new Dish()
            {
                Name = "Pære med peber og mozzarella",
                Type = DishType.Snack,
                Ratio = 0.6,
                Persons = 1,
                Page = 132,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Pære.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mozzarella.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk,
                    },
                }
            });

            // Kiwi med knæk
            ListOfDishes.Add(new Dish()
            {
                Name = "Kiwi med knæk",
                Type = DishType.Snack,
                Ratio = 0.5,
                Persons = 1,
                Page = 133,
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
                        Name = IngredientHelper.Græskarkerner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kiwi.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
            });

            // Mango, mandler og mynte
            ListOfDishes.Add(new Dish()
            {
                Name = "Mango, mandler og mynte",
                Type = DishType.Snack,
                Ratio = 0.1,
                Persons = 1,
                Page = 134,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mango.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mynte.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.stk,
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk,
                    },

                }
            });


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
            ListOfDishes.Add(new Dish()
            {
                Name = "Kål, kød og ost",
                Type = DishType.Lunch,
                Ratio = 1.1,
                Persons = 1,
                Page = 142,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Emmentaler.GetDescription(),
                        Quantity = 30,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                }
            });

            // Tun, kartofler og æg
            ListOfDishes.Add(new Dish()
            {
                Name = "Tun, kartofler og æg",
                Type = DishType.Lunch,
                Ratio = 1.1,
                Persons = 1,
                Page = 144,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tun.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Radicchio.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kartofler.GetDescription(),
                        Quantity = 4,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
            });

            // Makrel, kål, rugbrød og skyr
            ListOfDishes.Add(new Dish()
            {
                Name = "Makrel, kål, rugbrød og skyr",
                Type = DishType.Lunch,
                Ratio = 0.9,
                Persons = 1,
                Page = 146,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Makrel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
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
                }
            });

            // Korn, bær, hytteost
            ListOfDishes.Add(new Dish()
            {
                Name = "Korn, bær, hytteost",
                Type = DishType.Lunch,
                Ratio = 0.5,
                Persons = 1,
                Page = 148,
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
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Kylling, majs og cornichoner
            ListOfDishes.Add(new Dish()
            {
                Name = "Kylling, majs og cornichoner",
                Type = DishType.Lunch,
                Ratio = 1.3,
                Persons = 1,
                Page = 149,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Oliven.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Cornichoner.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Majs.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Kold tomatsuppe
            ListOfDishes.Add(new Dish()
            {
                Name = "Kold tomatsuppe",
                Type = DishType.Lunch,
                Ratio = 0.3,
                Persons = 1,
                Page = 150,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.HakkedeTomater.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
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
                        Name = IngredientHelper.Hvidløg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tabasco.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.dråbe
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
            });

            // Wontonpakker med hummus og hytteost
            ListOfDishes.Add(new Dish()
            {
                Name = "Wontonpakker med hummus og hytteost",
                Type = DishType.Lunch,
                Ratio = 0.4,
                Persons = 1,
                Page = 152,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hummus.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Wontondej.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.pakke
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Chiafrø.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.tsk
                    },
                }
            });

            // Rugbrød med torskerogn, sennepsskyr og karse
            ListOfDishes.Add(new Dish()
            {
                Name = "Rugbrød med torskerogn, sennepsskyr og karse",
                Type = DishType.Lunch,
                Ratio = 0.4,
                Persons = 1,
                Page = 154,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Torskerogn.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Radiser.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Karse.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                }
            });

            // Amar´mad med hummus
            ListOfDishes.Add(new Dish()
            {
                Name = "Amar´mad med hummus",
                Type = DishType.Lunch,
                Ratio = 0.3,
                Persons = 1,
                Page = 155,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fuldkornsbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hummus.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                }
            });

            // Æggesalat på sprødt brød
            ListOfDishes.Add(new Dish()
            {
                Name = "Æggesalat på sprødt brød",
                Type = DishType.Lunch,
                Ratio = 0.7,
                Persons = 1,
                Page = 156,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Karry.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 2,
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
                        Name = IngredientHelper.Blomkålsbuketter.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rødløg.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
            });

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

            // Kylling med aubergine, tomat og kanel
            ListOfDishes.Add(new Dish()
            {
                Name = "Kylling med aubergine, tomat og kanel",
                Type = DishType.Dinner,
                Ratio = 14.0,
                Persons = 4,
                Page = 164,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.HelKylling.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kanel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Nelliker.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Aubergine.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Kyllingefilet med pærer, druer og ris
            ListOfDishes.Add(new Dish()
            {
                Name = "Kyllingefilet med pærer, druer og ris",
                Type = DishType.Dinner,
                Ratio = 1.1,
                Persons = 1,
                Page = 166,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Pære.GetDescription(),
                        Quantity = 1,
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
                        Name = IngredientHelper.Pecorinoost.GetDescription(),
                        Quantity = 30,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.BruneRis.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.BlåDruer.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mynte.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
            });

            // Kylling med gulerødder
            ListOfDishes.Add(new Dish()
            {
                Name = "Kylling med gulerødder",
                Type = DishType.Dinner,
                Ratio = 0.8,
                Persons = 1,
                Page = 168,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kyllingelår.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æblemost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Laurbærblade.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hvidkål.GetDescription(),
                        Quantity = 80,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                }
            });

            // Laks med avokado, ærter og sesam
            ListOfDishes.Add(new Dish()
            {
                Name = "Laks med avokado, ærter og sesam",
                Type = DishType.Dinner,
                Ratio = 1.1,
                Persons = 1,
                Page = 170,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Laksefilet.GetDescription(),
                        Quantity = 150,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Spidskommen.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Avokado.GetDescription(),
                        Quantity = 1,
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
                        Name = IngredientHelper.FrosneÆrter.GetDescription(),
                        Quantity = 0.75,
                        QuantityType = QuantityType.dl
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fennikel.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Sesamfrø.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Laksefrikadeller med kikærter og kål
            ListOfDishes.Add(new Dish()
            {
                Name = "Laksefrikadeller med kikærter og kål",
                Type = DishType.Dinner,
                Ratio = 0.9,
                Persons = 1,
                Page = 172,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Laksefilet.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Ingegær.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Kikærter.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Hvidkål.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
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
                        Name = IngredientHelper.Spidskommen.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
            });

            // Råsyltet laks med ingefær og lime
            ListOfDishes.Add(new Dish()
            {
                Name = "Råsyltet laks med ingefær og lime",
                Type = DishType.Dinner,
                Ratio = 0.9,
                Persons = 1,
                Page = 174,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Laksefilet.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Ingegær.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Radicchio.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                }
            });

            // Æggepandekage med makrel, tomater og rugbrød
            ListOfDishes.Add(new Dish()
            {
                Name = "Æggepandekage med makrel, tomater og rugbrød",
                Type = DishType.Dinner,
                Ratio = 1.3,
                Persons = 1,
                Page = 176,
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
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Makrel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen
                    },
                }
            });

            // Tun i wasabi med kål, mandler og agurker
            ListOfDishes.Add(new Dish()
            {
                Name = "Tun i wasabi med kål, mandler og agurker",
                Type = DishType.Dinner,
                Ratio = 1.8,
                Persons = 1,
                Page = 178,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.skive
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Wasabi.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 80,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Tun.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
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

            // Torskerogn med surt, æg og salat
            ListOfDishes.Add(new Dish()
            {
                Name = "Torskerogn med surt, æg og salat",
                Type = DishType.Dinner,
                Ratio = 0.8,
                Persons = 1,
                Page = 180,
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
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Torskerogn.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 4,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.SyltedeAsier.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 1,
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
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                }
            });

            // Rejer med chili, grapefrugt og kål
            ListOfDishes.Add(new Dish()
            {
                Name = "Rejer med chili, grapefrugt og kål",
                Type = DishType.Dinner,
                Ratio = 1.4,
                Persons = 1,
                Page = 182,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rødkål.GetDescription(),
                        Quantity = 70,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rejer.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Grapefrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Rødløg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Fishsauce.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
            });

            // Torsk med sennepsrødder
            ListOfDishes.Add(new Dish()
            {
                Name = "Torsk med sennepsrødder",
                Type = DishType.Dinner,
                Ratio = 1.3,
                Persons = 1,
                Page = 184,
                Ingredients = new List<Ingredient>()
                {
                    new Ingredient()
                    {
                        Name = IngredientHelper.Torsk.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Chiafrø.GetDescription(),
                        Quantity = 1,
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
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Knoldselleri.GetDescription(),
                        Quantity = 50,
                        QuantityType = QuantityType.gram
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Jordskok.GetDescription(),
                        Quantity = 1,
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
                        Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Vineddike.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
            });

            // Laks med urter, syrlige agurker og æg 

            // Kødsovs med paste

            // Chili con carne med skyr, æbler og sennep

            // Sprød laks, råt grønt og sellericreme

            // Grønt og rejer i rispapir

            // Frikadeller med rug, ramsløg og salat

            // Torsk og tomatsalat

            // Pizza med frisk grønt og kylligefilet

            // Forårsruller med kål og kød

            // Rodfrugter på panden med chorizopølser

            // Dumblings med fisk og grønt, hertil råkost

            // Kalv i øl og timian

            // Kartofler med æg og salat

            // Edamamebønner med spidskål og dild

            // Kotelet i fad med mynte, kartofler og appelsin

            // Kød med syrlige kartofler og parmesan

            // Fiskefilet med salat

            #endregion

            #region Desserter

            // Honningbruschetta

            // Koldskål

            // Æggesnaps med tørrede bær

            // Trifli med mango, makroner og skyr

            // Marengs med chokolade og frugtskyr

            

            #endregion

            #region Grundopskrifter

            #endregion
        }

    }
}
