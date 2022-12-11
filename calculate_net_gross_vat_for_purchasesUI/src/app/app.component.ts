import { Component, Input, OnInit } from '@angular/core';
import { Country } from './models/country';
import { CountryService } from './services/country.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title = 'calculate_net_gross_vat_for_purchasesUI';
  @Input() country?: Country;
  countries: Country[] = [];

  constructor(private countryService: CountryService) { }
  
  ngOnInit() : void {
    this.countryService.getCountries().subscribe((result: Country[]) => (this.countries = result));
  }
}
