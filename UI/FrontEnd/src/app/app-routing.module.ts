import { NgModule } from '@angular/core';
import { Route, RouterModule,CanActivate } from '@angular/router';
import { StandardCalculatorComponent } from './components/standard-calculator/standard-calculator.component';
import { BasicCalculatorComponent } from './components/basic-calculator/basic-calculator.component';


const myRoutes:Route[]=[
  { path: '', redirectTo: 'standardCalculator', pathMatch: 'full' },
  {path:'basicCalculator',component:BasicCalculatorComponent},
  {path:'standardCalculator',component:StandardCalculatorComponent}]

@NgModule({
  imports: [RouterModule.forRoot(myRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
