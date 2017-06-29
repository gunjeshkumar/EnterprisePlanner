import { Component, EventEmitter, OnChanges, Output, Input } from '@angular/core';
import { Grid } from "app/lib/grid";

@Component({
  selector: 'table-body',
  templateUrl: './tbody.component.html',
  styles: []
})
export class TbodyComponent implements OnChanges {
  @Input() grid: Grid;
  
  @Output() edit = new EventEmitter<any>();
  @Output() delete = new EventEmitter<any>();

  noDataMessage: string;
  showActionButtons: boolean;
  constructor() { }

 ngOnChanges() {
    this.noDataMessage = this.grid.getSetting('noDataMessage');
  }

}