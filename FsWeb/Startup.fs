namespace FsWeb

open Owin

type Startup() =
    member this.Configuration (app : IAppBuilder) =
        app.UseNancy() |> ignore