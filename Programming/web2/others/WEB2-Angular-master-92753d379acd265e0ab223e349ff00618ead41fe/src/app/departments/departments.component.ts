import { Component, OnInit } from '@angular/core';
import { Department } from './department';
import { DEPARTMENTS } from './mock-departments'

@Component({
  selector: 'app-departments',
  templateUrl: './departments.component.html',
  styleUrls: ['./departments.component.css']
})

export class DepartmentsComponent implements OnInit {
  departments = DEPARTMENTS;
  constructor() {}

  ngOnInit() {

  }

}
