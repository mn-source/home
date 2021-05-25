import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProbeLatestComponent } from './probe-latest.component';

describe('ProbeLatestComponent', () => {
  let component: ProbeLatestComponent;
  let fixture: ComponentFixture<ProbeLatestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProbeLatestComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProbeLatestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
