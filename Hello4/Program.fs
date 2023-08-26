open System

// For more information see https://aka.ms/fsharp-console-apps
//printfn "Hello from F#"

let ``inc 1`` = (+) 1.
let toKiloMeter = (*) 1.6
let ``20 div`` = (/) 20

let squareNew = sqrt
let mutiplyByTen = (*)10.
let sqrt_multiTen = squareNew >> mutiplyByTen

let result = ``inc 1`` 48.
let result2 = sqrt_multiTen 36.
let result3 = result |> sqrt_multiTen

//unary quadratic equation
//x = (-b ± √(b^2 - 4ac)) / 2a

let solveQuadratic a b c = 
    let discriminant = b * b - 4.0 * a * c
    let sqrtDiscriminant = sqrt(discriminant)
    let x1 = (-b + sqrtDiscriminant) / (2.0 * a)
    let x2 = (-b - sqrtDiscriminant) / (2.0 * a)
    (x1, x2)     

printfn $"result = {result}"
printfn $"result2 = {result2}"
printfn $"result3 = {result3}"

printfn $" Root Of Equation x^2 -3x + 2 = 0 : {solveQuadratic 1 -3 2}"

//0
