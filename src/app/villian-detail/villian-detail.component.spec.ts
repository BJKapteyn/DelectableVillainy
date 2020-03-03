import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VillianDetailComponent } from './villian-detail.component';

describe('VillianDetailComponent', () => {
  let component: VillianDetailComponent;
  let fixture: ComponentFixture<VillianDetailComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VillianDetailComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VillianDetailComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
