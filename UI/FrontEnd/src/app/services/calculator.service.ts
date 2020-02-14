import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
    providedIn:'root'
})

export class CalculatorService
{
    result:any;
constructor(private myHttp:HttpClient)
{
    this.result;
}
calculation(firstValue:any,secondValue:any,operation:any):Observable<any>
{
this.result = this.myHttp.get("https://localhost:44333/MathCalculator/ArithmeticCalculator?firstValue="+firstValue+"&secondValue="+secondValue+"&operationType="+operation);
console.log('result',this.result)
return this.result;
}
}