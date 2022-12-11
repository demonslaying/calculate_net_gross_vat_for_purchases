import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { VATRate } from '../models/vat-rate';

@Injectable({
  providedIn: 'root'
})
export class VatRateService {
  private apiUrl = "https://localhost:7076/api/";
  private url = "VATRate";

  constructor(private http: HttpClient) { }

  public getVATRates() : Observable<VATRate[]> {
    return this.http.get<VATRate[]>(`${this.apiUrl}${this.url}`);
  }
}
