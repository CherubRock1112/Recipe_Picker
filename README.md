# Recipe Picker
# French
## Principe

Le principe du programme est le suivant : 

- L'utilisateur rentre dans le menu de modification des recettes et ingrédients.
Il pourra y créer des types d'ingrédients (exemple : Viande, Poisson, Légumes...), ainsi que des ingrédients faisant parti de ces types.
- A partir de ces ingrédients, l'utilisateur renseigne des recettes, avec leurs noms et la liste d'ingrédients qu'elles utilisent en les cochant dans les listes associées.
- Une fois les recettes créées, on retourne à la fenêtre principale. On peut à présent sélectionner des ingrédients, et cliquer sur "Trouver une recette" pour que le programme trouve une recette parmis celles fournies qui utilise les ingrédients voulus. Parmis toutes les recettes éligibles, plus la recette a été faite pour la dernière fois il y a longtemps, plus elle a de chance d'être sélectionnée.
- Quand une recette satisfaisante a été donné, on clique sur "Choisir cette recette", qui aura pour effet de changer la date de dernière réalisation à la date du jour.

## Base de donnée

Lors du premier lancement du programme, une base de données et 4 tables sont créées, à l'aide de commandes SQL fournies dans prog/table.txt .

La base de données sera peuplé grâce aux commandes fournis dans prog/data.txt .

## Choix de la recette

L'idée était de créer un algorithme simple permettant de faire en sorte que la date de la dernière réalisation influe sur la probabilité qu'une recette puisse être choisie.

Pour ce faire, le programme crée un "pourcentage de nouveauté" en récupérant l'écart maximal en jours entre deux recettes de la liste des recettes éligibles, puis la différence de jours entre la recette choisie et la recette la plus ancienne, pour enfin diviser la différence obtenue par l'écart maximal calculé auparavant. On obtient un facteur de nouveauté, que l'on va multiplier par 100 pour avoir un pourcentage. Plus la recette a été faite pour la dernière fois récemment, plus ce pourcentage sera élevé.

Enfin, pour savoir si la recette pré-sélectionné (elle même sélectionnée aléatoirement dans la liste des recettes éligibles) est celle qui sera donné à l'utilisateur, on tire un nombre au hasard entre  0 et 99, et si ce nombre est inférieur au pourcentage, la recette n'est pas choisie et on en pré-selectionne une nouvelle.

L'opération est ainsi répétée jusqu'à obtention d'un nombre au dessus du pourcentage.

# English
## Principle

The principle of the program is as follows:

- The user enters the menu for modifying recipes and ingredients.
You can create ingredients type there (example: Meat, Fish, Vegetables ...), as well as ingredients that are part of these types.
- From these ingredients, the user fills in recipes, with their names and the list of ingredients they use by checking them in the associated lists.
- Once the recipes have been created, we return to the main window. You can now select ingredients, and click on "Find a recipe" for the program to find a recipe among those provided that uses the desired ingredients. Of all eligible recipes, the further away the recipe was last made, the higher the chance it has of getting picked.
- When a satisfactory recipe has been given, we click on "Choose this recipe", which will have the effect of changing the date when the recipe was last made to the current date.

## Database

When the program is started for the first time, a database and 4 tables is created, using SQL commands provided in prog / table.txt.

The database will be populated using the commands provided in prog / data.txt.

## Choice of recipe

The idea was to create a simple algorithm to make sure that the date when the recipe was last made influences the probability that a recipe can be chosen.

To do this, the program creates a "percentage of novelty" by getting the maximum difference in days between two recipes from the list of eligible recipes, then the difference in days between the chosen recipe and the oldest eligible recipe, to finally divide the difference obtained by the maximum difference calculated previously. We get a novelty factor, which we will multiply by 100 to get a percentage. The more recently the recipe was made, the higher this percentage will be.

Finally, to find out if the pre-selected recipe (itself selected randomly from the list of eligible recipes) is the one that will be given to the user, we draw a random number between 0 and 99, and if this number is less than the percentage, the recipe is not chosen and a new one is pre-selected.

The operation is thus repeated until a number above the percentage is obtained.


