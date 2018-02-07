import { Component, OnInit } from '@angular/core';
import { HubConnection } from '@aspnet/signalr-client';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  
  ngOnInit() {

    let connection = new HubConnection('http://localhost:5000/message');

    connection.on('send', data => {
      console.log(data);
    })

    connection.start()
      .then(() => console.log("Connected"));
  }

  title = 'app';
}
