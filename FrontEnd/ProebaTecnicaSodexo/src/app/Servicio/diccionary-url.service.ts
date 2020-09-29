import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DiccionaryUrlService {

  constructor() { }

  static Url: string = "https://localhost:44360/api/";

  //Clientes
  static GetClientes: string = "Clientes/GetClientes";

  //Facturas
  static GetFacturas: string = "Facturas/GetFacturas/"
  
  //Producto
  static GetProductos: string = "Productos/GetPeoductos/";

  //Venta
  static PostVenta: string = "Productos/PostVenta/"
}
