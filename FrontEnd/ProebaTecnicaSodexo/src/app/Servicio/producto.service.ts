import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Producto } from '../modelos/producto';
import { DiccionaryUrlService } from './diccionary-url.service';

@Injectable({
  providedIn: 'root'
})
export class ProductoService {

  constructor(private http: HttpClient) { }

  GetProductos(): Observable<Producto[]> {
    return this.http.get<Producto[]>(DiccionaryUrlService.Url + DiccionaryUrlService.GetProductos);
  }
  PostProductos(Lp: Producto[],idCliente : string): Observable<boolean> {
    return this.http.post<boolean>(DiccionaryUrlService.Url + DiccionaryUrlService.PostVenta + idCliente ,Lp);
  }
}
