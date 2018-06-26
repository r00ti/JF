open System

[<EntryPoint>]
let main argv =

    let count = Console.ReadLine() |>int

    let myArray : int array = Array.zeroCreate count
    let a : bool = true
    for i = 1 to myArray.Length do
        myArray.[i-1] <- Console.ReadLine() |>int

    let isprime n =
        let rec check i =
            i > n/2 || (n % i <> 0 && check (i + 1))
        check 2
    for value in myArray do
            if value <2 then Console.WriteLine("NIE") else
                if(isprime value) then Console.WriteLine("TAK") else Console.WriteLine("NIE")
    Console.ReadKey(true) |>ignore
    0 // return an integer exit code