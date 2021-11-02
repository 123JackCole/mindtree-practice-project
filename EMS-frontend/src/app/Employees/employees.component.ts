import { Component, EventEmitter, Input, Output } from "@angular/core";
import { iEmployee } from '../Employee/iEmployee.model';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html'
})
export class EmployeesComponent {
  @Input() employeesData!: iEmployee[];

  @Output() editEmployee: EventEmitter<iEmployee> = new EventEmitter<iEmployee>();
  @Output() deleteEmployee: EventEmitter<number> = new EventEmitter<number>();

  changeEmployee(employee: iEmployee) {
    this.editEmployee.next(employee);
  }

  removeEmployee(id: number) {
    this.deleteEmployee.next(id)
  }
}
