open System

let f(x) = 2

let g x =2

let print x = printfn "check here %d" x
print 3

// _ means defalut/whatever
let print2 _= print 4

// val it :unit = ()
print2 ()

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
