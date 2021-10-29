import { Component, Input, Output } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { iEmployee } from './Employee/iEmployee.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private http: HttpClient) { }

  loadedFeature = 'employeeList';
  employeesData: iEmployee[] = [];

  ngOnInit() {
    this.fetchEmployees();
  }

  onNavigate(feature: string) {
    this.loadedFeature = feature;
  }

  fetchEmployees() {
    this.http.get<[iEmployee]>('https://localhost:44337/api/employees')
      .subscribe(employees => {
        this.employeesData = employees;
        //console.log(this.employeesData);
      });
  }

  createEmployee(data: Object) {
    this.http.post('https://localhost:44337/api/employees', data).subscribe(response => {
      console.log(response);
      this.fetchEmployees();
    });
  }
}
