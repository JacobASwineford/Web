import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrazyhouseMenuComponent } from './crazyhouse-menu.component';

describe('CrazyhouseMenuComponent', () => {
  let component: CrazyhouseMenuComponent;
  let fixture: ComponentFixture<CrazyhouseMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CrazyhouseMenuComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CrazyhouseMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
