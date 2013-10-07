module FsNancy

let inline ToString o = o.ToString()

let inline obj x = x :> obj

let (?) (parameters : obj) property =
    (parameters :?> Nancy.DynamicDictionary).[property]
    |> ToString

type route =
    | Get of string * (obj -> string)

type FsNancyModule(routeConfig) as self =
    inherit Nancy.NancyModule()

    let mapRoute route =
        match route with
        | Get (path, action) -> self.Get path action

    do
        self.MapRoutes routeConfig

    member this.Get path f =
        base.Get.[path] <- System.Func<obj, obj>(f >> obj)

    member this.MapRoutes routeConfig =
        routeConfig
        |> Seq.iter mapRoute

