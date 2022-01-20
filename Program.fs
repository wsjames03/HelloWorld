
// For more information see https://aka.ms/fsharp-console-apps
open System

let debug = printfn "reach here %d"
debug 1

//Define a function to construct a message to print
let toUse whom = 
    sprintf "Try to use %s" whom
debug 2

//children price 3$per,adults 5$per,print Total Price
let familyCost child adult =
    let result = child * 3 + adult * 5
    result

[<Measure>]type Yuan
[<Measure>]type Child
[<Measure>]type Adult

let kidPrice = 3<Yuan/Child>
let adultPrice = 5<Yuan/Adult>

let familyCost2(kids:int<Child>)(adults:int<Adult>) =
    let result = kidPrice * kids + adultPrice * adults
    result

[<EntryPoint>]
//printfn "Hello from F#"
let main argv =
    let (message:string) = toUse "F#" // Call function
    printfn "Hello JamesZhou, %s" message
    let cost = familyCost 3 4
    printfn $"Total cost={cost}"
    let cost2 = familyCost2 2<Child> 3<Adult>
    printfn $"Total cost={cost2}"
    0 //return an integer exit code

