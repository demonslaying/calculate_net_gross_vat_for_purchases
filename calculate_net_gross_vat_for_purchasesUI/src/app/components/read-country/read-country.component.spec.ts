import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadCountryComponent } from './read-country.component';

describe('ReadCountryComponent', () => {
  let component: ReadCountryComponent;
  let fixture: ComponentFixture<ReadCountryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReadCountryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReadCountryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
