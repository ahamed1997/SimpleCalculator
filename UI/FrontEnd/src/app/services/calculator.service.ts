/**
* Imports Reqirements.
*/
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

/**
* Dependency Injection.
*/
@Injectable({
    providedIn:'root'
})

/**
* Export CalculatorService.
*/
export class CalculatorService
{
result:any;
readonly rootURL="https://localhost:44333/MathCalculator/ArithmeticCalculator?firstValue="

/**
* Creates an instance of CalculatorService.
*/
constructor(private myHttp:HttpClient)
{
    this.result;
}

/**
* // TODO: Arithmetic Operation.
* API call to Back End.
* @param Operand1.
* @param Operand2.
* @param operationType.
* @returns calculated answer.
*/
calculate(firstValue:any,secondValue:any,operation:any):Observable<any>
{
operation = this.getOperator(operation);
return this.myHttp.get(this.rootURL+firstValue+"&secondValue="+secondValue+"&operationType="+operation);
}

/**
* // TODO: Finding Operation.
* Find the operations.
* @param operator.
* @returns Operation type.
*/
getOperator(operator):number
{
    if( operator=="+")
    {
        return 1;
    }
    else if ( operator =="-")
    {
        return 2;        }
    else if (operator == "*")
    {
        return 3;        }
    else if (operator == "/")
    {
        return 4;        
    }
}
}