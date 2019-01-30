import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { ProductService } from './product.service';
var AppComponent = /** @class */ (function () {
    function AppComponent(prodService) {
        this.prodService = prodService;
    }
    AppComponent.prototype.ngOnInit = function () {
        this.products = this.prodService.getProducts();
        this.numOfProducts = this.products.length;
    };
    AppComponent = tslib_1.__decorate([
        Component({
            selector: 'app-products',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [ProductService])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map