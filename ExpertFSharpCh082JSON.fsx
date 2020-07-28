//  ExpertFSharpCh08JSON.fsx
// JSON Type Provider : http://fsharp.github.io/FSharp.Data/library/JsonProvider.html
// JSON Parser : http://fsharp.github.io/FSharp.Data/library/JsonValue.html 

#r @"C:\Users\ellam\.nuget\packages\fsharp.data\3.3.3\lib\netstandard2.0\FSharp.Data.dll" ;;

open FSharp.Data ;;
open FSharp.Data.JsonExtensions ;;

let animals =
    JsonValue.Parse """
        { "dogs": 
            [ { "category": "Companion dogs", 
                "name": "Chihuahua" }, 
              { "category": "Hounds", 
                "name": "Foxhound" } ] }
        """  ;; 

let data2 = JsonValue.Load (__SOURCE_DIRECTORY__ + "\JSONSample.json") 
let data3 = JsonValue.Load "https://jsonplaceholder.typicode.com/todos/1"

let dogs = [ for dog in animals?dogs -> dog?name ] ;;

type Customers = JsonProvider<"""
      { "customers" : 
        [ { "name" : "ACME", 
            "orders" : 
            [ { "number" : "A012345", 
                "item" : "widget", 
                "quantity" : 1 } ] } ] } 
         """> ;;

// let CS = 
Customers.Parse """
  { "customers" : 
    [ { "name" : "Apple Store", 
        "orders" : 
          [ { "number" : "B73284", 
               "item" : "iphone5", 
               "quantity" : 18373 }, 
            { "number" : "B73238", 
               "item" : "iphone6", 
               "quantity" : 3736 } ] },              
       { "name" : "Samsung Shop", 
        "orders" : 
          [ { "number" : "N36214", 
               "item" : "nexus7", 
               "quantity" : 18373 } ] } ] } 
    """ ;; 

// let customerNames = [ for c in Customers.customers -> c.name ]  ;; 

let newOrder = Customers.Order ( number = "N36214", item = "nexus7", quantity = 1636) ;; 
let newCustomer = Customers.Customer( name = "FabPhone", orders = [| newOrder |]) ;;
let jsonText = newCustomer.JsonValue.ToString() ;; 

