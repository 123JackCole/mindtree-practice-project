import { HttpClient } from "@angular/common/http";
import { Component, Input } from "@angular/core";
import { iEmployee } from './iEmployee.model';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html'
})
export class EmployeeComponent {

  constructor(private http: HttpClient) { }

  @Input()
  employeeData!: iEmployee;

  ngOnInit() { }

  onEdit() {

  }

  onDelete() {
    this.http.delete(`https://localhost:44337/api/employees/${this.employeeData.id}`).subscribe(response => {
      console.log(response);
    });
  }
}
