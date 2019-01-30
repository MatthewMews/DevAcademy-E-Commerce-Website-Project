import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';


import { AppComponent } from './app.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ContactComponent } from './contact/contact.component';
import { ProductService } from './product.service';
import { UpdateRowsPipe } from './updaterows.pipe';



const routes: Routes = [
    { path: 'product-details', component: ProductDetailsComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: '**', component: AppComponent },
];

@NgModule({
  declarations: [
    AppComponent,
    ProductDetailsComponent,
    LoginComponent,
    RegisterComponent,
    ContactComponent,
    UpdateRowsPipe
  ],
  imports: [
      BrowserModule,
      RouterModule.forRoot(routes, {
        scrollPositionRestoration: 'enabled',
        })],
    providers: [ProductService],
    bootstrap: [AppComponent]
})
export class AppModule { }
