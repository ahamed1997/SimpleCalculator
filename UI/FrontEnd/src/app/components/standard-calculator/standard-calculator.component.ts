/**
* Imports Reqirements for StandardCalculatorComponent.
*/
import { Component, OnInit } from '@angular/core';
import { CalculatorService } from 'src/app/services/calculator.service';

@Component({
  selector: 'app-standard-calculator',
  templateUrl: './standard-calculator.component.html',
  styleUrls: ['./standard-calculator.component.css']
})

export class StandardCalculatorComponent implements OnInit {

displayValue:string="";  
operation:any;
operand1:any;
operand2:any;
numeric:Boolean;
plus:Boolean;
minus:Boolean;
asteric:Boolean;
divide:Boolean;
decimal:Boolean;

/**
* Creates an instance of StandardCalculatorComponent.
*/
constructor( private  calculatorService:CalculatorService) 
{ 
  this.plus = true;
  this.minus = true;
  this.numeric = true;
  this.decimal = true;
}

/**
* // TODO: Insertion of Operator.
* Insert (+) Operator.
* @param (+) 
*/
insertPlus(plus)
{
  if(this.plus)
  {
    this.arithmeticOperation(plus);
    this.changeCurrentStatus(true,false,false,false,false,true);
  }
  else
  {
    this.replacingElements("-",plus);
    return;
  }    
}

/**
* // TODO: Insertion of Operator.
* Insert (-) Operator.
* @param (-) 
*/
insertMinus(minus)
{
  if(this.minus)
  {
    this.arithmeticOperation(minus);
    this.changeCurrentStatus(true,false,false,false,false,true);
  }
  else
  {
    this.replacingElements("+",minus);
    return;
  }    
}

/**
* // TODO: Insertion of Operator.
* Insert (*) Operator.
* @param (*) 
*/
insertAsterick(asterick)
{
  if(this.asteric)
  {
    this.arithmeticOperation(asterick);
    this.changeCurrentStatus(true,true,true,false,false,true);
  }
  else
  {
    this.replacingElements("/",asterick);
    return;
  }
}

/**
* // TODO: Insertion of Operator.
* Insert (/) Operator.
* @param (/) 
*/
insertDivide(divide)
{
  if(this.divide)
  {
    this.arithmeticOperation(divide);
    this.changeCurrentStatus(true,true,true,false,false,true);
  }
  else
  {
    this.replacingElements("*",divide);
    return;
  }
}

/**
* // TODO: Insertion of Numerics.
* Insert Numerics.
* @param (0-9) 
*/
insertNumerics(numeric)
{
  if((this.numeric) &&(this.displayValue.length<11))
  {
    this.displayValue += numeric;
    this.changeCurrentStatus(true,true,true,true,true,this.decimal);
  }
  else
  {
    return;
  }
}

/**
* // TODO: Insertion of Decimal.
* Insert (.) Operator.
* @param (.) 
*/
insertDecimal(decimal)
{
  if((this.decimal)&&(this.displayValue.length<11))
  {
    this.displayValue += decimal;
    this.changeCurrentStatus(true,false,false,false,false,false);
  }
  else
  {
    return;
  }
}

/**
* // TODO: Replacement.
* Replacement from one opertor to another.
* @param from operator. 
* @param to operator.
*/
replacingElements(from,to)
{
  if(this.displayValue.charAt(this.displayValue.length-1) == from)
  {      
    this.displayValue=this.displayValue.slice(0,-1);
    this.displayValue+= to;
  }
}

/**
* // TODO: Arithmetic Operation.
* Takes type of Operation.
* @param operator. 
*/
arithmeticOperation(operator)
{
  this.operand1 = this.displayValue.substring(0, this.getIndex());
  this.operand2 = this.displayValue.substring(this.getIndex()+1);
  this.operation = this.displayValue.charAt(this.getIndex());
  if((this.operand1!="")&&(this.operand2!=""))
  {      
    this.calculatorService.calculate(this.operand1,this.operand2,this.operation).subscribe(data=>{
      this.displayValue = data + operator;
      return ;
    })
  }
  else if((operator != "=")&&(this.displayValue.length<11))
  {
    this.displayValue +=operator;
    return;
  }    
}

/**
* // TODO: Find Index.
* Find operator index.
* @returns index.
*/
getIndex():number
{
  let array = ['+','-','*','/']
  for(var i=1;i<this.displayValue.length;i++)
  {
    for(var j=0;j<array.length;j++)
    {
      if(this.displayValue.charAt(i)==array[j])
      {
        return i;
      } 
    }        
  }
  return -1;
}

/**
* // TODO: Operator Status change.
* Changes operator changes.
* @param Numeric
* @param Plus
* @param Minus
* @param Asterik
* @param Divide
* @param Decimal
*/
changeCurrentStatus(Numeric:boolean,Plus:boolean,Minus:boolean,Asterik:boolean,Divide:boolean,Decimal:Boolean)
{
  this.numeric = Numeric;
  this.plus = Plus;
  this.minus = Minus;
  this.asteric = Asterik;
  this.divide = Divide;
  this.decimal = Decimal;
}

/**
* // TODO: Deletes last item.
* Deletes last element Displayed depending upon last element.
*/
deleteLastItem()
{   
  this.displayValue = this.displayValue.slice(0,-1);
  let lastElement = this.displayValue.charAt(this.displayValue.length-1);
  switch(lastElement)
  {
    case "+":
      this.changeCurrentStatus(true,false,false,false,false,true);
      return;
    case "-":
      this.changeCurrentStatus(true,false,false,false,false,true);
      return;
    case "*":
      this.changeCurrentStatus(true,true,true,false,false,true);
      return;
    case "/":
      this.changeCurrentStatus(true,true,true,false,false,true);
      return;
    case ".":
      this.changeCurrentStatus(true,false,false,false,false,false);
      return;
    default :
    this.changeCurrentStatus(true,true,true,true,true,this.decimal);
    return;
  }
}

/**
* // TODO: Delete all elements in display.
* Deletes all Elements and change status of operators.
*/
deleteAll()
{
  this.displayValue ="";
  this.plus = true;
  this.minus = true;
  this.numeric = true;
  this.decimal = true;
  this.asteric = false;
  this.divide = false;
}

/**
* Initializing the component.
*/
ngOnInit() {
}
}

