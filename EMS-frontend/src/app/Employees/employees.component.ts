import { Component, EventEmitter, Input, Output } from "@angular/core";
import { iEmployee } from '../Employee/iEmployee.model';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html'
})
export class EmployeesComponent {
  @Input()
  employeesData!: iEmployee[];

  ngOnInit() {
    //console.log(`employees data: ${this.employeesData}`)
  }
}
