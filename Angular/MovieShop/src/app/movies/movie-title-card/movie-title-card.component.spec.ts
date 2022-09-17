import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MovieTitleCardComponent } from './movie-title-card.component';

describe('MovieTitleCardComponent', () => {
  let component: MovieTitleCardComponent;
  let fixture: ComponentFixture<MovieTitleCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MovieTitleCardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(MovieTitleCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
