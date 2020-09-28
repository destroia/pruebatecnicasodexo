import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from '../modelos/cliente';
import { HttpClient } from '@angular/common/http';
import { DiccionaryUrlService } from './diccionary-url.service';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  constructor(private http: HttpClient) { }

  GetClientes(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(DiccionaryUrlService.Url + DiccionaryUrlService.GetClientes);
  }
}
