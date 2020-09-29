import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListClienteComponent } from './list-cliente/list-cliente.component';
import { ListFacturaComponent } from './list-factura/list-factura.component';
import { FacturarComponent } from './facturar/facturar.component';


@NgModule({
  declarations: [
    AppComponent,
    ListClienteComponent,
    ListFacturaComponent,
    FacturarComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
