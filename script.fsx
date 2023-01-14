module modu
open System.Drawing;
open System
open System.Windows


type Gender= Female | Male
type WorkStatus= Active | Retired
type IncomeType= Salary | Pension | Freelance
type Income={incomeType:IncomeType;value:float}

type HouseContributor={name:string;status:WorkStatus;gender:Gender;list:Income}