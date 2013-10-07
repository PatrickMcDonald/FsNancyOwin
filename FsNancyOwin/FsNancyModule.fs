namespace FsNancyOwin

open Nancy

type FsNancyModule() =
    inherit NancyModule()

    let obj f =
        f :> obj

    member this.Get path f =
        base.Get.[path] <- System.Func<obj,obj>(f >> obj)

