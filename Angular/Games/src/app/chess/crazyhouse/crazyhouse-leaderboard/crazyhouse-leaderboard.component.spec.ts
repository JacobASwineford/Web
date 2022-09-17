import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrazyhouseLeaderboardComponent } from './crazyhouse-leaderboard.component';

describe('CrazyhouseLeaderboardComponent', () => {
  let component: CrazyhouseLeaderboardComponent;
  let fixture: ComponentFixture<CrazyhouseLeaderboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CrazyhouseLeaderboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CrazyhouseLeaderboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
