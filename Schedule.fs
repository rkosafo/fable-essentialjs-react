module EJ2.React.Schedule


open System
open Fable.Core
open EJ2.React
open Utils
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop


[<RequireQualifiedAccess>]
module ScheduleComponent = 
  type Props =
    | Width of string
    | Height of string
    | SelectedDate of DateTime
    | EventSettings of {| dataSource: obj [] |}
    interface IHTMLProp
  let p (props: Props list) =
    props
    |> kvl

  let Day: obj = importMember Packages.Schedule
  let Week: obj = importMember Packages.Schedule
  //let Month: obj = importMember Packages.Schedule
  //let Agenda: obj = importMember Packages.Schedule
  //let TimelineViews: obj = importMember Packages.Schedule

  //let Inject services = ofImport "Inject" Packages.Schedule (createObj ["services" ==> services]) []

  let Inject = importMember<obj [] -> ReactElement> Packages.Schedule

  let bay =
    printfn "Mojo jojo"
    Browser.Dom.window?iii <- Inject
    Browser.Dom.window?jjj <- (Day, Week)


let scheduleComponent props children = ofImport "ScheduleComponent" Packages.Schedule (ScheduleComponent.p props) children