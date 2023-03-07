import { Component } from '@angular/core';

@Component({
  selector: 'app-calculo-tarifa-component',
  templateUrl: './calculo-tarifa.component.html'
})
export class CalculoTarifaComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }

  //// ItemsOrigem
  //showItemDetailsModal(template: TemplateRef<any>, item: TodoItemDto): void {
  //  this.selectedItem = item;
  //  this.itemDetailsEditor = {
  //    ...this.selectedItem
  //  };

  //  this.itemDetailsModalRef = this.modalService.show(template);
  //}
}
