import { Component, OnInit } from '@angular/core';
import { Recipe } from '../Models/recipe.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent implements OnInit {

  recipes: Recipe[] = [
    new Recipe('Grilled Salmon',
      'Salmon grilled with ginger and garlic with a slight rosemary toping',
      "https://149777215.v2.pressablecdn.com/wp-content/uploads/2007/09/shutterstock_248850307.jpg"),
      new Recipe('Grilled Salmon',
      'Salmon grilled with ginger and garlic with a slight rosemary toping',
      "https://149777215.v2.pressablecdn.com/wp-content/uploads/2007/09/shutterstock_248850307.jpg")
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
