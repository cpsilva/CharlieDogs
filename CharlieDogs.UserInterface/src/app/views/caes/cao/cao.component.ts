import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-cao',
  templateUrl: './cao.component.html'
})
export class CaoComponent implements OnInit {

  @Input() cao: any

  constructor() { }

  ngOnInit() {
  }

}
