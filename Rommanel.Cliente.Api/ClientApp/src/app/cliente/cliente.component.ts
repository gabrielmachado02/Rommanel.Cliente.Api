import { Component, OnInit, Inject } from '@angular/core';
import { Cliente } from '../modelo/cliente';
import { Router, ActivatedRoute } from "@angular/router";
import { ClienteService } from '../Services/Clientes/clienteService';
import { Observable } from 'rxjs';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
@Component({
  selector: 'app-cliente',
  templateUrl: './cliente.component.html',
  styleUrls: ['./cliente.component.css']
})
export class ClienteComponent implements OnInit {

  clientes: Cliente[];
  cliente: Cliente;
  id: string;
  addForm: FormGroup;

  constructor(private route: ActivatedRoute, private formBuilder: FormBuilder, private router: Router, private clienteService: ClienteService) {


  }
  ngOnInit() {

    this.id = this.route.snapshot.paramMap.get('id')
    if (this.id != null) {
      this.getClienteId(this.id);

    }
    else {
      this.cliente = new Cliente();

    }

    this.addForm = this.formBuilder.group({

      nome:['', Validators.required],
      cpfCnpj:['', Validators.required],
      dataNascimento:['', Validators.required],
      telefone:['', Validators.required],
      email:['', Validators.required],
      logradouro:['', Validators.required],
      tipoPessoa: ['', Validators.required],
      inscricaoEstadual :[''],
      numero: ['', Validators.required],
      cep: ['', Validators.required],
      bairro: ['', Validators.required],
      cidade:['', Validators.required],
      estado: ['', Validators.required],

    });
  }

  Save(cliente: Cliente) {

    if (this.id != null) {

      this.update(this.cliente);

    }
    else {
      this.CadastrarCliente(this.cliente);
    }
  }


  CadastrarCliente(cliente: Cliente) {
    this.clienteService.createCliente(cliente)
      .subscribe(data => {
        console.log(data);
        this.router.navigate(['listacliente']),
          error => {
            console.log(error);
          }
      });
  }
  getClienteId(id: string) {

    return this.clienteService.getClienteById(id).subscribe(data => {

      if (data != null) {
        this.cliente = data;
      } else {
        this.cliente = new Cliente();

      }
      console.log(data);

      console.log(this.cliente);
    },
    )
  }

  update(cliente: Cliente) {
    this.clienteService.updateCliente(cliente)
      .subscribe(data => {
        this.router.navigate(['listacliente']);
      });
  }
}
