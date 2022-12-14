import { Component, Input, OnInit } from '@angular/core';
import { Country } from './models/country';
import { VATRate } from './models/vat-rate';
import { CountryService } from './services/country.service';
import { VatRateService } from './services/vat-rate.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent implements OnInit {
  title = 'calculate_net_gross_vat_for_purchasesUI';
  @Input() country?: Country;
  @Input() vatRate?: VATRate;
  countries: Country[] = [];
  vatRates: VATRate[] = [];
  // FOR the first countryqqqqqq
  selectCountryId: number = 1;
  // FOR VATRATES checkboxes
  selectedIndex: number = 0;
  // FOR READONLY text box
  isReadOnlyOne = true;
  isReadOnlyTwo = true;
  isReadOnlyThree = true;
  // FOR CALCULATIONS
  vatRateSelected: number;
  priceWithVAT: number = 0;
  tax: number = 0;
  priceWithoutVAT: number = 0;
  // VALIDATIONS
  priceWithoutVATText : string;
  priceWithVATText : string;

  constructor(private countryService: CountryService, private vatRateService : VatRateService) { }
  
  // Method on start
  ngOnInit() : void {
    this.countryService.getCountries().subscribe((result: Country[]) => (this.countries = result));
    this.vatRateService.getVATRatesbByCountryId(this.selectCountryId)
      .subscribe((result: VATRate[]) => 
      {
        this.vatRates = result,
        // To get the first VAT RATE selected 
        this.vatRateSelected = this.vatRates[0]['rate']!
      }); 
  }

  selectCountryVATRates(event : any) {
    this.vatRateService.getVATRatesbByCountryId(event.target.value)
      .subscribe((result: VATRate[]) => 
      {
        this.vatRates = result
        // To get the first VAT RATE selected when you change country
        this.vatRateSelected = this.vatRates[0]['rate']!
      });
  }

  selectCheckBox(event : any, index : number, vatRate: any) {
    console.log(event);
    console.log(index);
    console.log(vatRate);
    this.selectedIndex = event.target.checked ? index : index;
    this.vatRateSelected = vatRate;
  }

  //TODO: See if you can refactor
  enableInputText(event : any) {
    if (event.target.id == "priceWithoutVATCheckbox") {
      this.isReadOnlyOne = !this.isReadOnlyOne;  
    }
    else if (event.target.id == "Tax") {
      this.isReadOnlyTwo = !this.isReadOnlyTwo;
    }
    else if (event.target.id == "priceWithVATCheckbox") {
      this.isReadOnlyThree = !this.isReadOnlyThree;
    } 
  }

  calculateWithVAT(event: any) {
    let priceWithoutVAT = event.target.value;
    this.tax = Number(Math.round(priceWithoutVAT * (this.vatRateSelected / 100)).toFixed(2));
    this.priceWithVAT = +priceWithoutVAT + this.tax;
  }

  calculateWithoutVAT(event: any) {
    let priceWithVAT = event.target.value;
    this.tax =  Number(Math.round(priceWithVAT * (this.vatRateSelected / 100)).toFixed(2));
    this.priceWithoutVAT = +priceWithVAT - this.tax;
  }

  numberOnly(event: any): boolean {
    const charCode = (event.which) ? event.which : event.keyCode;
    if (charCode > 31 && (charCode < 48 || charCode > 57)) {
      return false;
    }
    return true;
  }

}
