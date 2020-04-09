﻿' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.DocumentHighlighting
Imports Microsoft.CodeAnalysis.Host.Mef

Namespace Microsoft.CodeAnalysis.VisualBasic.DocumentHighlighting
    <ExportLanguageService(GetType(IDocumentHighlightsService), LanguageNames.VisualBasic), [Shared]>
    Friend Class VisualBasicDocumentHighlightsService
        Inherits AbstractDocumentHighlightsService

        <ImportingConstructor>
        <Obsolete(MefConstruction.ImportingConstructorMessage, True)>
        Public Sub New()
        End Sub
    End Class
End Namespace
