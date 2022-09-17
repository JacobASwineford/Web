import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieFactsComponent } from './movie-facts.component';

describe('MovieFactsComponent', () => {
  let component: MovieFactsComponent;
  let fixture: ComponentFixture<MovieFactsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MovieFactsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MovieFactsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
