import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CastDatabaseComponent } from './cast-database.component';

describe('CastDatabaseComponent', () => {
  let component: CastDatabaseComponent;
  let fixture: ComponentFixture<CastDatabaseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CastDatabaseComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CastDatabaseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
