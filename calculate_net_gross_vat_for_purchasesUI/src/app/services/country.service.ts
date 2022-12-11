import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Country } from '../models/country';

@Injectable({
  providedIn: 'root'
})
export class CountryService {
  private apiUrl = "https://localhost:7076/api/";
  private url = "Country";

  constructor(private http: HttpClient) { }

  public getCountries() : Observable<Country[]> {
    return this.http.get<Country[]>(`${this.apiUrl}${this.url}`);
  }
}
