import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListClienteComponent } from './list-cliente/list-cliente.component';
import { ListFacturaComponent } from './list-factura/list-factura.component';
import { FacturarComponent } from './facturar/facturar.component';


const routes: Routes = [
  { path: "", component: ListClienteComponent },
  { path: "Facturas", component: ListFacturaComponent },
  { path: "Facturar", component: FacturarComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
