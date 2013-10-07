// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open FsNancyOwin

[<EntryPoint>]
let main argv = 
    //printfn "%A" argv

    let url = "http://localhost:12345/"

    System.Diagnostics.Process.Start(url) |> ignore

    OwinModule.StartSelfHosted<Startup> url

    0 // return an integer exit code
