import { Component } from '@angular/core';
import { Product } from './product.model';
import { ProductService } from './product.service';

@Component({
  selector: 'app-products',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

    products: Product[];
    numOfProducts: number;

    constructor(private prodService: ProductService) { }

    ngOnInit() {
        this.products = this.prodService.getProducts();
        this.numOfProducts = this.products.length;
    }
}
