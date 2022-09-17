import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChessMenuComponent } from './chess-menu.component';

describe('ChessMenuComponent', () => {
  let component: ChessMenuComponent;
  let fixture: ComponentFixture<ChessMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChessMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ChessMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
