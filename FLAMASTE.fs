open System
open System.Text.RegularExpressions

let regexp = new Regex("(.)\1{2,}")

let  extractGroup x =  
                      let mutable allText = x
                      (regexp.Matches(x)) 
                                |> Seq.cast
                                |> Seq.sortBy(fun (y:Match) -> -y.Length)
                                |> Seq.iter 
                                (fun (regMatch:Match) ->  allText<-(allText.Replace(regMatch.Value, (regMatch.Value.Substring(0,1))+regMatch.Value.Length.ToString())))
                      printfn "%s" allText

Array.iter (fun (a) ->  (extractGroup a)) [| for i in 1 .. Console.ReadLine() |>int -> Console.ReadLine()|]