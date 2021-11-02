import { Component, EventEmitter, Output } from "@angular/core";
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { iEmployee } from "../Employee/iEmployee.model";

@Component({
  selector: 'app-new-employee-form',
  templateUrl: './newEmployeeForm.component.html'
})
export class NewEmployeeFormComponent {
  genders = ['Male', 'Female'];
  newEmployeeForm!: FormGroup;

  @Output() formData: EventEmitter<iEmployee> = new EventEmitter<iEmployee>();

  ngOnInit(): void {
    this.newEmployeeForm = new FormGroup({
      'firstName': new FormControl(null, Validators.required),
      'lastName': new FormControl(null, Validators.required),
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'phone': new FormControl(null, Validators.required),
      'dateOfBirth': new FormControl(Date.now, Validators.required),
      'address': new FormControl(null, Validators.required),
      'gender': new FormControl('male'),
      'role': new FormControl('SDE1', Validators.required)
    });
  }

  onSubmit() {
    this.formData.next(this.newEmployeeForm.value);
  }
}
