import { TestBed } from '@angular/core/testing';

import { VillianService } from './villian-s.service';

describe('VillianSService', () => {
  let service: VillianService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(VillianService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
