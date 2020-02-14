import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { CalculatorService } from 'src/app/services/calculator.service';

@Component({
  selector: 'app-basic-calculator',
  templateUrl: './basic-calculator.component.html',
  styleUrls: ['./basic-calculator.component.css']
})
  export class BasicCalculatorComponent implements OnInit {
    inputvalue_1:any=null;
    inputvalue_2:any=null;
    opration:any=null;
    output:any=0;
    operator:any;
    myForm: FormGroup;
    submitted=false;
      constructor(private formBuilder:FormBuilder,private calculatorService:CalculatorService) 
      {
        this.myForm = new FormGroup
        ({
          inputvalue_1: new FormControl(),
          inputvalue_2:new FormControl()
        });
      }
      get f() {return this.myForm.controls}
      calculate()
      {
        this.submitted=true;
        if(this.myForm.invalid){
          return
        }
        if(this.myForm.valid)
        {
          this.inputvalue_1 = this.myForm.value.inputvalue_1;
          this.inputvalue_2 = this.myForm.value.inputvalue_2;
          this.calculatorService.calculation(this.inputvalue_1,this.inputvalue_2,this.opration).subscribe((data)=>
          {
            this.output = data;
            console.log(data)
          })
        }
      }
    
      ngOnInit() {
        this.myForm = this.formBuilder.group(
          {
            inputvalue_1: ['', [Validators.required,Validators.pattern('[-0-9][-0-9.]*$')]],
            inputvalue_2: ['',[Validators.required,Validators.pattern('[-0-9][-0-9.]*$')]]
          }
        )
      }
      click(operator)
      {
        this.operator = operator;
        if( operator=="+")
        {this.opration=1}
        else if (operator=="-")
        {this.opration=2}
        else if (operator == "*")
        {this.opration=3}
        else if (operator == "/")
        {this.opration=4}
        console.log(this.opration)
      }  
      clear()
      {
        if(this.myForm!=null)
        {
          this.myForm.reset();
          this.output = 0;
        }
      }
    }
    