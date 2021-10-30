import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

import { iEmployee } from './Employee/iEmployee.model';

@Injectable({ providedIn: 'root' })
export class HttpService {

  constructor(private http: HttpClient) { }

  fetchEmployees() {
    return this.http.get<[iEmployee]>('https://localhost:44337/api/employees');
  }

  createEmployee(data: iEmployee) {
    return this.http.post('https://localhost:44337/api/employees', data);
  }

  deleteEmployee(id: number) {
    return this.http.delete(`https://localhost:44337/api/employees/${id}`);
  }
}
