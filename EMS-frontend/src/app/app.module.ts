import { NgModule } from '@angular/core';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { EmployeeComponent } from './Employee/employee.component';
import { EmployeesComponent } from './Employees/employees.component';
import { NewEmployeeFormComponent } from './NewEmployeeForm/newEmployeeForm.component';
import { HeaderComponent } from './header/header.component';
import { EditEmployeeFormComponent } from './EditEmployeeForm/editEmployeeForm.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeeComponent,
    EmployeesComponent,
    NewEmployeeFormComponent,
    HeaderComponent,
    EditEmployeeFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
