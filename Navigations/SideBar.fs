module EJ2.React.SideBar


open System
open Fable.Core
open EJ2.React
open Utils
open Fable.React
open Fable.React.Props


[<RequireQualifiedAccess>]
module Sidebar =
  type [<StringEnum(CaseRules.None)>] Position = Left | Right
  type [<StringEnum(CaseRules.None)>] Type = Over | Push | Slide | Auto
  type Props =
    | Animate of bool
    | CloseOnDocumentClick of bool
    | DockSize of string
    | [<CompiledName("dockSize")>] DockSizeNum of int
    | EnableDock of bool
    | EnableGestures of bool
    | EnablePersistence of bool
    | EnableRtl of bool
    | IsOpen of bool
    | MediaQuery of string
    | Position of Position
    | ShowBackdrop of bool
    | Target of string
    | [<CompiledName("target")>] TargetElement of ReactElement
    | Type of Type
    | Width of int
    | ZIndex of int
    interface IHTMLProp

  let p (props: Props list) =
    props
    |> kvl


let sidebarComponent props children = ofImport "SidebarComponent" Packages.Navigations (Sidebar.p props) children


