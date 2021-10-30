import { HttpService } from "../http.service";
import { Component, Input, Output, EventEmitter } from "@angular/core";
import { iEmployee } from './iEmployee.model';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {

  constructor(private http: HttpService) { }

  @Input()
  employeeData!: iEmployee;

  @Output()
  employeeId: EventEmitter<number> = new EventEmitter<number>();

  ngOnInit() { }

  onEdit() {

  }

  deleteEmployee(id: number) {
    this.employeeId.next(id);
  }
}
