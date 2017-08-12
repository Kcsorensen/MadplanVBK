using CsvHelper;
using Madplan.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Madplan.Models
{
    public class DataModel
    {
        public ObservableCollection<Recipe> ListOfRecipes { get; set; }
        public ObservableCollection<Food> ListOfFood { get; set; }

        public static DataModel Current = new DataModel();

        public DataModel()
        {
            ListOfRecipes = new ObservableCollection<Recipe>();
            ListOfFood = new ObservableCollection<Food>();
        }

        public async Task PopulateListOfRecipesAsync()
        {
            await Task.Run(() => 
            {
                #region Morgenmad

                // Hvid æggepandekage med rød peber og ost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Hvid æggepandekage med rød peber og ost",
                    Type = MealType.Breakfast,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 96,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Friskæggehvide.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.RevetOst.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Æggepandekage med skinke og ost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Æggepandekage med skinke og ost",
                    Type = MealType.Breakfast,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 98,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.RevetOst.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
                });

                // Skyr med Granola
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Skyr med Granola",
                    Type = MealType.Breakfast,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 100,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1.5,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Granola.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
                });

                // Klapsammen med nøddespread og æg
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Klapsammen med nøddespread og æg",
                    Type = MealType.Breakfast,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 101,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Nøddepread.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
                });

                // Grovpita med skinke, gulerødder og hytteost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Grovpita med skinke, gulerødder og hytteost",
                    Type = MealType.Breakfast,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 102,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Pitabrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Ruggrød med æblemost og nødder
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Ruggrød med æblemost og nødder",
                    Type = MealType.Breakfast,
                    Ratio = 0.2,
                    Persons = 1,
                    Page = 104,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugflager.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æblemost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Knækbrød med æg og hytteost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Knækbrød med æg og hytteost",
                    Type = MealType.Breakfast,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 106,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Fuldkornsknækbrød.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 6,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Pink grød med solbær
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Pink grød med solbær",
                    Type = MealType.Breakfast,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 108,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Solbærsaft.GetDescription(),
                        Quantity =0.5,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },

                }
                });

                // Grød "to go"
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Grød \"to go\"",
                    Type = MealType.Breakfast,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 110,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Chiafrø.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 0.75,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kanel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.knsp
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 5,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citronskal.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },

                }
                });

                // Syrnet mysli
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Syrnet mysli",
                    Type = MealType.Breakfast,
                    Ratio = 0.4,
                    Persons = 2,
                    Page = 112,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Mælk.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Havregryn.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Bær.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Søndag morgen
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Søndag morgen",
                    Type = MealType.Breakfast,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 114,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hummus.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skinke.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
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
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Søndag morgen",
                    Type = MealType.Snack,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 120,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.TørrendeGrønneÆrter.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hvidløg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskommen.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Græskarkerner.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                }
                });

                // Røgbrød med AC-spread
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Røgbrød med AC-spread",
                    Type = MealType.Snack,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 122,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.ACspread.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
                });

                // Nøddespread på knækbrød
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Nøddespread på knækbrød",
                    Type = MealType.Snack,
                    Ratio = 0.2,
                    Persons = 1,
                    Page = 123,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Fuldkornsknækbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Nøddepread.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                        BasicRecipe = true
                    },
                }
                });

                // Æg med knas
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Æg med knas",
                    Type = MealType.Snack,
                    Ratio = 1.9,
                    Persons = 1,
                    Page = 124,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Græskarkerner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Solsikkekerner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
                });

                // Æg med hytteost og mandler
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Æg med hytteost og mandler",
                    Type = MealType.Snack,
                    Ratio = 2.3,
                    Persons = 1,
                    Page = 126,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
                });

                // Hytteost og æbler med fuldkornspitabrød
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Hytteost og æbler med fuldkornspitabrød",
                    Type = MealType.Snack,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 128,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sesamfrø.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fuldkornspitabrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk,
                    },
                }
                });

                // Æble med citron og kakaonibs
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Æble med citron og kakaonibs",
                    Type = MealType.Snack,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 130,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Æble.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kakaonibs.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                }
                });

                // Pære med peber og mozzarella
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Pære med peber og mozzarella",
                    Type = MealType.Snack,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 132,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Pære.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mozzarella.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk,
                    },
                }
                });

                // Kiwi med knæk
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kiwi med knæk",
                    Type = MealType.Snack,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 133,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Græskarkerner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk,
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kiwi.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk,
                    },
                }
                });

                // Mango, mandler og mynte
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Mango, mandler og mynte",
                    Type = MealType.Snack,
                    Ratio = 0.1,
                    Persons = 1,
                    Page = 134,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Mango.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mynte.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.stk,
                    },
                    new Food()
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
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Fennikel, parmaskinke og mandler",
                    Type = MealType.Lunch,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 138,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Fennikel.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Parmaskinke.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                }
                });

                // Korn, aguark, nødder og urter 
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Korn, aguark, nødder og urter",
                    Type = MealType.Lunch,
                    Ratio = 0.6,
                    Persons = 1,
                    Page = 140,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugkerner.GetDescription(),
                        Quantity = 50,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hasselnødder.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fishsauce.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Basilikum.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skæreost.GetDescription(),
                        Quantity = 30,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æbleeddike.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Kål, kød og ost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kål, kød og ost",
                    Type = MealType.Lunch,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 142,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Emmentaler.GetDescription(),
                        Quantity = 30,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Tun, kartofler og æg
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Tun, kartofler og æg",
                    Type = MealType.Lunch,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 144,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Tun.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Radicchio.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kartofler.GetDescription(),
                        Quantity = 4,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
                });

                // Makrel, kål, rugbrød og skyr
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Makrel, kål, rugbrød og skyr",
                    Type = MealType.Lunch,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 146,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Makrel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                }
                });

                // Korn, bær, hytteost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Korn, bær, hytteost",
                    Type = MealType.Lunch,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 148,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugkerner.GetDescription(),
                        Quantity = 50,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rapsolie.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rosiner.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Kylling, majs og cornichoner
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kylling, majs og cornichoner",
                    Type = MealType.Lunch,
                    Ratio = 1.3,
                    Persons = 1,
                    Page = 149,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Oliven.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Cornichoner.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Majs.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Kold tomatsuppe
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kold tomatsuppe",
                    Type = MealType.Lunch,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 150,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.HakkedeTomater.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Basilikum.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hvidløg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tabasco.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.dråbe
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
                });

                // Wontonpakker med hummus og hytteost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Wontonpakker med hummus og hytteost",
                    Type = MealType.Lunch,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 152,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Hummus.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Wontondej.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.pakke
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Chiafrø.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hytteost.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.tsk
                    },
                }
                });

                // Rugbrød med torskerogn, sennepsskyr og karse
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Rugbrød med torskerogn, sennepsskyr og karse",
                    Type = MealType.Lunch,
                    Ratio = 0.4,
                    Persons = 1,
                    Page = 154,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Torskerogn.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Radiser.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Karse.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Amar´mad med hummus
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Amar´mad med hummus",
                    Type = MealType.Lunch,
                    Ratio = 0.3,
                    Persons = 1,
                    Page = 155,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Fuldkornsbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hummus.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                }
                });

                // Æggesalat på sprødt brød
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Æggesalat på sprødt brød",
                    Type = MealType.Lunch,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 156,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Karry.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Blomkålsbuketter.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rødløg.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
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
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Korn, aguark, nødder og urter",
                    Type = MealType.Dinner,
                    Ratio = 1.0,
                    Persons = 1,
                    Page = 160,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Fuldkornswrap.GetDescription(),
                        Quantity = 50,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Peberfrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Karry.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tabasco.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                }
                });

                // Kyllingelår med rødder, lakrids og linser
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kyllingelår med rødder, lakrids og linser",
                    Type = MealType.Dinner,
                    Ratio = 1.0,
                    Persons = 1,
                    Page = 162,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingelår.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lakridspulver.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.GrønneLinser.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Timian.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
                });

                // Kylling med aubergine, tomat og kanel
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kylling med aubergine, tomat og kanel",
                    Type = MealType.Dinner,
                    Ratio = 14.0,
                    Persons = 4,
                    Page = 164,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.HelKylling.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kanel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Nelliker.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Aubergine.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Kyllingefilet med pærer, druer og ris
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kyllingefilet med pærer, druer og ris",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 166,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Pære.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Pecorinoost.GetDescription(),
                        Quantity = 30,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.BruneRis.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.BlåDruer.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mynte.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingbryst.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                }
                });

                // Kylling med gulerødder
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kylling med gulerødder",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 168,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Kyllingelår.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æblemost.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Laurbærblade.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hvidkål.GetDescription(),
                        Quantity = 80,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Laks med avokado, ærter og sesam
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Laks med avokado, ærter og sesam",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 170,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Laksefilet.GetDescription(),
                        Quantity = 150,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskommen.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Avokado.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.FrosneÆrter.GetDescription(),
                        Quantity = 0.75,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fennikel.GetDescription(),
                        Quantity = 0.25,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sesamfrø.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Laksefrikadeller med kikærter og kål
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Laksefrikadeller med kikærter og kål",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 172,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Laksefilet.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Ingegær.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Kikærter.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Olivenolie.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Hvidkål.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dl
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskommen.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                }
                });

                // Råsyltet laks med ingefær og lime
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Råsyltet laks med ingefær og lime",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 174,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Laksefilet.GetDescription(),
                        Quantity = 120,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Ingegær.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Lime.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Radicchio.GetDescription(),
                        Quantity = 3,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dild.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Æggepandekage med makrel, tomater og rugbrød
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Æggepandekage med makrel, tomater og rugbrød",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 1,
                    Page = 176,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tomat.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Gulerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Makrel.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persille.GetDescription(),
                        Quantity = 0,
                        QuantityType = QuantityType.Ingen,
                        QuantityVisible = false
                    },
                }
                });

                // Tun i wasabi med kål, mandler og agurker
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Tun i wasabi med kål, mandler og agurker",
                    Type = MealType.Dinner,
                    Ratio = 1.8,
                    Persons = 1,
                    Page = 178,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Agurk.GetDescription(),
                        Quantity = 10,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Wasabi.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Spidskål.GetDescription(),
                        Quantity = 80,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Tun.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Skyr.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Torskerogn med surt, æg og salat
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Torskerogn med surt, æg og salat",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 180,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rugbrød.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.skive
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Dijonsennep.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Torskerogn.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.dåse
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Drueagurker.GetDescription(),
                        Quantity = 4,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.SyltedeAsier.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Æg.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Persillerod.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Honning.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.tsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Citron.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                }
                });

                // Rejer med chili, grapefrugt og kål
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Rejer med chili, grapefrugt og kål",
                    Type = MealType.Dinner,
                    Ratio = 1.4,
                    Persons = 1,
                    Page = 182,
                    Ingredients = new ObservableCollection<Food>()
                {
                    new Food()
                    {
                        Name = IngredientHelper.Rødkål.GetDescription(),
                        Quantity = 70,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Chili.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rejer.GetDescription(),
                        Quantity = 100,
                        QuantityType = QuantityType.gram
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Grapefrugt.GetDescription(),
                        Quantity = 0.5,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Rødløg.GetDescription(),
                        Quantity = 2,
                        QuantityType = QuantityType.stk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Sojasovs.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Fishsauce.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                    new Food()
                    {
                        Name = IngredientHelper.Mandler.GetDescription(),
                        Quantity = 1,
                        QuantityType = QuantityType.spsk
                    },
                }
                });

                // Torsk med sennepsrødder
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Torsk med sennepsrødder",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 1,
                    Page = 184,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 120,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Chiafrø.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Persillerod.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Knoldselleri.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Jordskok.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Hasselnødder.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Vineddike.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Dijonsennep.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk
                        },
                    }
                });

                // Laks med urter, syrlige agurker og æg 
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Laks med urter, syrlige agurker og æg",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 186,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Laksefilet.GetDescription(),
                            Quantity = 120,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Purløg.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Basilikum.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Persille.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æbleeddike.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Agurk.GetDescription(),
                            Quantity = 0.24,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rugkerner.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                    }
                });

                // Kødsovs med paste
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kødsovs med paste",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 2,
                    Page = 188,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.HakketOksekød.GetDescription(),
                            Quantity = 250,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Hvidløg.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.FlåedeTomater.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dåse,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.GrønneLinser.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.GrovPasta.GetDescription(),
                            Quantity = 80,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Parmesanost.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Knoldselleri.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram
                        },
                    }
                });

                // Chili con carne med skyr, æbler og sennep
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Chili con carne med skyr, æbler og sennep",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 2,
                    Page = 190,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.HakketOksekød.GetDescription(),
                            Quantity = 250,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Hvidløg.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Chili.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Bønner.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dåse
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Øl.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Chokolade.GetDescription(),
                            Quantity = 20,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødkål.GetDescription(),
                            Quantity = 200,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æble.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Skyr.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Dijonsennep.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                    }
                });

                // Sprød torsk, råt grønt og sellericreme
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Sprød torsk, råt grønt og sellericreme",
                    Type = MealType.Dinner,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 192,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Selleri.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 120,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Persillerod.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødbeder.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                    }
                });

                // Grønt og rejer i rispapir
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Grønt og rejer i rispapir",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 194,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Rejer.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Forårsløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Peberfrugt.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Basilikum.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Fennikel.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Sesamfrø.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rispapir.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.plade
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Fishsauce.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Lime.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Chili.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.SaltedePeanuts.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Jordnøddeolie.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                    }
                });

                // Frikadeller med rug, ramsløg og salat
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Frikadeller med rug, ramsløg og salat",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 4,
                    Page = 196,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.HakketKalvOgOkse.GetDescription(),
                            Quantity = 500,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 3,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Mælk.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rugflager.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æblemost.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Hvidløg.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rapsolie.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Edamamebønner.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Hytteost.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 80,
                            QuantityType = QuantityType.gram
                        },
                    }
                });

                // Torsk og tomatsalat
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Torsk og tomatsalat",
                    Type = MealType.Dinner,
                    Ratio = 1.02,
                    Persons = 1,
                    Page = 198,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 150,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Tomat.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Persille.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rugkerner.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Oliven.GetDescription(),
                            Quantity = 7,
                            QuantityType = QuantityType.stk
                        },
                    }
                });

                // Pizza med frisk grønt og kylligefilet
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Pizza med frisk grønt og kylligefilet",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 200,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Pizza.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Kyllingbryst.GetDescription(),
                            Quantity = 120,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 150,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Basilikum.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                    }
                });

                // Forårsruller med kål og kød
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Forårsruller med kål og kød",
                    Type = MealType.Dinner,
                    Ratio = 1.3,
                    Persons = 2,
                    Page = 202,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Kyllingbryst.GetDescription(),
                            Quantity = 200,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødkål.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Ingegær.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Mandler.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Sojasovs.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Forårsrulledej.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.plade,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                    }
                });

                // Rodfrugter på panden med chorizopølser
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Rodfrugter på panden med chorizopølser",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 204,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Chorizopølser.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Persillerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rødløg.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk,
                        },
                    }
                });

                // Dumblings med fisk og grønt, hertil råkost
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Dumblings med fisk og grønt, hertil råkost",
                    Type = MealType.Dinner,
                    Ratio = 0.7,
                    Persons = 1,
                    Page = 206,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Blomkålsbuketter.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Broccoli.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Wontondej.GetDescription(),
                            Quantity = 5,
                            QuantityType = QuantityType.plade,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Torsk.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Sojasovs.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Mandler.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                    }
                });

                // Kalv i øl og timian
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kalv i øl og timian",
                    Type = MealType.Dinner,
                    Ratio = 1.1,
                    Persons = 1,
                    Page = 208,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Kalvekotelet.GetDescription(),
                            Quantity = 300,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Broccoli.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Gulerod.GetDescription(),
                            Quantity = 50,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Timian.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Dijonsennep.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.tsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Radicchio.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Øl.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Fuldkornsbrød.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.skive,
                        },
                    }
                });

                // Kartofler med æg og salat
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kartofler med æg og salat",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 210,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Hjertesalat.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Kartofler.GetDescription(),
                            Quantity = 80,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Forårsløg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Olivenolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Vineddike.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.stk,
                        },
                    }
                });

                // Edamamebønner med spidskål og dild
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Edamamebønner med spidskål og dild",
                    Type = MealType.Dinner,
                    Ratio = 0.5,
                    Persons = 1,
                    Page = 212,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Edamamebønner.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.pose
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Hytteost.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.dl,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Citron.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Dild.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Spidskål.GetDescription(),
                            Quantity = 100,
                            QuantityType = QuantityType.gram,
                        },
                    }
                });

                // Kotelet i fad med mynte, kartofler og appelsin
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kotelet i fad med mynte, kartofler og appelsin",
                    Type = MealType.Dinner,
                    Ratio = 0.8,
                    Persons = 1,
                    Page = 214,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.RødAppelsin.GetDescription(),
                            Quantity = 0.0,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Mynte.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Kartofler.GetDescription(),
                            Quantity = 75,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Svinekotelet.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Honning.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Sojasovs.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Mandler.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.spsk,
                        },
                    }
                });

                // Kød med syrlige kartofler og parmesan
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Kød med syrlige kartofler og parmesan",
                    Type = MealType.Dinner,
                    Ratio = 0.9,
                    Persons = 1,
                    Page = 216,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Oksebøf.GetDescription(),
                            Quantity = 150,
                            QuantityType = QuantityType.gram
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Kartofler.GetDescription(),
                            Quantity = 6,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Eddike.GetDescription(),
                            Quantity = 0.5,
                            QuantityType = QuantityType.dl,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Rosmarin.GetDescription(),
                            Quantity = 2,
                            QuantityType = QuantityType.spsk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Parmesanost.GetDescription(),
                            Quantity = 20,
                            QuantityType = QuantityType.gram,
                        },
                    }
                });

                // Fiskefilet med salat
                ListOfRecipes.Add(new Recipe()
                {
                    Name = "Fiskefilet med salat",
                    Type = MealType.Dinner,
                    Ratio = 1.7,
                    Persons = 1,
                    Page = 218,
                    Ingredients = new ObservableCollection<Food>()
                    {
                        new Food()
                        {
                            Name = IngredientHelper.Fiskefilet.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Æg.GetDescription(),
                            Quantity = 1,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Mysli.GetDescription(),
                            Quantity = 25,
                            QuantityType = QuantityType.gram,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Vindruekerneolie.GetDescription(),
                            Quantity = 0,
                            QuantityType = QuantityType.Ingen,
                            QuantityVisible = false
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Radicchio.GetDescription(),
                            Quantity = 0.25,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
                        {
                            Name = IngredientHelper.Drueagurker.GetDescription(),
                            Quantity = 4,
                            QuantityType = QuantityType.stk,
                        },
                        new Food()
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

        public async Task PopulateListOfFoodAsync()
        {
            var assembly = typeof(DataModel).GetTypeInfo().Assembly;

            await Task.Run(() =>
            {
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
                            Name = csv.GetField<string>(0),

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
                            SumMaettedeFedtsyrer = csv.GetField<string>(155).ConvertToDouble(),
                            SumMonoumaettedeFedtsyrer = csv.GetField<string>(156).ConvertToDouble(),
                            SumPolymaettedeFedtsyrer = csv.GetField<string>(157).ConvertToDouble(),
                            TransFedtsyrer = csv.GetField<string>(161).ConvertToDouble(),
                            Cholesterol = csv.GetField<string>(162).ConvertToDouble(),

                            Vand = csv.GetField<string>(19).ConvertToDouble(),
                            Avitamin = csv.GetField<string>(20).ConvertToDouble(),
                            B12vitamin = csv.GetField<string>(43).ConvertToDouble(),
                            Cvitamin = csv.GetField<string>(44).ConvertToDouble(),
                            Dvitamin = csv.GetField<string>(23).ConvertToDouble(),
                            Evitamin = csv.GetField<string>(26).ConvertToDouble(),
                            K1vitamin = csv.GetField<string>(31).ConvertToDouble(),

                            Natrium = csv.GetField<string>(48).ConvertToDouble(),
                            Kalium = csv.GetField<string>(49).ConvertToDouble(),
                            Cadmium = csv.GetField<string>(65).ConvertToDouble(),
                            Calcium = csv.GetField<string>(50).ConvertToDouble(),
                            Magnesium = csv.GetField<string>(51).ConvertToDouble(),
                            Jern = csv.GetField<string>(53).ConvertToDouble(),
                            Zink = csv.GetField<string>(55).ConvertToDouble(),
                            Selen = csv.GetField<string>(59).ConvertToDouble(),

                            Glycose = csv.GetField<string>(87).ConvertToDouble(),
                        });
                    }

                    counter++;
                }
            });


        }

        public async Task UpdateFoodAsync(Food food)
        {
            if (food == null)
                return;

            if (ListOfFood.Any(a => a.FoodId == food.FoodId))
            {
                await Task.Run(() =>
                {
                    var oldFood = ListOfFood.Where(a => a.FoodId == food.FoodId).First();

                    oldFood.Name = food.Name;
                    oldFood.EnergiKj = food.EnergiKj;
                    oldFood.EnergiKcal = food.EnergiKcal;

                    oldFood.ProteinTotal = food.ProteinTotal;

                    oldFood.KulhydratDifferens = food.KulhydratDifferens;
                    oldFood.KulhydratTilgaengelig = oldFood.KulhydratTilgaengelig;
                    oldFood.SukkerarterIalt = food.SukkerarterIalt;
                    oldFood.TilsatSukker = food.TilsatSukker;

                    oldFood.Kostfiber = food.Kostfiber;

                    oldFood.FedtTotal = food.FedtTotal;
                    oldFood.SumMaettedeFedtsyrer = food.SumMaettedeFedtsyrer;
                    oldFood.SumMonoumaettedeFedtsyrer = food.SumMonoumaettedeFedtsyrer;
                    oldFood.SumPolymaettedeFedtsyrer = food.SumPolymaettedeFedtsyrer;
                    oldFood.TransFedtsyrer = food.TransFedtsyrer;
                    oldFood.Cholesterol = food.Cholesterol;

                    oldFood.Avitamin = food.Avitamin;
                    oldFood.B12vitamin = food.B12vitamin;
                    oldFood.Cvitamin = food.Cvitamin;
                    oldFood.Dvitamin = food.Dvitamin;
                    oldFood.Evitamin = food.Evitamin;
                    oldFood.K1vitamin = food.K1vitamin;

                    oldFood.Natrium = food.Natrium;
                    oldFood.Kalium = food.Kalium;
                    oldFood.Cadmium = food.Cadmium;
                    oldFood.Calcium = food.Calcium;
                    oldFood.Magnesium = food.Magnesium;
                    oldFood.Jern = food.Jern;
                    oldFood.Zink = food.Jern;
                    oldFood.Selen = food.Jern;
                });
            }
        }

        public void AddNewFood(Food newFood)
        {
            if (newFood == null)
                throw new ArgumentNullException("I metoden AddNewFood er newFood null");

            newFood.FoodId = getNewFoodId();

            ListOfFood.Add(newFood);
        }

        public void DeleteFood(Food food)
        {
            if (food == null)
                throw new ArgumentNullException("I metoden DeleteFood er food null");

            var foodId = food.FoodId;

            ListOfFood.RemoveAt(ListOfFood.IndexOf(ListOfFood.Where(a => a.FoodId == foodId).First()));
        }

        private int getNewFoodId()
        {
            // Læg +1 til det højeste FoodId
            var foodId = ListOfFood.OrderBy(a => a.FoodId).Last().FoodId + 1;

            return foodId;
        }
    }
}
