import { Component, OnInit } from '@angular/core';
import { Ingredient } from '../shared/Models/ingredient.model';

@Component({
  selector: 'app-shopping-list',
  templateUrl: './shopping-list.component.html',
  styleUrls: ['./shopping-list.component.css']
})
export class ShoppingListComponent implements OnInit {

  ingredients: Ingredient[] = [
    new Ingredient('Salmon',1),
    new Ingredient('Garlic',10),
    new Ingredient('Ginger',1),
    new Ingredient('Rosemary',1)
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
