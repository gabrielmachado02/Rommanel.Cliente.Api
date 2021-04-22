import { Component, OnInit, Inject } from '@angular/core';
import { Cliente } from '../../modelo/cliente';
import { Router } from "@angular/router";
import { ClienteService } from '../../Services/Clientes/clienteService';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-lista-cliente',
  templateUrl: './lista-cliente.component.html',
  styleUrls: ['./lista-cliente.component.css']
})

export class ListaClienteComponent implements OnInit {

  clientes: Cliente[];

  constructor(private clienteService: ClienteService, private router: Router) { }

  ngOnInit() {
    
    this.loadData();
  }
  loadData() {
    return this.clienteService.getCliente().subscribe(clientes => {
      this.clientes = clientes;
      console.log(clientes);

    });
  }

  deleteCliente(cliente: Cliente) {
    this.clienteService.deleteCliente(cliente.id)
      .subscribe(
        data => {
          console.log(data);
          this.loadData();
        },
        error => console.log(error));
  }
  ClienteDetalhe(cliente: Cliente) {
    this.router.navigate(['cadastrocliente/', cliente.id]);
  }

  addCliente() {
    this.router.navigate(['cadastrocliente/']);
  }
}
