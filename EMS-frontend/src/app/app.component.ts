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

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.fetchEmployees();
    this.newEmployeeForm = new FormGroup({
      'firstName': new FormControl(null, Validators.required),
      'lastName': new FormControl(null, Validators.required),
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'phone': new FormControl(null, Validators.required),
      'dateOfBirth': new FormControl(Date.now, Validators.required),
      'address': new FormControl(null, Validators.required),
      'gender': new FormControl('male'),
      'position': new FormControl('SDE1', Validators.required),
    });
  }

  onNewEmployeeSubmit() {
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
