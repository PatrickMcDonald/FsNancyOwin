module OwinModule

open System
open Microsoft.Owin.Hosting

let StartSelfHosted<'Startup> (url:string) =
    use app = WebApp.Start<'Startup>(url)

    printfn "Listening on %s" url

    printf "Press any key to exit . . . "
    Console.ReadKey true |> ignore
    