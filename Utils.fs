namespace EJ2.React


module Utils =
  open Fable.Core

  let kvl xs = JsInterop.keyValueList CaseRules.LowerFirst xs

  module Packages =
    let [<Literal>] Buttons = "@syncfusion/ej2-react-buttons"