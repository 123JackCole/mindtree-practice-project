import { Component } from '@angular/core';
import { FormGroup, FormControl, FormArray, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'EMS';
  genders = ['male', 'female'];
  newEmployeeForm!: FormGroup;

  constructor(private http: HttpClient) {

  }

  ngOnInit() {
    this.fetchEmployees();
    this.newEmployeeForm = new FormGroup({
      'employeeData': new FormGroup({
        'firstName': new FormControl(null, Validators.required),
        'email': new FormControl(null, [Validators.email, Validators.required])
      }),
      'gender': new FormControl('male')
    });
  }

  onSubmit() {
    console.log(this.newEmployeeForm)
  }

  //onCreateEmployee() {

  //}

  private fetchEmployees() {
    this.http.get('https://localhost:44337/api/employees').subscribe(employees => {
      console.log(employees);
    });
  }
}
