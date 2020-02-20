/**
* Imports Reqirements for BasicCalculatorComponent.
*/
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { CalculatorService } from 'src/app/services/calculator.service';

@Component({
  selector: 'app-basic-calculator',
  templateUrl: './basic-calculator.component.html',
  styleUrls: ['./basic-calculator.component.css']
})


export class BasicCalculatorComponent implements OnInit {

  inputValue1:number=null;
  inputValue2:number=null;
  operation:any=null;
  output:number=0;
  validationForm: FormGroup;
  formSubmission=false;

/**
* Creates an instance of BasicCalculatorComponent.
*/
constructor(private formBuilder:FormBuilder,private calculatorService:CalculatorService) 
{
  this.validationForm = new FormGroup
  ({
    inputValue1: new FormControl(),
    inputValue2:new FormControl()
  });
}

/**
* Passage of Form Controls.
*/
get validationControls() 
{
  return this.validationForm.controls
}

/**
  * // TODO: Arithmetic Operation.
  * API call to Backend for Arithmetic operation.
  */
basicCalculation()
{
  this.formSubmission=true;
  if(this.validationForm.invalid)
  {
    return
  }
  else if(this.validationForm.valid)
  {
    this.inputValue1 = this.validationForm.value.inputValue1;
    this.inputValue2 = this.validationForm.value.inputValue2;
    this.calculatorService.calculate(this.inputValue1,this.inputValue2,this.operation).subscribe((data)=>
    {
      this.output = data;
    })
  }
}

/**
* // TODO: Operator Assignment.
* Assigns the Operator.
*/
assignOperator(operator)
{
  this.operation = operator;
}      

/**
* // TODO: Delete all elements in display.
* Deletes all Elements.
*/
deleteAll()
{
  if(this.validationForm!=null)
  {
    this.validationForm.reset();
    this.output = 0;
  }
}

/**
  * Initializing the component.
  */
ngOnInit() {
  this.validationForm = this.formBuilder.group(
    {
      inputValue1: ['', [Validators.required,Validators.pattern('[-0-9][-0-9.]*$')]],
      inputValue2: ['',[Validators.required,Validators.pattern('[-0-9][-0-9.]*$')]]
    }
  )
}
}
