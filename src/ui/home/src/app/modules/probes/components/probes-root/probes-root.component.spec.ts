import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProbesRootComponent } from './probes-root.component';

describe('ProbesRootComponent', () => {
  let component: ProbesRootComponent;
  let fixture: ComponentFixture<ProbesRootComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ProbesRootComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProbesRootComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
