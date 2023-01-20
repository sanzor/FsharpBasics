module modu
open System.Drawing;
open System
open System.Windows


type Gender= Female | Male
type WorkStatus= Active | Retired
type IncomeType= Salary | Pension | Freelance
type Income={incomeType:IncomeType;value:float}

type FamMember={name:string;status:WorkStatus;gender:Gender;incomes:Income list}
type House={people:FamMember list}



let memberIncome (me:FamMember)= me.incomes |> List.fold (fun acc sz->  acc+sz.value ) 0.0


let familyIncome h x= h.people |> List.map (memberIncome>>((+) 1.0)) |> (List.fold (+) x)