/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SensorsValidationService } from './sensors-validation.service';

describe('Service: SensorsValidation', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SensorsValidationService]
    });
  });

  it('should ...', inject([SensorsValidationService], (service: SensorsValidationService) => {
    expect(service).toBeTruthy();
  }));
});
