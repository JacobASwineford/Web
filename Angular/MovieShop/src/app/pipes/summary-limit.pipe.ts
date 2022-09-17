import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'summaryLimit'
})
export class SummaryLimitPipe implements PipeTransform {

  transform(value: string | undefined): string {
    return value?.substring(0, 20)! + "...";
  }

}
