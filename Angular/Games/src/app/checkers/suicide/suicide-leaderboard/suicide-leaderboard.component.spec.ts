import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SuicideLeaderboardComponent } from './suicide-leaderboard.component';

describe('SuicideLeaderboardComponent', () => {
  let component: SuicideLeaderboardComponent;
  let fixture: ComponentFixture<SuicideLeaderboardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SuicideLeaderboardComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SuicideLeaderboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
