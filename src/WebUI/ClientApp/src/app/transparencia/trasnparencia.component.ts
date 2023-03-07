import { Component } from '@angular/core';
import { WeatherForecastClient, WeatherForecast } from '../web-api-client';

@Component({
  selector: 'app-transparencia',
  templateUrl: './transparencia.component.html'
})
export class TransparenciaComponent {
  public forecasts: WeatherForecast[] = [];

  constructor(private client: WeatherForecastClient) {
    client.get().subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}
