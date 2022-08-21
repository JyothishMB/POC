import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'component-communication-sample-app';
  serverElements = [{name:'server1', type:'server', content:'test content'}];

  onServerAdded(serverdata: {serverName:string, serverContent:string}) {
    this.serverElements.push(
      {
        name: serverdata.serverName,
        type: 'server',
        content: serverdata.serverContent
      }
    );
  }

  onBlueprintAdded(blueprintData: {serverName:string, serverContent:string}) {
    this.serverElements.push(
      {
        name: blueprintData.serverName,
        type: 'blueprint',
        content: blueprintData.serverContent
      }
    );
  }
}
