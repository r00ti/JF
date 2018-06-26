open System

let rec NWD = function
    | (0, n) -> n
    | (m, n) -> NWD(n % m, m)

let printNWD a b = printfn "%d" (NWD (a, b))

let extractNumbers s =  printNWD (s.ToString().Split(' ').[0] |> int)  (s.ToString().Split(' ').[1] |> int)

Array.iter (fun (a) ->  extractNumbers a) [| for i in 1 .. Console.ReadLine() |>int -> Console.ReadLine()|]