import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {WinDesktopComponent} from './win-desktop/win-desktop.component';

const routes: Routes = [];

@NgModule({
  imports: [    RouterModule.forRoot([
    { path: '', component: WinDesktopComponent },
  ])],
  exports: [RouterModule]
})
export class AppRoutingModule { }
