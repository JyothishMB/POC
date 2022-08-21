import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-server',
  templateUrl: './server.component.html',
  styleUrls: ['./server.component.css']
})
export class ServerComponent implements OnInit {
  @Input('svrElement') element: {name:string, type:string, content:string}

  constructor() { }

  ngOnInit(): void {
  }

}
