import { HttpService } from "../http.service";
import { Component, Input, Output, EventEmitter } from "@angular/core";
import { iEmployee } from './iEmployee.model';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {

  constructor(private http: HttpService) { }

  @Input() employeeData!: iEmployee;
  formattedDate!: string; 

  @Output() employee: EventEmitter<iEmployee> = new EventEmitter<iEmployee>();
  @Output() employeeId: EventEmitter<number> = new EventEmitter<number>();
  @Output() feature: EventEmitter<string> = new EventEmitter<string>();

  ngOnInit() {
    this.formattedDate = new Date(this.employeeData.dateOfBirth).toLocaleDateString('en-CA');
  }

  editEmployee(employee: iEmployee) {
    this.employee.next(this.employeeData);
  }

  deleteEmployee(id: number) {
    this.employeeId.next(id);
  }
}
