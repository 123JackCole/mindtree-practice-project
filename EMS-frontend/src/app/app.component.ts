import { Component, Output } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { iEmployee } from './Employee/iEmployee.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  loadedFeature = 'employeeList';

  constructor(private http: HttpClient) { }

  employeesData: iEmployee[] = [];

  ngOnInit() {
    this.fetchEmployees();
  }

  onNavigate(feature: string) {
    this.loadedFeature = feature;
  }

  private fetchEmployees() {
    this.http.get<[iEmployee]>('https://localhost:44337/api/employees')
      .subscribe(employees => {
        this.employeesData = employees;
        //console.log(this.employeesData);
      });
  }
}
