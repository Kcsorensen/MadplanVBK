using CsvHelper;
using Madplan.Extensions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class DataModel
    {
        public List<Meal> ListOfMeals { get; set; }
        public List<Food> ListOfFood { get; set; }

        public static DataModel Current = new DataModel();

        public DataModel()
        {
            ListOfMeals = new List<Meal>();
            ListOfFood = new List<Food>();
        }

        public async Task PopulateListOfMealsAsync()
        {
            await Task.Run(() => 
            {
                #region Morgenmad

                // Hvid æggepandekage med rød peber og ost
                ListOfMeals.Add(new Meal()
                {
                    Name = "Hvid æggepandekage med rød peber og ost",
                    Type = MealType.Breakfast,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Æggepandekage med skinke og ost",
                    Type = MealType.Breakfast,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Skyr med Granola",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Klapsammen med nøddespread og æg",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Grovpita med skinke, gulerødder og hytteost",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Ruggrød med æblemost og nødder",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Knækbrød med æg og hytteost",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Pink grød med solbær",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Grød \"to go\"",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Syrnet mysli",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Søndag morgen",
                    Type = MealType.Breakfast,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Søndag morgen",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Røgbrød med AC-spread",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Nøddespread på knækbrød",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Æg med knas",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Æg med hytteost og mandler",
                    Type = MealType.Snack,
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
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Hytteost og æbler med fuldkornspitabrød",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Æble med citron og kakaonibs",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Pære med peber og mozzarella",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kiwi med knæk",
                    Type = MealType.Snack,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Mango, mandler og mynte",
                    Type = MealType.Snack,
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
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Fennikel, parmaskinke og mandler",
                    Type = MealType.Lunch,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Korn, aguark, nødder og urter",
                    Type = MealType.Lunch,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kål, kød og ost",
                    Type = MealType.Lunch,
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
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Tun, kartofler og æg
                ListOfMeals.Add(new Meal()
                {
                    Name = "Tun, kartofler og æg",
                    Type = MealType.Lunch,
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
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Makrel, kål, rugbrød og skyr",
                    Type = MealType.Lunch,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Korn, bær, hytteost",
                    Type = MealType.Lunch,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Ingredient()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kylling, majs og cornichoner",
                    Type = MealType.Lunch,
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
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Kold tomatsuppe
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kold tomatsuppe",
                    Type = MealType.Lunch,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Wontonpakker med hummus og hytteost",
                    Type = MealType.Lunch,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Rugbrød med torskerogn, sennepsskyr og karse",
                    Type = MealType.Lunch,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Amar´mad med hummus
                ListOfMeals.Add(new Meal()
                {
                    Name = "Amar´mad med hummus",
                    Type = MealType.Lunch,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Æggesalat på sprødt brød",
                    Type = MealType.Lunch,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Korn, aguark, nødder og urter",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kyllingelår med rødder, lakrids og linser",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kylling med aubergine, tomat og kanel",
                    Type = MealType.Dinner,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Kyllingefilet med pærer, druer og ris
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kyllingefilet med pærer, druer og ris",
                    Type = MealType.Dinner,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kylling med gulerødder",
                    Type = MealType.Dinner,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Laks med avokado, ærter og sesam
                ListOfMeals.Add(new Meal()
                {
                    Name = "Laks med avokado, ærter og sesam",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Laksefrikadeller med kikærter og kål",
                    Type = MealType.Dinner,
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
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Råsyltet laks med ingefær og lime",
                    Type = MealType.Dinner,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Æggepandekage med makrel, tomater og rugbrød
                ListOfMeals.Add(new Meal()
                {
                    Name = "Æggepandekage med makrel, tomater og rugbrød",
                    Type = MealType.Dinner,
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
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Tun i wasabi med kål, mandler og agurker
                ListOfMeals.Add(new Meal()
                {
                    Name = "Tun i wasabi med kål, mandler og agurker",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Torskerogn med surt, æg og salat",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Rejer med chili, grapefrugt og kål",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Torsk med sennepsrødder",
                    Type = MealType.Dinner,
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
                ListOfMeals.Add(new Meal()
                {
                    Name = "Laks med urter, syrlige agurker og æg",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 186,
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
                            Name = IngredientHelper.Purløg.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Basilikum.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Persille.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Æbleeddike.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Agurk.GetDescription(),
                            Quantity = 0.24,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rugkerner.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                    }
                });

                // Kødsovs med paste
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kødsovs med paste",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 2,
                    Page = 188,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.HakketOksekød.GetDescription(),
                            Quantity = 250,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Hvidløg.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.FlåedeTomater.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dåse,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.GrønneLinser.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.GrovPasta.GetDescription(),
                            Quantity = 80,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Parmesanost.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Knoldselleri.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram
                        },
                    }
                });

                // Chili con carne med skyr, æbler og sennep
                ListOfMeals.Add(new Meal()
                {
                    Name = "Chili con carne med skyr, æbler og sennep",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 2,
                    Page = 190,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.HakketOksekød.GetDescription(),
                            Quantity = 250,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Hvidløg.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Chili.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Bønner.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dåse
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Øl.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Chokolade.GetDescription(),
                            Quantity = 20,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødkål.GetDescription(),
                            Quantity = 200,
                            QuantityType = QuantityType.gram
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
                            Name = IngredientHelper.Dijonsennep.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                    }
                });

                // Sprød torsk, råt grønt og sellericreme
                ListOfMeals.Add(new Meal()
                {
                    Name = "Sprød torsk, råt grønt og sellericreme",
                    Type = MealType.Dinner,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 192,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Selleri.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 120,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Persillerod.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødbeder.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                    }
                });

                // Grønt og rejer i rispapir
                ListOfMeals.Add(new Meal()
                {
                    Name = "Grønt og rejer i rispapir",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 194,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rejer.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Forårsløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Peberfrugt.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Basilikum.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Fennikel.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Sesamfrø.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rispapir.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.plade
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Fishsauce.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Lime.GetDescription(),
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
                            Name = IngredientHelper.Chili.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.SaltedePeanuts.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Jordnøddeolie.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                    }
                });

                // Frikadeller med rug, ramsløg og salat
                ListOfMeals.Add(new Meal()
                {
                    Name = "Frikadeller med rug, ramsløg og salat",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 4,
                    Page = 196,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.HakketKalvOgOkse.GetDescription(),
                            Quantity = 500,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 3,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Mælk.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rugflager.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Æblemost.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Hvidløg.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rapsolie.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Edamamebønner.GetDescription(),
                            Quantity = 100,
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
                            Name = IngredientHelper.Honning.GetDescription(),
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
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 80,
                            QuantityType = QuantityType.gram
                        },
                    }
                });

                // Torsk og tomatsalat
                ListOfMeals.Add(new Meal()
                {
                    Name = "Torsk og tomatsalat",
                    Type = MealType.Dinner,
                    Ratio = 1.02,
                    Persons = 1,
                    Page = 198,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 150,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Tomat.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Persille.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rugkerner.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Oliven.GetDescription(),
                            Quantity = 7,
                            QuantityType = QuantityType.stk
                        },
                    }
                });

                // Pizza med frisk grønt og kylligefilet
                ListOfMeals.Add(new Meal()
                {
                    Name = "Pizza med frisk grønt og kylligefilet",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 200,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Pizza.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Kyllingbryst.GetDescription(),
                            Quantity = 120,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 150,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Basilikum.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                    }
                });

                // Forårsruller med kål og kød
                ListOfMeals.Add(new Meal()
                {
                    Name = "Forårsruller med kål og kød",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 2,
                    Page = 202,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Kyllingbryst.GetDescription(),
                            Quantity = 200,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødkål.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Ingegær.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Mandler.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Sojasovs.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Forårsrulledej.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.plade,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                    }
                });

                // Rodfrugter på panden med chorizopølser
                ListOfMeals.Add(new Meal()
                {
                    Name = "Rodfrugter på panden med chorizopølser",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 204,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Chorizopølser.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Persillerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk,
                        },
                    }
                });

                // Dumblings med fisk og grønt, hertil råkost
                ListOfMeals.Add(new Meal()
                {
                    Name = "Dumblings med fisk og grønt, hertil råkost",
                    Type = MealType.Dinner,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 206,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Blomkålsbuketter.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Broccoli.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Wontondej.GetDescription(),
                            Quantity = 5,
                            QuantityType = QuantityType.plade,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Sojasovs.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Mandler.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                    }
                });

                // Kalv i øl og timian
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kalv i øl og timian",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 208,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Kalvekotelet.GetDescription(),
                            Quantity = 300,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Broccoli.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Timian.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Dijonsennep.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Radicchio.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Øl.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Fuldkornsbrød.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.skive,
                        },
                    }
                });

                // Kartofler med æg og salat
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kartofler med æg og salat",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 210,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Hjertesalat.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Kartofler.GetDescription(),
                            Quantity = 80,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Forårsløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Vineddike.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.stk,
                        },
                    }
                });

                // Edamamebønner med spidskål og dild
                ListOfMeals.Add(new Meal()
                {
                    Name = "Edamamebønner med spidskål og dild",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 212,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Edamamebønner.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.pose
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Hytteost.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                    }
                });

                // Kotelet i fad med mynte, kartofler og appelsin
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kotelet i fad med mynte, kartofler og appelsin",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 214,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.RødAppelsin.GetDescription(),
                            Quantity = 0.0,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Mynte.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Kartofler.GetDescription(),
                            Quantity = 75,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Svinekotelet.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Sojasovs.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Mandler.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk,
                        },
                    }
                });

                // Kød med syrlige kartofler og parmesan
                ListOfMeals.Add(new Meal()
                {
                    Name = "Kød med syrlige kartofler og parmesan",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 216,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Oksebøf.GetDescription(),
                            Quantity = 150,
                            QuantityType = QuantityType.gram
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Kartofler.GetDescription(),
                            Quantity = 6,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Eddike.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.dl,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Rosmarin.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Parmesanost.GetDescription(),
                            Quantity = 20,
                            QuantityType = QuantityType.gram,
                        },
                    }
                });

                // Fiskefilet med salat
                ListOfMeals.Add(new Meal()
                {
                    Name = "Fiskefilet med salat",
                    Type = MealType.Dinner,
                    Ratio = 1.7,
                    Persons = 1,
                    Page = 218,
                    Ingredients = new List<Ingredient>()
                    {
                        new Ingredient()
                        {
                            Name = IngredientHelper.Fiskefilet.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Mysli.GetDescription(),
                            Quantity = 25,
                            QuantityType = QuantityType.gram,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Radicchio.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Drueagurker.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk,
                        },
                        new Ingredient()
                        {
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                    }
                });

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
            });
        }

        public void ReadCsvFile()
        {
            var assembly = typeof(DataModel).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("Madplan.Resources.FoodDatabase.csv");

            string text;

            // Der bruges Encoding.GetEncoding("iso-8859-1") for at den læser ÆØÅ korrekt
            using (var reader = new System.IO.StreamReader(stream, Encoding.GetEncoding("iso-8859-1")))
            {
                text = reader.ReadToEnd();
            }

            TextReader sr = new StringReader(text);

            var csv = new CsvReader(sr);
            csv.Configuration.Delimiter = ";";

            int counter = 0;

            while (csv.Read())
            {
                if (counter > 0)
                {
                    ListOfFood.Add(new Food()
                    {
                        Navn = csv.GetField<string>(0),

                        FoodId = csv.GetField<int>(1),

                        Svind = csv.GetField<string>(2).ConvertToDouble(),

                        EnergiKj = csv.GetField<string>(3).ConvertToDouble(),
                        EnergiKcal = csv.GetField<string>(4).ConvertToDouble(),

                        ProteinTotal = csv.GetField<string>(7).ConvertToDouble(),
                        ProteinDeklaration = csv.GetField<string>(8).ConvertToDouble(),

                        KulhydratDifferens = csv.GetField<string>(9).ConvertToDouble(),
                        KulhydratTilgaengelig = csv.GetField<string>(10).ConvertToDouble(),
                        KulhydratDeklaration = csv.GetField<string>(11).ConvertToDouble(),
                        SukkerarterIalt = csv.GetField<string>(95).ConvertToDouble(),
                        TilsatSukker = csv.GetField<string>(12).ConvertToDouble(),

                        Kostfiber = csv.GetField<string>(13).ConvertToDouble(),

                        FedtTotal = csv.GetField<string>(14).ConvertToDouble(),

                        Vand = csv.GetField<string>(19).ConvertToDouble(),
                        Avitamin = csv.GetField<string>(20).ConvertToDouble(),
                        Dvitamin = csv.GetField<string>(23).ConvertToDouble(),
                        Evitamin = csv.GetField<string>(26).ConvertToDouble(),
                        Cvitamin = csv.GetField<string>(44).ConvertToDouble(),

                        Natrium = csv.GetField<string>(48).ConvertToDouble(),
                        Kalium = csv.GetField<string>(49).ConvertToDouble(),
                        Calcium = csv.GetField<string>(50).ConvertToDouble(),
                        Magnesium = csv.GetField<string>(51).ConvertToDouble(),
                        Jern = csv.GetField<string>(53).ConvertToDouble(),

                        Glycose = csv.GetField<string>(87).ConvertToDouble(),

                        Cholesterol = csv.GetField<string>(162).ConvertToDouble(),
                    });
                }

                counter++;
            }
        }
    }
}
