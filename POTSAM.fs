open System

[<EntryPoint>]
let main argv =

    let x = Console.ReadLine()
    let y = x.Split ' ' 
            |> Seq.map System.Int32.Parse   
            |> Seq.toArray
    let s = y.[0]*y.[1]+y.[2]*y.[3]
    Console.WriteLine(s)
    0