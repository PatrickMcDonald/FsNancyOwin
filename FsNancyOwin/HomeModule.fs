module FsNancyOwin.HomeModule

open FsNancy

let routeConfig = [
    Get ("/",
        fun _ -> "Hello F# World!");
    Get ("/hi/{name}",
        fun args -> "Hello " + args?name)
]

type HomeModule() =
    inherit FsNancyModule(routeConfig)
