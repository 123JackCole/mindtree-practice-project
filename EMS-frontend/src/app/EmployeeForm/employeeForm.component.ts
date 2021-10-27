import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";
import { FormGroup, FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-employeeForm',
  templateUrl: './employeeForm.component.html'
})
export class EmployeeFormComponent {
  genders = ['male', 'female'];
  employeeForm!: FormGroup;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.employeeForm = new FormGroup({
      'firstName': new FormControl(null, Validators.required),
      'lastName': new FormControl(null, Validators.required),
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'phone': new FormControl(null, Validators.required),
      'dateOfBirth': new FormControl(Date.now, Validators.required),
      'address': new FormControl(null, Validators.required),
      'gender': new FormControl('male'),
      'role': new FormControl('SDE1', Validators.required),
    });
    //this.employeeForm = new FormGroup({
    //    'firstName': new FormControl(this.employee.firstName, Validators.required),
    //    'lastName': new FormControl(this.employee.lastName, Validators.required),
    //    'email': new FormControl(this.employee.email, [Validators.email, Validators.required]),
    //    'phone': new FormControl(this.employee.phone, Validators.required),
    //    'dateOfBirth': new FormControl(this.employee.dateOfBirth, Validators.required),
    //    'address': new FormControl(this.employee.address, Validators.required),
    //    'gender': new FormControl(this.employee.gender),
    //    'role': new FormControl(this.employee.role, Validators.required),
    //  });
  }

  createEmployee(data: Object) {
    this.http.post('https://localhost:44337/api/employees', data).subscribe(response => {
      console.log(response)
      // redo fetch employees
    });
  }

  onSubmit() {
    console.log(this.employeeForm);
    console.log(this.employeeForm.value);
    this.createEmployee(this.employeeForm.value)
  }
}
