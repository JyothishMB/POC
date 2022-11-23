import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { Recipe } from '../Models/recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit {

  @Output() recipeItemClick = new EventEmitter<Recipe>();

  recipes: Recipe[] = [
    new Recipe('Grilled Salmon',
      'Salmon grilled with ginger and garlic with a slight rosemary toping',
      "https://149777215.v2.pressablecdn.com/wp-content/uploads/2007/09/shutterstock_248850307.jpg"),
      new Recipe('Garlic Pork chops',
      'Garlic pork chops in creamy mushroom sauce',
      "https://www.eatwell101.com/wp-content/uploads/2019/02/Garlic-Pork-Chops-in-Creamy-Mushroom-Sauce-Recipe.jpg")
  ];

  constructor() { }

  ngOnInit(): void {
  }

  itemClick(recipeEl: Recipe){
    this.recipeItemClick.emit(recipeEl);
  }
}
