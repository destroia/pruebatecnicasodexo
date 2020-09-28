import { Component, OnInit } from '@angular/core';
import { Cliente } from '../modelos/cliente';
import { ClienteService } from '../Servicio/cliente.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-list-cliente',
  templateUrl: './list-cliente.component.html',
  styleUrls: ['./list-cliente.component.css']
})
export class ListClienteComponent implements OnInit {

  constructor(private ClienterSer: ClienteService, private route: Router) { }

  listClientes: Cliente[];
  ngOnInit(): void {
    this.ClienterSer.GetClientes().subscribe(x => { this.ConfirmacionClientes(x) }, error => console.log(error));
  }
  ConfirmacionClientes(x: Cliente[]) {

    this.listClientes = x;
    }
   
    
  Seleccionar(li: Cliente) {
    sessionStorage.setItem("xxx", JSON.stringify(li));
    this.route.navigate(["/Facturas"])
  }

}
