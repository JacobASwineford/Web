import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CheckersMenuComponent } from './checkers-menu.component';

describe('CheckersMenuComponent', () => {
  let component: CheckersMenuComponent;
  let fixture: ComponentFixture<CheckersMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CheckersMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CheckersMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
