namespace EJ2.React


open Fable.Core


module Utils =
  let kvl xs = JsInterop.keyValueList CaseRules.LowerFirst xs

  module Packages =
    let [<Literal>] Buttons = "@syncfusion/ej2-react-buttons"


type [<StringEnum>] Classes =
  | [<CompiledName("e-primary")>] Primary
  | [<CompiledName("e-info")>] Info
  | [<CompiledName("e-success")>] Success
  | [<CompiledName("e-warning")>] Warning
  | [<CompiledName("e-danger")>] Danger
  | [<CompiledName("e-outline")>] Outline
  | [<CompiledName("e-dlt-btn")>] DeleteButton
  | [<CompiledName("e-icon")>] Icon


type 'a EmitType = 'a -> unit