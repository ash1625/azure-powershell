// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Extensions;

    /// <summary>Savings plan utilization</summary>
    public partial class Utilization :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilization,
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationInternal
    {

        /// <summary>Backing field for <see cref="Aggregate" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationAggregates[] _aggregate;

        /// <summary>The array of aggregates of a savings plan's utilization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationAggregates[] Aggregate { get => this._aggregate; set => this._aggregate = value; }

        /// <summary>Internal Acessors for Trend</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationInternal.Trend { get => this._trend; set { {_trend = value;} } }

        /// <summary>Backing field for <see cref="Trend" /> property.</summary>
        private string _trend;

        /// <summary>The number of days trend for a savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Origin(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.PropertyOrigin.Owned)]
        public string Trend { get => this._trend; }

        /// <summary>Creates an new <see cref="Utilization" /> instance.</summary>
        public Utilization()
        {

        }
    }
    /// Savings plan utilization
    public partial interface IUtilization :
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.IJsonSerializable
    {
        /// <summary>The array of aggregates of a savings plan's utilization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The array of aggregates of a savings plan's utilization",
        SerializedName = @"aggregates",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationAggregates) })]
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationAggregates[] Aggregate { get; set; }
        /// <summary>The number of days trend for a savings plan</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The number of days trend for a savings plan",
        SerializedName = @"trend",
        PossibleTypes = new [] { typeof(string) })]
        string Trend { get;  }

    }
    /// Savings plan utilization
    internal partial interface IUtilizationInternal

    {
        /// <summary>The array of aggregates of a savings plan's utilization</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BillingBenefits.Models.Api20221101.IUtilizationAggregates[] Aggregate { get; set; }
        /// <summary>The number of days trend for a savings plan</summary>
        string Trend { get; set; }

    }
}