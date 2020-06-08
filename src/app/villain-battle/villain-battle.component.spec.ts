import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VillainBattleComponent } from './villain-battle.component';

describe('VillainBattleComponent', () => {
  let component: VillainBattleComponent;
  let fixture: ComponentFixture<VillainBattleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VillainBattleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VillainBattleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
