// Learn more about F# at http://fsharp.org

open System

open JSONTest 

[<EntryPoint>]
let main argv =

    printfn "animals example '%A'" animals 
    printfn " "

    printfn "data2 example '%A'" data2 
    printfn " " 

    printfn "data2 example '%A'" data3 
    printfn " " 

    printfn "Customers example '%A'" CS 
    printfn " " 

    printfn "newOrder example '%A'" newOrder 
    printfn " " 

    printfn "newCustomer example '%A'" newCustomer 
    printfn " " 

    printfn "jsonText example '%A'" jsonText 
 
    printfn " " 
    printfn "All finished from ExpertF#Ch08JSON" 
    0 // return an integer exit code
