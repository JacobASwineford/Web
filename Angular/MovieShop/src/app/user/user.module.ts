import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { UserRoutingModule } from './user-routing.module';
import { FormsModule } from '@angular/forms';
import { UserFavoritesComponent } from './user-favorites/user-favorites.component';
import { UserPurchasesComponent } from './user-purchases/user-purchases.component';


@NgModule({
  declarations: [
  
    UserFavoritesComponent,
       UserPurchasesComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule,
  ]
})
export class UserModule { }
