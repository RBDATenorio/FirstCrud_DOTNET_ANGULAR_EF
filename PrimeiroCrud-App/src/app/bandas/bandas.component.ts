import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bandas',
  templateUrl: './bandas.component.html',
  styleUrls: ['./bandas.component.scss']
})
export class BandasComponent implements OnInit {

  title = "Best Metal Bands Ever!"
  bandas: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getBandas();
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
