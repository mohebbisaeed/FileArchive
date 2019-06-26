import {Component, EventEmitter, OnInit, Output} from '@angular/core';

@Component({
  selector: 'app-win-file-explore',
  templateUrl: './win-file-explore.component.html',
  styleUrls: ['./win-file-explore.component.css']
})
export class WinFileExploreComponent implements OnInit {
  @Output() closing = new EventEmitter();
  @Output() minimizing = new EventEmitter();

  constructor() {
  }

  ngOnInit() {
  }

  close() {
    this.closing.emit(true);
  }

  minimize() {
    this.minimizing.emit(true);
  }
}
