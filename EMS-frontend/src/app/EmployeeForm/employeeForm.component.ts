import { Component } from "@angular/core";
import { FormGroup, FormControl, FormArray, Validators } from '@angular/forms';

@Component({
  selector: 'app-employeeForm',
  templateUrl: './employeeForm.component.html'
})
export class EmployeeFormComponent {
  genders = ['male', 'female'];
  employeeForm!: FormGroup;

  ngOnInit() {
    this.employeeForm = new FormGroup({
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

  onSubmit() {
    console.log(this.employeeForm)
  }
}
