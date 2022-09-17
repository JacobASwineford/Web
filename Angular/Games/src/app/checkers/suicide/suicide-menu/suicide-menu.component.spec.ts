import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuicideMenuComponent } from './suicide-menu.component';

describe('SuicideMenuComponent', () => {
  let component: SuicideMenuComponent;
  let fixture: ComponentFixture<SuicideMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SuicideMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SuicideMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
