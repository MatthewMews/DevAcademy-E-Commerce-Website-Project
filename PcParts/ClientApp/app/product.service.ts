import { Product } from './product.model';

export class ProductService {

  private product: Product[] = [

    // Graphics Cards

    new Product('ASUS Radeon RX 560', `ROG Strix RX 560 gaming graphics cards are packed with exclusive ASUS technologies, including Direct CU II Technology with Patented Wing-Blade Fans for up to 30% cooler and 3X quieter performance, and Industry-only Auto-Extreme Technology for premium quality and the best reliability. Aura RGB Lighting enables a gaming system personalization. ROG Strix RX 560 also has GPU Tweak II with XSplit Game caster that provides intuitive performance tweaking and instant gameplay streaming`, '£150.97', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Graphics_Cards/asus-radeon-rx-560.jpg?raw=true'),

    new Product('EVGA Nvidia GTX 1080TI', `The EVGA GeForce GTX 1080 Ti uses NVIDIA's new flagship gaming GPU, based on the NVIDIA Pascal architecture. The latest addition to the ultimate gaming platform, this card is packed with extreme gaming horsepower, next-gen 11 Gbps GDDR5X memory, and a massive 11 GB frame buffer.`, '£798.77',
      'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Graphics_Cards/evga-gtx1080ti.jpg?raw=true'),

    new Product('Gigabyte Nvidia GTX 1060', `The WINDFORCE 2X cooling system features two 90mm unique blade fans, one pure copper composite heat-pipe, alternate spinning fan design, and heat pipe direct touch technology, together delivering an effective heat dissipation capacity for higher performance at lower temperatures.`,
      '£229.98', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Graphics_Cards/gigabyte-gtx1060.png?raw=true'),

    new Product('Gigabyte AMD R9 280', `Keeping the same 450W Cooling capacity using only 2 slots, the New WINDFORCE 3X 450W cooling system is equipped with two 8mm and four 6mm cooper heat-pipes , inclined fans, and GIGABYTE "Triangle Cool" technology. This not only provides an effective heat dissipation capacity but also enables higher performance due to a lower temperature`, '£209.00', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Graphics_Cards/gigabyte-radeon-r9-280.png?raw=true'),

    new Product('MSI Nvidia GTX 960', `With every new generation of GPUs comes more performance. With every new generation of MSI Twin Frozr, we give you less noise and heat! We've listened to all your requests and the new Twin Frozr V is smaller, features stronger fans, generates less noise, keeps your graphics card and its components cooler and matches perfectly with your MSI GAMING motherboard including some funky LED lighting. We've spent 18 months on the development of the Twin Frozr V, including field testing in gaming cafés to ensure the cards have the quality and stability to give you the FPS you need!`, '£170.00', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Graphics_Cards/msi-gtx960.jpg?raw=true'),

    new Product('MSI Radeon RX 570', `This 4th Gen Radeon RX graphics card has been designed for gamers and their game of choice, whether that be the latest MOBA or the latest AAA title. The GAMING X GPU from MSI is packed with technologies that’ll help with overall performance, cooling and even style – thanks to the RGB LEDs it features. Asynchronous Shaders and an enhanced Geometry Engine power new levels of smooth gameplay performance.`, '£278.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Graphics_Cards/msi-radeon-rx-570.jpg?raw=true'),


    // Monitors

    new Product('ASUS ROG Swift PG248Q 24 inch Monitor', `Product Description This Full HD LED monitor with 50,000,000:1 high contrast ratio and HDMI interface is optimised for a fine image and colour quality. This approach extends to the sturdy stand and slim profile without compromising style in ensuring stability and durability. It features Smart View technology that can adjust colour parameters to deliver the same image quality and colours with straight viewing.`, '£429.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Monitors/24inch-asus-pg248q.jpg?raw=true'),

    new Product('ASUS VG248QE 24 inch Monitor', `ASUS VG248QE 24 inch 3D LED Monitor (1920 x 1080, 80000000:1, 144 Hz, 1 ms, DVI Display Port, HDMI) - Black`, '£199.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Monitors/24inch-asus-vg248qe.png?raw=true'),

    new Product('BenQ GW2480 23.8 inch Monitor', `Designed for simplicity, BenQ GW2480 23.8 inch frameless monitor combines ultra slim bezels with hidden cable management. Complementing BenQ Eye-Care technology with Low Blue Light technology and flicker-free performance for extended viewing comfort, industry-leading Brightness Intelligence technology delivers exquisite details in any ambient lighting environment. With the ideal combination of LED and IPS technologies, GW2480 delivers a different level of visual enjoyment with truly authentic colours, deeper blacks, higher contrast and sharper details.`, '£104.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Monitors/24inch-benq-gw2480.jpg?raw=true'),

    new Product('Dell UltraSharp U2414H 23.8 inch Monitor', `See your work in its best light on the Dell UltraSharp U2414H. Its upscale design features an amazingly thin (6.05 mm) border around a 23.8" Full HD display, delivering impeccable images.`, '£244.00', 'https://raw.githubusercontent.com/MatthewMews/Temp_Project_Images/master/Product_Categories_Images/Monitors/24inch-dell-u2414h.jpeg'),

    new Product('ViewSonic XG2401 24 inch Monitor', `The ViewSonic XG2401 is the 24 Inch gaming display designed for avid gamers. It features a rapid 144 Hz refresh rate, ultra-fast 1 ms response time and a game mode to naturally and smoothly represent high-speed images and fine details in dark scenes and images. Equipped with 1920 x 1080p resolution, 120M:1 DCR and dual 2W stereo speakers, the XG2401 delivers crisp, high colour performance and crystal-clear sound quality. With integrated dual HDMI inputs, one DisplayPort input and dual USB hub connectivity, gamers have high flexibility when connecting their game consoles, Blu-ray DVD players and other devices to their display. XG2401 is a flicker free monitor with blue light filter eye-care technologies. The XG2401 also features a built-in Eco mode for saving energy. Plus, the XG2401 is fully ergonomic with -5 degrees to 20 degrees tilt, 120 degrees swivel, 90 degrees pivot, 120 mm height adjustment and a 100 x 100 mm VESA-compliant mount for more flexible installation options in any setting.`, '£253.85', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Monitors/24inch-viewsonic-xg2401.png?raw=true'),

    new Product('Acer K272HL 27 inch Monitor', `Acer Monitors give you the beauty you appreciate and the value you need. They showcase captivating widescreen visuals as well as eco-conscious features, making them perfect for enjoying marvelous multimedia at home or in your office, studio or study.`, '£190', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Monitors/27inch-acer-k272hl.jpg?raw=true'),

    // Motherboards

    new Product('ASROCK B250M-HDV', `Elegant , stylish or short: Simply chic? AS Rock presents its new motherboard. In a symbiosis between design and technology, the mainboard is equipped with high-quality technology. Designed for Intel Core ?? Processors of the sixth and seventh generation will offer you a small performance miracle. A user-friendly UEFI-BIOS is provided for the programming and adjustment, which is easy to use, additional practical features can be purchased in the shop. Experience your gaming moments up close and react before anything happens thanks to HD audio sound ?? Right in the middle there instead of just! To keep your opponent one step ahead, Gigabit Intel LAN provides best performance with low CPU utilization and optimal stability. The mainboard offers you many possibilities for your personal development. Get together with AS Rock on a discovery tour and enjoy flawless technology.`, '£51.59', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Motherboards/asrock-b250m-hdv.jpg?raw=true'),

    new Product('ASUS Intel Z390 ROG MAXIMUS XI Code', `Inspired by the rich heritage that has bound the Republic of Gamers to the world of gaming, ROG Maximus XI Code brings together the finest in ROG engineering in understated form that offers all the expansion and personalization opportunities needed to create a distinctive custom rig. With a dedicated onboard clock generator, support for the latest high-performance memory, and cooling options to keep thermals under tight control, Code provides a potent foundation for your next gaming build. `, '£345.98',
      'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Motherboards/asus-maximus-xi.png?raw=true'),

    new Product('Gigabyte AB350M-HD3', `Supports New Generation AMD Ryzen Processors, Dual Channel Non-ECC Unbuffered DDR4, 4 DIMMs, Fast 2 USB 3.1 Gen 2 with USB Type-A, Ultra-Fast PCIe Gen3 x4 M.2 with PCIe NVMe & SATA mode support High Quality Audio Capacitors and Audio Noise Guard with LED Trace Path Lighting, Realtek Gigabit LAN with cFosSpeed Internet Accelerator Software, Smart Fan, features, Temperature Sensors and Hybrid Fan Headers GIGABYTE UEFI Dual BIOS, APP Center Including EasyTune and Cloud Station Utilities`, '£67.97', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Motherboards/gigabyte-ab350m-hd3.jpg?raw=true'),

    new Product('Gigabyte GA-H110M-H', `GIGABYTE 100 series motherboards support the latest 6th Generation Intel Core processors, a 14nm desktop CPU which features improved performance, power efficiency and support for DDR4 memory, bringing cutting edge features and ultimate performance to your next PC build.`, '£49.88', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Motherboards/gigabyte-h110m-h.jpg?raw=true'),

    new Product('Msi H270-A PRO', `Combining quality you can rely on with top performance and clever business solutions are key aspects of the <b>MSI PRO SERIES</b> motherboards. Engineered to gratify even the most demanding professional, these motherboards will fit in any PC. Making your life easier and supporting your business with super stable, reliable and long-lasting top performance.`, '£123.30', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Motherboards/msi-270-a-pro.jpg?raw=true'),

    new Product('Msi B350 Gaming Pro', `Unlimited customization options and packed with exclusive gaming features, MSI PERFORMANCE GAMING motherboards offer the best possible gaming experience`, '£86.38', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Motherboards/msi-b350.jpg?raw=true'),

    // Keyboards

    new Product('Corsair K95 Platinum', `The CORSAIR Gaming K95 RGB mechanical gaming keyboard has the performance of the legendary K95, and adds multicolor per-key backlighting for virtually unlimited game customization.`, '£154.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Keyboards/corsair-k95.jpg?raw=true'),

    new Product('HP K1500', `This wired Keyboard from Hewlett Packard is a full size keyboard allowing maximum productivity and accuracy. This keyboard is ideal for use in the home or office environment.`, '£7.51',
      'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Keyboards/hp-k1500.jpg?raw=true'),

    new Product('Logitech G213', `Logitech G213 Prodigy Performance-Driven Gaming Keyboard When it comes to gaming, all keyboards are not created equal. G213 is made for the way you play. Play faster than you would using a standard keyboard thanks to performance-tuned keys that bring together the best in tactile feel and gaming-grade performance.`, '£44.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Keyboards/logitech-g213.png?raw=true'),

    new Product('Logitech K120', `The K120 USB keyboard provides a better typing experience that's built to last. Your hands will enjoy the low-profile, whisper-quiet keys and standard layout with full-size F-keys and number pad. The slim keyboard isn’t just sleek - it’s tough with a spill-resistant design, sturdy tilt legs and durable keys. Simply plug it into a USB port on your desktop, laptop or notebook computer and get to work straight away.`, '£8.09', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Keyboards/logitech-k120.jpg?raw=true'),

    new Product('Razer Blackwidow Ultimate 2016', `The Razer BlackWidow Ultimate features the all-new Razer mechanical switches which were designed from the ground up to elevate the speed and responsiveness of the Razer BlackWidow gaming keyboard beyond the capabilities of previous generation mechanical switches. The individually backlit fully programmable keys allow for dynamic lighting effects that allow gamers to take complete control of the keyboard's lighting system for a personalised gaming experience.`, '£109.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Keyboards/razer-blackwidow-ultimate.jpg?raw=true'),

    new Product('SteelSeries Apex 150', `The SteelSeries Apex 150 gaming keyboard delivers an ultra-fast and quiet key feel with guaranteed 20-million clicks and splash resistance for lifelong durability. With customizable and brilliant five-zone Prism RGB illumination and Game Sense reactive in-game lighting, the Apex 150 lights up your battle station. Fully-programmable keys, combined with advanced anti-ghosting and 24-key rollover deliver fast-paced, accurate gaming.`, '£88.99', 'https://github.com/MatthewMews/Temp_Project_Images/blob/master/Product_Categories_Images/Keyboards/steelseries-apex150rgb.jpg?raw=true'),


  ];

  getProducts() {
    return this.product.slice();
  }

}
