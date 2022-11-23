import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Recipe } from '../../Models/recipe.model';

@Component({
  selector: 'app-recipe-item',
  templateUrl: './recipe-item.component.html',
  styleUrls: ['./recipe-item.component.css']
})
export class RecipeItemComponent implements OnInit {

  @Input() recipe =new Recipe('','','');
  @Output() ItemClick= new EventEmitter<Recipe>();

  constructor() { }

  ngOnInit(): void {
  }

  

}
