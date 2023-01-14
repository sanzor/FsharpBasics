module modu
open System.Drawing;
open System
open System.Windows


type Gender= Female | Male
type WorkStatus= Active | Retired
type IncomeType= Salary | Pension | Freelance
type Income={incomeType:IncomeType;value:float}

type FamMember={name:string;status:WorkStatus;gender:Gender;income:Income list}
type House={people:FamMember list}


let famIncome member:FamMember=List.fold (fun acc elem ->  ) 0 member.income