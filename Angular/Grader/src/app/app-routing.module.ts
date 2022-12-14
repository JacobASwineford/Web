import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClassComponent } from './class/class.component';
import { StudentsComponent } from './students/students.component';

const routes: Routes = [
  {
    path: "students",
    component: StudentsComponent
  },
  {
    path: "class",
    component: ClassComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
