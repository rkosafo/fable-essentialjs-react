module EJ2.React.Buttons


open System
open Fable.Core
open EJ2.React
open Utils
open Fable.Helpers.React
open Fable.Helpers.React.Props


[<RequireQualifiedAccess>]
module ButtonComponent =
  type [<StringEnum(CaseRules.None)>] IconPosition =
    | Left
    | Right
  type Props =
    | Content of string
    | CssClass of string
    | Disabled of bool
    | EnablePersistence of bool
    | EnableRtl of bool
    | IconCss of string
    | IconPosition of IconPosition
    | IsPrimary of bool
    | IsToggle of bool
    | Props of IHTMLProp list
    interface IHTMLProp
    
  let p (props: Props list) =
      props
      |> List.fold (fun s x -> match x with
                               | Props x -> s @ x
                               | x -> (x :> IHTMLProp) :: s) []
      |> kvl

let buttonComponent props children = ofImport "ButtonComponent" Packages.Buttons (ButtonComponent.p props) children