import { Component, OnInit } from '@angular/core';
import { Employer } from './employer';
import { EMPLOYEE } from './mock-employee'

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
  employee = EMPLOYEE;

  constructor() { }

  ngOnInit() {
  }

}
