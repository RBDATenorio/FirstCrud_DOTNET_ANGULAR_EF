import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bandas',
  templateUrl: './bandas.component.html',
  styleUrls: ['./bandas.component.scss']
})
export class BandasComponent implements OnInit {

  imgLarg: number = 70;
  imgMarg: number = 2;
  title = "Best Metal Bands Ever!"
  bandas: any = [];
  mostrarImg: boolean = false;

  _filtroLista: string;
  get filtroLista(): string{
    return this._filtroLista;
  }
  set filtroLista(value: string){
    this._filtroLista = value;
    this.bandasFiltradas = this.filtroLista ? this.filrarBandas(this.filtroLista) : this.bandas;
  }
  
  bandasFiltradas: any = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getBandas();
  }

  filrarBandas(filtrarPor: string): any{
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.bandas.filter(
      banda => banda.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
    );
  }

  alternarImg(){
    this.mostrarImg = !this.mostrarImg;
  }

  getBandas(){
    this.http.get('http://localhost:5000/api/values').subscribe(
      response => { this.bandas = response; 
      }, error => {
        console.log(error);
      }
    );
  }

}
