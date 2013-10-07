namespace FsNancyOwin

open Nancy

type HomeModule() as self =
    inherit FsNancyModule()

    do
        let Get = self.Get
        Get "/" (fun _ -> 
            "Hello, F# World!")
