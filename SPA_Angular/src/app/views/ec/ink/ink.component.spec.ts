import { ComponentFixture, TestBed, waitForAsync } from '@angular/core/testing';

import { InkComponent } from './ink.component';

describe('InkComponent', () => {
  let component: InkComponent;
  let fixture: ComponentFixture<InkComponent>;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      declarations: [ InkComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(InkComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
