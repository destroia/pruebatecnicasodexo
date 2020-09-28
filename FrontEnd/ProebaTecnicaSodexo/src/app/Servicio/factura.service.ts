import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Facturas } from '../modelos/facturas';
import { DiccionaryUrlService } from './diccionary-url.service';

@Injectable({
  providedIn: 'root'
})
export class FacturaService {

  constructor(private http: HttpClient) {
  }
  GetFacturas(id: string): Observable<Facturas[]>
  {
    return this.http.get<Facturas[]>(DiccionaryUrlService.Url + DiccionaryUrlService.GetFacturas + id)
  }
}
