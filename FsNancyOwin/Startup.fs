namespace FsNancyOwin

open Owin

type Startup() =
    member this.Configuration (app : IAppBuilder) =
        app.UseNancy() |> ignore
        ()

