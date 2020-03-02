import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { VilliansComponent } from './villians.component';

describe('VilliansComponent', () => {
  let component: VilliansComponent;
  let fixture: ComponentFixture<VilliansComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ VilliansComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(VilliansComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
