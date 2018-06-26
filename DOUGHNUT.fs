open System

[<EntryPoint>]
let main argv = 
    let calculate b =
        let input = Console.ReadLine().Split(' ') |> Array.map(fun x -> Convert.ToInt32(x))
        if input.[0] * input.[2] <= input.[1] then "yes" else "no"
    let tests = [1 .. Convert.ToInt32(Console.ReadLine())] |> List.map calculate |> List.iter(fun res -> Console.WriteLine(res))
    0
