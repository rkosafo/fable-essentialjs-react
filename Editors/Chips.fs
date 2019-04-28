module EJ2.React.Chips


open System
open Fable.Core
open EJ2.React
open Utils
open Fable.Helpers.React
open Fable.Helpers.React.Props


type ClickEventArgs =
  { data: string
    index: int
    selected: bool
    text: string }

type DeleteEventArgs =
  { cancel: bool
    data: string
    index: int
    text: string }

[<Obsolete>]
type [<StringEnum>] ChipClasses =
  | [<CompiledName("e-primary")>] Primary
  | [<CompiledName("e-info")>] Info
  | [<CompiledName("e-success")>] Success
  | [<CompiledName("e-warning")>] Warning
  | [<CompiledName("e-danger")>] Danger
  | [<CompiledName("e-outline")>] Outline
  | [<CompiledName("e-dlt-btn")>] DeleteButton
  | [<CompiledName("e-icon")>] Icon


[<RequireQualifiedAccess>]
module ChipListComponent =
  type [<StringEnum(CaseRules.None)>] Selection =
    | Multiple
    | Single
    | None
  type Props =
    | Selection of Selection
    | Text of string
    | CssClass of string
    | AvatarIconCss of string
    | TrailingIconCss of string
    | AvatarText of string
    | LeadingIconCss of string
    | EnableDelete of bool
    | OnClick of EmitType<ClickEventArgs> //todo: this is wrong. Args has target, currentTarget, etc
    | SelectedChips of int []
    | Chips of string []
    | [<CompiledName("chips")>] ChipsAsNumbers of int []
    | [<CompiledName("chips")>] ChipModels of obj[] //todo: 
    | EnablePersistence of bool
    | EnableRtl of bool
    | Enabled of bool
    | Locale of string
    | [<CompiledName("selectedChips")>] SelectedChip of int
    | Props of IHTMLProp list
    interface IHTMLProp
  let p (props: Props list) =
      props
      |> List.fold (fun s x -> match x with
                               | Props x -> s @ x
                               | x -> (x :> IHTMLProp) :: s) []
      |> kvl

[<RequireQualifiedAccess>]
module ChipDirective =
  type Props =
    | Text of string
    | CssClass of string
    | AvatarIconCss of string
    | TrailingIconCss of string
    | AvatarText of string
    | LeadingIconCss of string
    | EnableDelete of bool
    | Props of IHTMLProp list
    interface IHTMLProp

  let p (props: Props list) =
    props
    |> List.fold (fun s x -> match x with
                              | Props x -> s @ x
                              | x -> (x :> IHTMLProp) :: s) []
    |> kvl


let chipListComponent props children = ofImport "ChipListComponent" Packages.Buttons (ChipListComponent.p props) children
  
let chipDirective props children = ofImport "ChipDirective" Packages.Buttons (ChipDirective.p props) children

let chipsDirective props children = ofImport "ChipsDirective" Packages.Buttons (obj ()) children
   