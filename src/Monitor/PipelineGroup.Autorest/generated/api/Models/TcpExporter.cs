// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Extensions;

    /// <summary>Base exporter using TCP as transport protocol.</summary>
    public partial class TcpExporter :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.ITcpExporter,
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Models.ITcpExporterInternal
    {

        /// <summary>Backing field for <see cref="Url" /> property.</summary>
        private string _url;

        /// <summary>TCP url to export.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Origin(Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.PropertyOrigin.Owned)]
        public string Url { get => this._url; set => this._url = value; }

        /// <summary>Creates an new <see cref="TcpExporter" /> instance.</summary>
        public TcpExporter()
        {

        }
    }
    /// Base exporter using TCP as transport protocol.
    public partial interface ITcpExporter :
        Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.IJsonSerializable
    {
        /// <summary>TCP url to export.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Monitor.PipelineGroup.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"TCP url to export.",
        SerializedName = @"url",
        PossibleTypes = new [] { typeof(string) })]
        string Url { get; set; }

    }
    /// Base exporter using TCP as transport protocol.
    internal partial interface ITcpExporterInternal

    {
        /// <summary>TCP url to export.</summary>
        string Url { get; set; }

    }
}