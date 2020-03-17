import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VillainBlowupViewComponent } from './villain-blowup-view.component';

describe('VillainBlowupViewComponent', () => {
  let component: VillainBlowupViewComponent;
  let fixture: ComponentFixture<VillainBlowupViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VillainBlowupViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VillainBlowupViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
