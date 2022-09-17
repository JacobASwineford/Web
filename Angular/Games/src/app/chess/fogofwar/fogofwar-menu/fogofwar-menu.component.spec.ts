import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FogofwarMenuComponent } from './fogofwar-menu.component';

describe('FogofwarMenuComponent', () => {
  let component: FogofwarMenuComponent;
  let fixture: ComponentFixture<FogofwarMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FogofwarMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FogofwarMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
