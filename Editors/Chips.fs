namespace EJ2.React.Button



open System
open Fable.Core
open EJ2.React
open Utils
open Fable.Helpers.React
open Fable.Helpers.React.Props


[<RequireQualifiedAccess>]
module Chip =
  type [<StringEnum>] Classes =
    | [<CompiledName("e-primary")>] Primary
    | [<CompiledName("e-info")>] Info
    | [<CompiledName("e-success")>] Success
    | [<CompiledName("e-warning")>] Warning
    | [<CompiledName("e-danger")>] Danger

  type [<StringEnum>] Selection =
    | Multiple
    | Single
  type IChipListComponent =
    | Selection of Selection
    | Props of IHTMLProp list
    interface IHTMLProp
    static member p (props: IChipListComponent list) =
      props
      |> List.fold (fun s x -> match x with
                               | Props x -> s @ x
                               | x -> (x :> IHTMLProp) :: s) []
      |> kvl
  let chipListComponent props children = ofImport "ChipListComponent" Packages.Buttons (IChipListComponent.p props) children

  type IChipDirective =
    | Text of string
    | CssClass of Classes
    | Props of IHTMLProp list
    interface IHTMLProp
    static member p (props: IChipDirective list) =
      props
      |> List.fold (fun s x -> match x with
                               | Props x -> s @ x
                               | x -> (x :> IHTMLProp) :: s) []
      |> kvl
  let chipDirective props children = ofImport "ChipDirective" Packages.Buttons (IChipDirective.p props) children
  let chipsDirective props children = ofImport "ChipsDirective" Packages.Buttons (obj ()) children
   