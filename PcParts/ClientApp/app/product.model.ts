export class Product {
  public name: string;
  public description: string;
  public price: string;
  public imagePath: string;

  constructor(name: string, desc: string, price: string, imgPath: string) {
    this.name = name;
    this.description = desc;
    this.price = price;
    this.imagePath = imgPath;
  }
}
