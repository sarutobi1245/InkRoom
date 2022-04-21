/* tslint:disable:no-unused-variable */

import { TestBed, inject, waitForAsync } from '@angular/core/testing';
import { ModelNoService } from './model-no.service';

describe('Service: ModelNo', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ModelNoService]
    });
  });

  it('should ...', inject([ModelNoService], (service: ModelNoService) => {
    expect(service).toBeTruthy();
  }));
});
