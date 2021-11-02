import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { iEmployee } from "../Employee/iEmployee.model";

@Component({
  selector: 'app-edit-employee-form',
  templateUrl: './editEmployeeForm.component.html',
  styleUrls: ['./editEmployeeForm.component.css']
})
export class EditEmployeeFormComponent {
  editEmployeeForm!: FormGroup;
  genders = ['Male', 'Female'];

  @Input() employeeData!: iEmployee;

  @Output() formData: EventEmitter<iEmployee> = new EventEmitter<iEmployee>();

  ngOnInit(): void {
    this.editEmployeeForm = new FormGroup({
      'firstName': new FormControl(this.employeeData.firstName, Validators.required),
      'lastName': new FormControl(this.employeeData.lastName, Validators.required),
      'email': new FormControl(this.employeeData.email, [Validators.email, Validators.required]),
      'phone': new FormControl(this.employeeData.phone, Validators.required),
      'dateOfBirth': new FormControl(new Date(this.employeeData.dateOfBirth).toLocaleDateString('en-CA'), Validators.required),
      'address': new FormControl(this.employeeData.address, Validators.required),
      'gender': new FormControl(this.employeeData.gender),
      'role': new FormControl(this.employeeData.role, Validators.required),
    });
  }

  onSubmit() {
    this.formData.next(this.editEmployeeForm.value);
  }

}
