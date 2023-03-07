import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthorizeGuard } from '../api-authorization/authorize.guard';
import { HomeComponent } from './home/home.component';
import { CalculoTarifaComponent } from './calculo-tarifa/calculo-tarifa.component';
import { TransparenciaComponent } from './transparencia/trasnparencia.component';
import { TokenComponent } from './token/token.component';

export const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'calculo-tarifa', component: CalculoTarifaComponent },
  { path: 'transparencia', component: TransparenciaComponent },
  { path: 'token', component: TokenComponent, canActivate: [AuthorizeGuard] }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
