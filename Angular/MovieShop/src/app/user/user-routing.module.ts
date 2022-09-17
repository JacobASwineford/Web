import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserFavoritesComponent } from './user-favorites/user-favorites.component';
import { UserPurchasesComponent } from './user-purchases/user-purchases.component';

const routes: Routes = [
  {
    path: "",
    children:
    [
      {
        path: "favorites",
        component: UserFavoritesComponent
      },
      {
        path: "purchases",
        component: UserPurchasesComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }
