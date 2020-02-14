import { Component, OnInit } from '@angular/core';
import { CalculatorService } from 'src/app/services/calculator.service';

@Component({
  selector: 'app-standard-calculator',
  templateUrl: './standard-calculator.component.html',
  styleUrls: ['./standard-calculator.component.css']
})
export class StandardCalculatorComponent implements OnInit {
  
  inputs:any="";  
  inputValue:any[];
  history:any="";
  value:any;
  index:any;
  operation:any;
  operand1:any;
  operand2:any;
  constructor( private  calculatorService:CalculatorService) 
  {        
    this.inputValue=[];
  }
  calculation(input)
  { 
    this.inputs += input;
    this.history += input;
    this.inputValue.push(input);
    
    // var str = "12345";
    // var newStr = str.slice(0, -1);
  }
  pop()
  {    
    var str = this.inputs;
    var newStr = str.slice(0, -1);
    this.inputs = newStr;
    var strhistory = this.history;
    var newStrHistory = strhistory.slice(0,-1);    
    this.history = newStrHistory;
    this.inputValue.pop();
  }
  delete()
  {
    this.inputs ="";
    this.inputValue=[];
    this.history="";
  }
  decimal(decimal)
  {
    var present;
    if(this.inputValue.length>=1)
    {
      for(var i=0;i<this.inputValue.length;i++)
      {
        if(this.inputValue[i] == decimal)
        {
          present=true;
          //Last digit is decimal.
        }
      }
      if(!present)
      {
        //If Last digit in the input is not an decimal.        
        let array = ['+','-','*','/'];
        var arrayValue =[];
        var indx;
        var presentDecimal,notPresent;
        arrayValue = this.inputs;
        var len = arrayValue.length;
        //To Check whether any Operator present
        for (var i = 0; i < len; i++) 
        {
          for(var j=0; j< array.length;j++)
          {
            if ( array[j] == this.inputValue[i])
            {
              indx = j;
              notPresent=true;
            }
          }            
        }
        if(!notPresent) 
        {
          //If all the inputs are Numbers.
          this.inputs+= decimal;
          this.history += decimal;
          this.inputValue.push(decimal);

        }
        else
        {
          for(let j = indx+1;j<this.inputValue.length;i++)
          {
            if(this.inputValue[j]== decimal)
            {
              presentDecimal=true;
            }            
          }
          if(!presentDecimal)
          {
            //After the operator there is no decimal.
            this.inputs+= decimal;
            this.history += decimal;
            this.inputValue.push(decimal);
          }
        }        
      }
    }
    else
    {
      //If the Inputs are empty.
      this.inputs+= decimal;
      this.history += decimal;
      this.inputValue.push(decimal);
    }
  }
  operator(inputOperator)
  {
    this.inputs.length
    let array = ['+','-','*','/','.'];
    var c=0;
    var arrayValue =[];
    arrayValue = this.inputs;
    var len = arrayValue.length; 
    if((this.inputs == '') && inputOperator != '=')
    {
      this.inputs+= 0;
      this.inputs += inputOperator;
      this.history += inputOperator;
      this.inputValue.push(inputOperator);
      return;
    }
    else if ((this.inputs== '') && inputOperator == '=')       
    {return;}
    array.forEach(function (value) {
      if(value == arrayValue[len-1])
      {
        c=1;
      }
    });        
    if((c==1) && inputOperator != '=')
    {
      var str = this.inputs;
      var newStr = str.slice(0, -1);  
      this.inputs = newStr+inputOperator;
      var strhistory = this.history;
      var newStrHistory = strhistory.slice(0,-1);    
      this.history = newStrHistory+inputOperator;
      this.inputValue.pop();
      this.inputValue.push(inputOperator);
    
    }
    else if ((c==1) && inputOperator == '=')
    {
      return;
    }
    else
    {
      //Calculation Part.
      let arrayn = ['+','-','*','/'];
      var arrayValue =[];
      var indx,val;
      arrayValue = this.inputs;
      var len = arrayValue.length;      
      for (var i = 0; i < len; i++) {
        for(var j=0; j< arrayn.length;j++)
        {
          if ( arrayn[j] == arrayValue[i])
          {
              indx = i;
              let optr = arrayn[j];
              val = optr;
          }
        }        
      }
      var operand1="",operand2="";
      for(var j=0; j< indx ; j++)
      {
        operand1 += arrayValue[j];  
      }
      for( var k=indx+1; k< len;k++)
      {
        operand2 += arrayValue[k];
      }          
      if( val=="+")
      {
        this.operation=1
      }
      else if ( val =="-")
      {
        this.operation=2
      }
      else if (val == "*")
      {
        this.operation=3
      }
      else if (val == "/")
      {
        this.operation=4
      }
      this.operand1 = operand1;
      this.operand2 = operand2;
      //CHECKING FOR LENGTH.
      if(val != undefined) 
      {
        if(operand1=="")
        {
          this.operand1 =0;
        }
        if(operand2=="")
        {
          this.operand2=0;
        }
        this.calculatorService.calculation(this.operand1,this.operand2,this.operation).subscribe((data)=>
        {
          console.log('result',data)
          if(inputOperator == '=')
          {
            this.inputs = data;
            this.history += '=';
            this.history += data;
            this.inputValue =[];
            this.inputValue.push(data);
          }
          else
          {
          this.inputs = data + inputOperator;
          this.history += '=';
          this.history += data + inputOperator;
          this.inputValue =[];
          this.inputValue.push(data);
          this.inputValue.push(inputOperator);
          }          
        })
      } 
      else if (inputOperator != '=')
      {        
        this.inputs += inputOperator;
        this.history += inputOperator;
        this.inputValue.push(inputOperator);      
      } 
    }
  }
  ngOnInit() {
  }
}

