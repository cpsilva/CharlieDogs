import { Component, OnInit } from '@angular/core';
import { ApplicationService } from 'app/shared/services/application.service';
import { caesVM } from 'app/view-module/CaesVM';

@Component({
  selector: 'app-caes',
  templateUrl: './caes.component.html'
})
export class CaesComponent implements OnInit {

  caes: caesVM[] = new Array<caesVM>();

  servicoCaes = "Cao"

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
