import { Component, Output, EventEmitter } from '@angular/core';
import { HttpService } from './http.service';

import { iEmployee } from './Employee/iEmployee.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private httpService: HttpService) { }

  loadedFeature = 'employeeList';
  employeesData: iEmployee[] = [];

  ngOnInit() {
    this.fetchEmployees();
  }

  onNavigate(feature: string) {
    this.loadedFeature = feature;
  }

  fetchEmployees() {
    this.httpService.fetchEmployees()
      .subscribe(employees => {
        //console.log(employees);
        this.employeesData = employees;
      });
  }

  createEmployee(data: iEmployee) {
    this.httpService.createEmployee(data)
      .subscribe(response => {
        //console.log(response);
        this.fetchEmployees();
      });
  }

  deleteEmployee(id: number) {
    this.httpService.deleteEmployee(id)
      .subscribe(response => {
        //console.log(response);
        this.fetchEmployees();
      });
  }
}
