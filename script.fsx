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


let memberIncome (me:FamMember)=List.fold (fun (acc:float) (e:Income) -> acc+e.value  ) 0 me.incomes

let houseIncome house:House= List.fold  (fun (acc:float) (fam:FamMember) ->acc+ memberIncome fam)   0 house.people