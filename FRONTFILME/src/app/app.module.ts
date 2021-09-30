import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { AppComponent } from './app.component';
import { ListarFilmeComponent } from './componentes/views/listar/filme/listar-filme/listar-filme.component';

@NgModule({
  declarations: [
    AppComponent,
    ListarFilmeComponent],
  imports: [
    BrowserModule,
    ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
