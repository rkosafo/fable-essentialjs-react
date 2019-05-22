module EJ2.React.Dropdowns


open System
open Fable.Core
open EJ2.React
open Utils
open Fable.React
open Fable.React.Props

type Query = interface end


type FieldSettingsModel =
  { groupBy: string
    iconCss: string
    text: string
    value: string }

type FilteringEventArgs =
  { cancel: bool
    preventDefaultAction: bool
    text: string
    update: (obj * Query option * FieldSettingsModel option) -> unit}

[<RequireQualifiedAccess>]
module DropDownList =
  type Props =
    | Blur of obj EmitType
    | BeforeOpen of obj EmitType
    | ActionFailure of obj EmitType
    | ActionComplete of obj EmitType
    | ActionBegin of obj EmitType
    | Change of {| isInteracted: bool; itemData: FieldSettingsModel; previousItemData: FieldSettingsModel; value: string |} EmitType
    | Close of PopupEvent
    | CustomValueSpecifier of {| item: obj; text: string |} EmitType
    | Created of obj EmitType
    | DataBound of obj EmitType
    | Destroyed of obj EmitType
    | Filtering of FilteringEventArgs EmitType
    | DataSource of obj
    | AllowCustom of bool
    | AllowFiltering of bool
    | AutoFill of bool
    | CssClass of string
    | [<CompiledName("dataSource")>]DataSourceStr of string []
    | [<CompiledName("dataSource")>]DataSourceNum of int []
    | [<CompiledName("dataSource")>]DataSourceBool of bool []
    | [<CompiledName("dataSource")>]DataSourceObjs of obj []
    | EnablePersistence of bool
    | EnableRtl of bool
    | Enabled of bool
    | Fields of {| text: string; value: string; iconCss: string; groupBy: string |}
    | Select of {| cancel: bool; isInteracted: bool; itemData: FieldSettingsModel |} EmitType
    | FloatLabelType of FloatLabelType
    | Index of int
    | Locale of string
    | Placeholder of string
    | PopupHeight of int
    | PopupWidth of int
    | Query of obj
    | ReadOnly of bool
    | ShowClearButton of bool
    | SortOrder of SortOrder
    | Text of string
    | Value of int
    | [<CompiledName("value")>]ValueStr of string
    | [<CompiledName("value")>]ValueBool of bool
    | Width of int
    | ZIndex of int
    interface IHTMLProp

  let p (props: Props list) =
    props
    |> kvl
  

[<RequireQualifiedAccess>]
module ComboBox =
  type Props =
    | Blur of obj EmitType
    | BeforeOpen of obj EmitType
    | ActionFailure of obj EmitType
    | ActionComplete of obj EmitType
    | ActionBegin of obj EmitType
    | Change of ChangeEvent
    | Close of PopupEvent
    | CustomValueSpecifier of {| item: obj; text: string |} EmitType
    | Created of obj EmitType
    | DataSource of obj
    | AllowCustom of bool
    | AllowFiltering of bool
    | AutoFill of bool
    | CssClass of string
    | [<CompiledName("dataSource")>]DataSourceStr of string []
    | [<CompiledName("dataSource")>]DataSourceNum of int []
    | [<CompiledName("dataSource")>]DataSourceBool of bool []
    | [<CompiledName("dataSource")>]DataSourceObjs of obj []
    | EnablePersistence of bool
    | EnableRtl of bool
    | Enabled of bool
    | Fields of {| text: string; value: string; iconCss: string; groupBy: string |}
    | FloatLabelType of FloatLabelType
    | Index of int
    | Locale of string
    | Placeholder of string
    | PopupHeight of int
    | PopupWidth of int
    | Query of obj
    | ReadOnly of bool
    | ShowClearButton of bool
    | SortOrder of SortOrder
    | Text of string
    | Value of int
    | [<CompiledName("value")>]ValueStr of string
    | [<CompiledName("value")>]ValueBool of bool
    | Width of int
    | ZIndex of int
    interface IHTMLProp

  let p (props: Props list) =
    props
    |> kvl


[<RequireQualifiedAccess>]
module ListBox =
  type Props =
    | Blur of obj EmitType
    | BeforeOpen of obj EmitType
    | ActionFailure of obj EmitType
    | ActionComplete of obj EmitType
    | ActionBegin of obj EmitType
    | Change of {| isInteracted: bool; itemData: FieldSettingsModel; previousItemData: FieldSettingsModel; value: string |} EmitType
    | AllowDragAndDrop of bool
    | Created of obj EmitType
    | Destroyed of obj EmitType
    | Filtering of FilteringEventArgs EmitType
    | DataSource of obj
    | CssClass of string
    | [<CompiledName("dataSource")>]DataSourceStr of string []
    | [<CompiledName("dataSource")>]DataSourceNum of int []
    | [<CompiledName("dataSource")>]DataSourceBool of bool []
    | [<CompiledName("dataSource")>]DataSourceObjs of obj []
    | EnablePersistence of bool
    | EnableRtl of bool
    | Enabled of bool
    | Fields of {| text: string; value: string; iconCss: string; groupBy: string |}
    | Select of {| cancel: bool; isInteracted: bool; itemData: FieldSettingsModel |} EmitType
    | FloatLabelType of FloatLabelType
    | Locale of string
    | Query of obj
    | SortOrder of SortOrder
    //selectionSettings
    | Value of int
    | [<CompiledName("value")>]ValueStr of string
    | [<CompiledName("value")>]ValueBool of bool
    | Height of int
    | Scope of string
    interface IHTMLProp

  let p (props: Props list) =
    props
    |> kvl

let comboBoxComponent props children = ofImport "ComboBoxComponent" Packages.Dropdowns (ComboBox.p props) children

let dropdownListComponent props children = ofImport "DropDownListComponent" Packages.Dropdowns (DropDownList.p props) children

let listBoxComponent props children = ofImport "ListBoxComponent" Packages.Dropdowns (ListBox.p props) children

