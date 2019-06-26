import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-win-desktop',
  templateUrl: './win-desktop.component.html',
  styleUrls: ['./win-desktop.component.css']
})
export class WinDesktopComponent implements OnInit {

  fileExploreFlag = false;
  sidebarEnd = false;
  expanded = false;
  wasExpanded = false;
  constructor() {
  }

  ngOnInit() {
  }

  fileExploreClose(action) {
    if (action === 'close') {
      this.fileExploreFlag ? this.fileExploreFlag = false : this.fileExploreFlag = true;
    }
    if (action === 'minimize') {
      this.fileExploreFlag = true;
      document.getElementById('window').style.display === '' ?
        document.getElementById('window').style.display = 'none' :
        document.getElementById('window').style.display = '';
    }
  }

  fileExploreMinimize() {
    document.getElementById('window').style.display = 'none';
  }
}
