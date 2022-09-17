import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StandardLeaderboardComponent } from './standard-leaderboard.component';

describe('StandardLeaderboardComponent', () => {
  let component: StandardLeaderboardComponent;
  let fixture: ComponentFixture<StandardLeaderboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StandardLeaderboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(StandardLeaderboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
