import { Component, OnInit } from '@angular/core';
import { ApplicationService } from 'app/shared/services/application.service';
import { caesVM } from 'app/view-model/CaesVM';

@Component({
  selector: 'app-caes',
  templateUrl: './caes.component.html'
})
export class CaesComponent implements OnInit {

  caes: caesVM[] = new Array<caesVM>();

  term: any;

  servicoCaes = "CaoGrid"

  constructor(
    private applicationService: ApplicationService
  ) { }

  ngOnInit() {
    this.applicationService.get<caesVM[]>(this.servicoCaes)
      .subscribe(result => {
        this.caes = result;
      })
  }

}
