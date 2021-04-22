import { Endereco } from "./Endereco";


export class Cliente {

  id: string;
  nome: string;
  email: string;
  inscricaoEstadual: string;
  tipoPessoa: string;
  datanascimento: Date;
  endereco: Endereco;
  cpfCnpj: string;
  telefone: string;

  constructor() {
    this.endereco = new Endereco();
  }
}

