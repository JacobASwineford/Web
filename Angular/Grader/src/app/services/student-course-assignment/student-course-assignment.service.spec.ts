import { TestBed } from '@angular/core/testing';

import { StudentCourseAssignmentService } from './student-course-assignment.service';

describe('StudentCourseAssignmentService', () => {
  let service: StudentCourseAssignmentService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StudentCourseAssignmentService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
