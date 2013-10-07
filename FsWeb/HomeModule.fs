namespace FsWeb

open Nancy

type HomeModule() as self =
    inherit NancyModule()

    do
        self.Get.["/"] <- (fun x -> "Hello F# Web App" :> obj)
