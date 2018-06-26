open System

[<EntryPoint>]
let main argv =

    let x = Console.ReadLine()
    let y = x.Split ' ' 
            |> Array.rev 
            |> String.concat " "

    Console.WriteLine(y)
    Console.ReadKey() |> ignore
    0