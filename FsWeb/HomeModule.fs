module HomeModule

open FsNancy

let routeConfig = [
    Get ("/",
        fun _ -> "Hello F# Web App");
    Get ("/hi/{name}",
        fun parameters -> "Hello " + parameters?name)
]

type HomeModule() =
    inherit FsNancyModule(routeConfig)

