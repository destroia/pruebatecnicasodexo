import { TestBed } from '@angular/core/testing';

import { DiccionaryUrlService } from './diccionary-url.service';

describe('DiccionaryUrlService', () => {
  let service: DiccionaryUrlService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DiccionaryUrlService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
