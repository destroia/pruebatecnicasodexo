import { Component, OnInit } from '@angular/core';
import { Facturas } from '../modelos/facturas';
import { Cliente } from '../modelos/cliente';
import { FacturaService } from '../Servicio/factura.service';

@Component({
  selector: 'app-list-factura',
  templateUrl: './list-factura.component.html',
  styleUrls: ['./list-factura.component.css']
})
export class ListFacturaComponent implements OnInit {

  constructor(private facturasSer: FacturaService) {
  }
  cliente: Cliente;
  listFacturas: Facturas[];
  ngOnInit(): void {
    this.cliente = JSON.parse(sessionStorage.getItem("xxx"));
    console.log(this.cliente);
    this.facturasSer.GetFacturas(this.cliente.id).subscribe(x => { this.ConfirmarFacturas(x) }, error => console.log(error));
  }
  ConfirmarFacturas(x: Facturas[]) {
    console.log(x);
    this.listFacturas = x;
  }

  Facturar() {
    
  }

}
