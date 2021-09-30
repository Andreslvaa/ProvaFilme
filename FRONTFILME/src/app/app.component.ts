import { Component, OnInit } from '@angular/core';
import { Filme } from './models/filme';
import { FilmeService } from './services/filme.service';

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: []
})
export class AppComponent implements OnInit {
  filmes: Filme[] = [];
  constructor(private service: FilmeService) {}

  ngOnInit(): void {
    this.service.list().subscribe(filmes => {
      this.filmes = filmes;
        console.log(filmes); 

    });
  }
}
