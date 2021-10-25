import { Component } from '@angular/core';
import { FormGroup, FormControl, FormArray, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'EMS';
  genders = ['male', 'female'];
  newEmployeeForm!: FormGroup;

  ngOnInit() {
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
}
