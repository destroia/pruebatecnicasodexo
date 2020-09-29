import { Component, OnInit } from '@angular/core';
import { ProductoService } from '../Servicio/producto.service';
import { Producto } from '../modelos/producto';
import { Cliente } from '../modelos/cliente';
import { Router } from '@angular/router';

@Component({
  selector: 'app-facturar',
  templateUrl: './facturar.component.html',
  styleUrls: ['./facturar.component.css']
})
export class FacturarComponent implements OnInit {

  constructor(private productoSer: ProductoService, private router: Router) { }
  ListProductos: Producto[];
  carrito: string = "carrito";
  ListCompras: Producto[] = new Array();

  ngOnInit(): void {
    this.usu = JSON.parse(sessionStorage.getItem("xxx"));
    this.productoSer.GetProductos().subscribe(x => { this.ConfirmarProductos(x) }, error => console.log(error));
  }
  usu: Cliente;
  ConfirmarProductos(x: Producto[]) {
    for (var i = 0; i < x.length; i++) {
      x[i].cantidad = 1;
    }
    this.ListProductos = x;
    
  }
  Menos(li: Producto) {
    if (li.cantidad > 1) {
      li.cantidad -= 1;
    }
  }
  Mas(li: Producto) {
    li.cantidad = li.cantidad + 1;
  }
  Agregar(li: Producto) {
    try {
      let find = this.ListCompras.filter(x => x.id == li.id);
      if (li.id == find[0].id && li.cantidad == find[0].cantidad) {
        return;
      } else if (li.id == find[0].id) {
        let i = this.ListCompras.indexOf(find[0])
        this.ListCompras.splice(i);
      }
    } catch (e) {

    }
    
    this.ListCompras.push(li);
  
    console.log(this.ListCompras)
  }
  
  Eliminar(li: Producto) {
    
    console.log(this.ListCompras)
    try {
      let find = this.ListCompras.filter(x => x.id == li.id);
      let i = this.ListCompras.indexOf(find[0])
      this.ListCompras.splice(i);
    } catch (e) {

    }
    
    console.log(this.ListCompras)
  }

  Comprar() {
    if (this.ListCompras[0] == null) {
      alert("no hay nada en el carrito");
      return;
    }

    this.productoSer.PostProductos(this.ListCompras, this.usu.id).subscribe(x => { this.ConfirmarCompra(x) }, error => console.log(error))
  }
    ConfirmarCompra(x: boolean) {
      if (x) {
        this.router.navigate(["/Facturas"])
      } else {
alert("Algo inesperado ha sucedido")
      }
    }
}
