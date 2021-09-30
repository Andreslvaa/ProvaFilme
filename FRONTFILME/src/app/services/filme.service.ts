import { Injectable } from '@angular/core';
import { Filme } from '../models/filme';
import { HttpClient } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FilmeService {

  private baseURL = "https://localhost:5001/api/filme";

  constructor(private http: HttpClient) { }

  list(): Observable<Filme[]> {
    return  this.http.get<Filme[]>('${this.baseURL}/list');

  }
}
