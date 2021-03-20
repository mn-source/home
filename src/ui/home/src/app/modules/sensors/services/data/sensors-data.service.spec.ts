/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SensorsDataService } from './sensors-data.service';

describe('Service: SensorsData', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SensorsDataService]
    });
  });

  it('should ...', inject([SensorsDataService], (service: SensorsDataService) => {
    expect(service).toBeTruthy();
  }));
});
