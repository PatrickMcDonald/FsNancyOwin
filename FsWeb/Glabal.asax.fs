namespace FsWeb

open System

type Global() =
    inherit System.Web.HttpApplication()
    member this.Application_Start(sender : obj) (e : EventArgs) = 
        ()