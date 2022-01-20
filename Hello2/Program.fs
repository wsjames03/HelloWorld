open System

let ask student ``a question`` = 
    printf "me ask %s: %s" student ``a question``

let askJames = ask "James"
 
//let f = 10

askJames "How old are you"