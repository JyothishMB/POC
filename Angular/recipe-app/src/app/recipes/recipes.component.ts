import { Component, OnInit } from '@angular/core';
import { Recipe } from './Models/recipe.model';

@Component({
  selector: 'app-recipes',
  templateUrl: './recipes.component.html',
  styleUrls: ['./recipes.component.css']
})
export class RecipesComponent implements OnInit {

  selectedRecipe = new Recipe('','','');

  constructor() { }

  ngOnInit(): void {
  }

  recipeClick(recipe: Recipe){
    this.selectedRecipe = recipe;
  }
}
