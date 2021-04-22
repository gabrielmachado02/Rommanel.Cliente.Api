import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from "rxjs/index";
import { Cliente } from "../../modelo/cliente";
import { ValidationResult } from "../../modelo/ValidationResult";


@Injectable()
export class ClienteService {

  constructor(private http: HttpClient) { }
  baseUrl: string = 'https://localhost:5001/cliente/api/';


  getCliente(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(this.baseUrl + "getAll");
  }

  getClienteById(id: string): Observable<Cliente> {
    return this.http.get<Cliente>(this.baseUrl+id);
  }

  createCliente(cliente: Cliente): Observable<ValidationResult> {
    return this.http.post<ValidationResult>(this.baseUrl +"add", cliente);
  }

  updateCliente(cliente: Cliente): Observable<ValidationResult> {
    return this.http.put<ValidationResult>(this.baseUrl+"update", cliente);
  }

  deleteCliente(id: string): Observable<ValidationResult> {
    return this.http.delete<ValidationResult>(this.baseUrl+"remove/" + id);
  }
}
