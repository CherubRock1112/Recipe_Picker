# Recipe Picker

# Principe

Le principe du programme est le suivant : 

- L'utilisateur rentre dans le menu de modification des recettes et ingrédients.
Il pourra y créer des types d'ingrédients (exemple : Viande, Poisson, Légumes...), ainsi que des ingrédients faisant parti de ces types.
- A partir de ces types, l'utilisateur renseigne des recettes, avec leurs noms et la liste d'ingrédients qu'elles utilisent en les cochant dans les listes associées.
- Une fois les recettes créées, on retourne à la fenêtre principale. On peut à présent sélectionner des ingrédients, et cliquer sur "Trouver une recette" pour que le programme trouve une recette parmis celles fournies qui utilise les ingrédients voulus. Parmis toutes les recettes éligibles, plus la recette a été faite pour la dernière fois il y a longtemps, plus elle a de chance d'être sélectionnée.
- Quand une recette satisfaisante a été donné, on clique sur "Choisir cette recette", qui aura pour effet de changer la date de dernière réalisation à la date du jour.

# Base de donnée

Lors du premier lancement du programme, une base de données et 4 tables seront créées, à l'aide de commandes SQL fournies dans prog/table.txt .

La base de données sera peuplé grâce aux commandes fournis dans prog/data.txt .

# Choix de la recette

L'idée était de créer un algorithme simple permettant de faire en sorte que la date de la dernière réalisation influe sur la probabilité qu'une recette puisse être choisie.

Pour ce faire, le programme crée un "pourcentage de nouveauté" en récupérant l'écart maximal en jours entre deux recettes de la liste des recettes éligibles, puis la différence de jours entre la recette choisie et la recette la plus ancienne, pour enfin diviser la différence obtenue par l'écart maximal calculé auparavant. On obtient un facteur de nouveauté, que l'on va multiplier par 100 pour avoir un pourcentage. Plus la recette a été faite pour la dernière fois récemment, plus ce pourcentage sera élevé.

Enfin, pour savoir si la recette pré-sélectionné (elle même sélectionnée aléatoirement dans la liste des recettes éligibles) est celle qui sera donné à l'utilisateur, on tire un nombre au hasard entre  0 et 99, et si ce nombre est inférieur au pourcentage, la recette n'est pas choisie et on en pré-selectionne une nouvelle.

L'opération est ainsi répétée jusqu'à obtention d'un nombre au dessus du pourcentage.


