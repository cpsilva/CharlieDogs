import { Component, OnInit } from '@angular/core';
import { caesVM } from 'app/view-module/CaesVM';
import { ActivatedRoute } from '@angular/router';
import { ApplicationService } from 'app/shared/services/application.service';

@Component({
  selector: 'app-detalhe-cao',
  templateUrl: './detalhe-cao.component.html'
})
export class DetalheCaoComponent implements OnInit {

  cao: caesVM = new caesVM();

  idCao: number;

  servicoCao: string = "Cao";

  constructor(
    private applicationService: ApplicationService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.idCao = this.route.snapshot.params["id"];
    this.buscar(this.idCao);
  }

  public buscar(id) {
    this.applicationService.get<caesVM>(this.servicoCao, { idCachorro: id })
      .subscribe(result => {
        if (!result) {
          this.cao = new caesVM();
        } else {
          this.cao = result;
        }
      });
  }

}
