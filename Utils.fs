namespace EJ2.React


open Fable.Core


module Utils =
  let kvl xs = JsInterop.keyValueList CaseRules.LowerFirst xs

  module Packages =
    let [<Literal>] Buttons = "@syncfusion/ej2-react-buttons"
    let [<Literal>] Navigations = "@syncfusion/ej2-react-navigations"
    let [<Literal>] Dropdowns = "@syncfusion/ej2-react-dropdowns"


type [<StringEnum(CaseRules.None)>]FloatLabelType =
  | Never
  | Always
  | Auto

type [<StringEnum(CaseRules.None)>]SortOrder =
  | None
  | Ascending
  | Descending

type [<StringEnum>] Classes =
  | [<CompiledName("e-primary")>] Primary
  | [<CompiledName("e-info")>] Info
  | [<CompiledName("e-success")>] Success
  | [<CompiledName("e-warning")>] Warning
  | [<CompiledName("e-danger")>] Danger
  | [<CompiledName("e-outline")>] Outline
  | [<CompiledName("e-dlt-btn")>] DeleteButton
  | [<CompiledName("e-icon")>] Icon


type ChangeEventArgs =
  abstract value: string with get
type Event = interface end
type PopupEventArgs = 
  abstract cancel: bool with get


type 'a EmitType = 'a -> unit
type ChangeEvent = ChangeEventArgs EmitType
type Event' = Event EmitType
type PopupEvent = PopupEventArgs EmitType
