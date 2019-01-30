import * as tslib_1 from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { ContactComponent } from './contact/contact.component';
import { ProductService } from './product.service';
import { UpdateRowsPipe } from './updaterows.pipe';
var routes = [
    { path: 'product-details', component: ProductDetailsComponent },
    { path: 'contact', component: ContactComponent },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegisterComponent },
    { path: '**', component: AppComponent },
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib_1.__decorate([
        NgModule({
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
                })
            ],
            providers: [ProductService],
            bootstrap: [AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
export { AppModule };
//# sourceMappingURL=app.module.js.map