module EJ2.React.CheckBox


open System
open Fable.Core
open EJ2.React
open Utils
open Fable.React
open Fable.React.Props


[<RequireQualifiedAccess>]
module CheckBox =
  type [<StringEnum(CaseRules.None)>] LabelPosition = Before | After
  type Props =
    | Checked of bool
    | CssClass of string
    | Disabled of bool
    | EnablePersistence of bool
    | EnableRtl of bool
    | Indeterminate of bool
    | Label of string
    | LabelPosition of LabelPosition
    | Locale of string
    | Name of string
    | Value of string
    | Change of ChangeEvent
    | Created of Event'
    | Props of IHTMLProp list
    interface IHTMLProp
    
  let p (props: Props list) =
      props
      |> List.fold (fun s x -> match x with
                               | Props x -> s @ x
                               | x -> (x :> IHTMLProp) :: s) []
      |> kvl

let buttonComponent props children = ofImport "CheckBoxComponent" Packages.Buttons (CheckBox.p props) children