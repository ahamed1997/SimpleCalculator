import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CalculatorService } from './services/calculator.service';
import { HttpClientModule } from '@angular/common/http';
import { StandardCalculatorComponent } from './components/standard-calculator/standard-calculator.component';
import { BasicCalculatorComponent } from './components/basic-calculator/basic-calculator.component';

@NgModule({
  declarations: [
    AppComponent,
    BasicCalculatorComponent,
    StandardCalculatorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserModule,
    FormsModule
  ],
  providers: [CalculatorService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA]
})
export class AppModule { }
