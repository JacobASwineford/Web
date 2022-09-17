import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FogofwarLeaderboardComponent } from './fogofwar-leaderboard.component';

describe('FogofwarLeaderboardComponent', () => {
  let component: FogofwarLeaderboardComponent;
  let fixture: ComponentFixture<FogofwarLeaderboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FogofwarLeaderboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FogofwarLeaderboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
