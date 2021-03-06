﻿Public NotInheritable Class HTMLParser
    Public Shared _NormalizeCSS As String = "/*! normalize.css v8.0.1 | MIT License | github.com/necolas/normalize.css */button,hr,input{overflow:visible}progress,sub,sup{vertical-align:baseline}[type=checkbox],[type=radio],legend{box-sizing:border-box;padding:0}html{line-height:1.15;-webkit-text-size-adjust:100%}body{margin:0}details,main{display:block}h1{font-size:2em;margin:.67em 0}hr{box-sizing:content-box;height:0}code,kbd,pre,samp{font-family:monospace,monospace;font-size:1em}a{background-color:transparent}abbr[title]{border-bottom:none;text-decoration:underline;text-decoration:underline dotted}b,strong{font-weight:bolder}small{font-size:80%}sub,sup{font-size:75%;line-height:0;position:relative}sub{bottom:-.25em}sup{top:-.5em}img{border-style:none}button,input,optgroup,select,textarea{font-family:inherit;font-size:100%;line-height:1.15;margin:0}button,select{text-transform:none}[type=button],[type=reset],[type=submit],button{-webkit-appearance:button}[type=button]::-moz-focus-inner,[type=reset]::-moz-focus-inner,[type=submit]::-moz-focus-inner,button::-moz-focus-inner{border-style:none;padding:0}[type=button]:-moz-focusring,[type=reset]:-moz-focusring,[type=submit]:-moz-focusring,button:-moz-focusring{outline:ButtonText dotted 1px}fieldset{padding:.35em .75em .625em}legend{color:inherit;display:table;max-width:100%;white-space:normal}textarea{overflow:auto}[type=number]::-webkit-inner-spin-button,[type=number]::-webkit-outer-spin-button{height:auto}[type=search]{-webkit-appearance:textfield;outline-offset:-2px}[type=search]::-webkit-search-decoration{-webkit-appearance:none}::-webkit-file-upload-button{-webkit-appearance:button;font:inherit}summary{display:list-item}[hidden],template{display:none}"

    Public Shared _PaperCSS As String = "@page{margin:0}body{margin:0}.sheet{margin:0;overflow:hidden;position:relative;box-sizing:border-box;page-break-after:always}body.A3 .sheet{width:297mm;height:419mm}body.A3.landscape .sheet{width:420mm;height:296mm}body.A4 .sheet{width:210mm;height:296mm}body.A4.landscape .sheet{width:297mm;height:209mm}body.A5 .sheet{width:148mm;height:209mm}body.A5.landscape .sheet{width:210mm;height:147mm}body.letter .sheet{width:216mm;height:279mm}body.letter.landscape .sheet{width:280mm;height:215mm}body.legal .sheet{width:216mm;height:356mm}body.legal.landscape .sheet{width:357mm;height:215mm}.sheet.padding-10mm{padding:10mm}.sheet.padding-15mm{padding:15mm}.sheet.padding-20mm{padding:20mm}.sheet.padding-25mm{padding:25mm}@media screen{body{background:#e0e0e0}.sheet{background:#fff;box-shadow:0 .5mm 2mm rgba(0,0,0,.3);margin:5mm auto}}@media print{body.A3.landscape{width:420mm}body.A3,body.A4.landscape{width:297mm}body.A4,body.A5.landscape{width:210mm}body.A5{width:148mm}body.legal,body.letter{width:216mm}body.letter.landscape{width:280mm}body.legal.landscape{width:357mm}}"

    Public Shared _HTMLTemplate As String = "<!DOCTYPE html><html lang=""en""><head><meta charset=""utf-8""><title>[Title]</title><style>[NormalizeCSS]</style><style>[PaperCSS]</style><style>@page { size: A4 }</style><style>[CustomCSS]</style><body class=""A4"" dir=""rtl"">[Body]</body></html>"

    Public Shared _PageTemplate As String = "<section class=""sheet [Pad]"">[Body]</section>"

    Public Enum PaperPadding
        NoPad = 0
        Pad10 = 1
        Pad15 = 2
        Pad20 = 3
        Pad25 = 4
    End Enum
    Private Shared _Pad() As String = {"", "padding-10mm", "padding-15mm", "padding-20mm", "padding-25mm"}

    Public Shared Function GeneratePage(Body As String) As String
        Return GeneratePage(Body, PaperPadding.Pad10)
    End Function

    Public Shared Function GeneratePage(Body As String, Pad As PaperPadding) As String
        Dim html As String = _PageTemplate.Replace("[Pad]", _Pad(Pad)).Replace("[Body]", Body)
        Return html
    End Function

    Public Shared Function GenerateHTML(Body As String, Optional Title As String = "Paper", Optional CustomCSS As String = "") As String
        Dim html As String = _HTMLTemplate.Replace("[Title]", Title).Replace("[NormalizeCSS]", _NormalizeCSS).Replace("[PaperCSS]", _PaperCSS).Replace("[CustomCSS]", CustomCSS).Replace("[Body]", Body)
        Return html
    End Function

End Class
