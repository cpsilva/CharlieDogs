import { Pipe, PipeTransform } from '@angular/core';

@Pipe({ name: 'enum' })
export class EnumPipe implements PipeTransform {
  transform(value: any, args?: any): any {
    value = Number(value);

    if (args === 'EnumTipoPorte') {
      if (value === 1) { return "Pequeno"; }
      else if (value === 2) { return "Médio"; }
      else if (value === 3) { return "Grande"; }
    }

    if (args === 'EnumCorPredominante') {
      if (value === 1) { return "Branco"; }
      else if (value === 2) { return "Preto"; }
      else if (value === 3) { return "Marrom"; }
      else if (value === 3) { return "Cinza"; }
    }

    return null;

  }
}
