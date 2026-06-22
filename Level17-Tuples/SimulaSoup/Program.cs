// the first item in the enum is the default value 
Seasoning season = Seasoning.Spicy;
Ingredient ingredient = Ingredient.Mushroom;
Type type = Type.Soup;

Console.WriteLine($"What Seasoning do you want: {Seasoning.Spicy}, {Seasoning.Salt}, {Seasoning.Sweet}?");
string seasonAnswer = Console.ReadLine();

if (seasonAnswer == Convert.ToString(Seasoning.Salt)) season = Seasoning.Salt;
if (seasonAnswer == Convert.ToString(Seasoning.Sweet)) season = Seasoning.Sweet;

Console.WriteLine($"What ingredient do you want: {Ingredient.Mushroom}, {Ingredient.Chicken}, {Ingredient.Carrots}, {Ingredient.Potatoes}?");
string ingredientAnswer = Console.ReadLine();

if (ingredientAnswer == Convert.ToString(Ingredient.Chicken)) ingredient = Ingredient.Chicken;
if (ingredientAnswer == Convert.ToString(Ingredient.Carrots)) ingredient = Ingredient.Carrots;
if (ingredientAnswer == Convert.ToString(Ingredient.Potatoes)) ingredient = Ingredient.Potatoes;

Console.WriteLine($"What type of food do you want: {Type.Soup}, {Type.Stew}, {Type.Gumbo}?");
string typeAnswer = Console.ReadLine();

if (typeAnswer == Convert.ToString(Type.Stew)) type = Type.Stew;
if (typeAnswer == Convert.ToString(Type.Gumbo)) type = Type.Gumbo;

var food = (season, ingredient, type);

Console.WriteLine($"The food you created is a \"{food.season} {food.ingredient} {food.type}\"");
        

enum Type { Soup, Stew, Gumbo }
enum Ingredient { Mushroom, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salt, Sweet }