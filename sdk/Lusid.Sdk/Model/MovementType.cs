/* 
 * LUSID API
 *
 * # Introduction  This page documents the [LUSID APIs](https://www.lusid.com/api/swagger), which allows authorised clients to query and update their data within the LUSID platform.  SDKs to interact with the LUSID APIs are available in the following languages and frameworks:  * [C#](https://github.com/finbourne/lusid-sdk-csharp) * [Java](https://github.com/finbourne/lusid-sdk-java) * [JavaScript](https://github.com/finbourne/lusid-sdk-js) * [Python](https://github.com/finbourne/lusid-sdk-python) * [Angular](https://github.com/finbourne/lusid-sdk-angular)  The LUSID platform is made up of a number of sub-applications. You can find the API / swagger documentation by following the links in the table below.   | Application | Description | API / Swagger Documentation | | - -- -- | - -- -- | - -- - | | LUSID | Open, API-first, developer-friendly investment data platform. | [Swagger](https://www.lusid.com/api/swagger/index.html) | | Web app | User-facing front end for LUSID. | [Swagger](https://www.lusid.com/app/swagger/index.html) | | Scheduler | Automated job scheduler. | [Swagger](https://www.lusid.com/scheduler2/swagger/index.html) | | Insights |Monitoring and troubleshooting service. | [Swagger](https://www.lusid.com/insights/swagger/index.html) | | Identity | Identity management for LUSID (in conjuction with Access) | [Swagger](https://www.lusid.com/identity/swagger/index.html) | | Access | Access control for LUSID (in conjunction with Identity) | [Swagger](https://www.lusid.com/access/swagger/index.html) | | Drive | Secure file repository and manager for collaboration. | [Swagger](https://www.lusid.com/drive/swagger/index.html) | | Luminesce | Data virtualisation service (query data from multiple providers, including LUSID) | [Swagger](https://www.lusid.com/honeycomb/swagger/index.html) | | Notification | Notification service. | [Swagger](https://www.lusid.com/notifications/swagger/index.html) | | Configuration | File store for secrets and other sensitive information. | [Swagger](https://www.lusid.com/configuration/swagger/index.html) | 
 *
 * The version of the OpenAPI document: 0.11.3421
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Lusid.Sdk.Client.OpenAPIDateConverter;

namespace Lusid.Sdk.Model
{
    /// <summary>
    /// Defines MovementType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum MovementType
    {
        /// <summary>
        /// Enum Settlement for value: Settlement
        /// </summary>
        [EnumMember(Value = "Settlement")]
        Settlement = 1,

        /// <summary>
        /// Enum Traded for value: Traded
        /// </summary>
        [EnumMember(Value = "Traded")]
        Traded = 2,

        /// <summary>
        /// Enum StockMovement for value: StockMovement
        /// </summary>
        [EnumMember(Value = "StockMovement")]
        StockMovement = 3,

        /// <summary>
        /// Enum FutureCash for value: FutureCash
        /// </summary>
        [EnumMember(Value = "FutureCash")]
        FutureCash = 4,

        /// <summary>
        /// Enum Commitment for value: Commitment
        /// </summary>
        [EnumMember(Value = "Commitment")]
        Commitment = 5,

        /// <summary>
        /// Enum Receivable for value: Receivable
        /// </summary>
        [EnumMember(Value = "Receivable")]
        Receivable = 6,

        /// <summary>
        /// Enum CashSettlement for value: CashSettlement
        /// </summary>
        [EnumMember(Value = "CashSettlement")]
        CashSettlement = 7,

        /// <summary>
        /// Enum CashForward for value: CashForward
        /// </summary>
        [EnumMember(Value = "CashForward")]
        CashForward = 8,

        /// <summary>
        /// Enum CashCommitment for value: CashCommitment
        /// </summary>
        [EnumMember(Value = "CashCommitment")]
        CashCommitment = 9,

        /// <summary>
        /// Enum CashReceivable for value: CashReceivable
        /// </summary>
        [EnumMember(Value = "CashReceivable")]
        CashReceivable = 10,

        /// <summary>
        /// Enum Accrual for value: Accrual
        /// </summary>
        [EnumMember(Value = "Accrual")]
        Accrual = 11,

        /// <summary>
        /// Enum CashAccrual for value: CashAccrual
        /// </summary>
        [EnumMember(Value = "CashAccrual")]
        CashAccrual = 12,

        /// <summary>
        /// Enum ForwardFx for value: ForwardFx
        /// </summary>
        [EnumMember(Value = "ForwardFx")]
        ForwardFx = 13,

        /// <summary>
        /// Enum CashFxForward for value: CashFxForward
        /// </summary>
        [EnumMember(Value = "CashFxForward")]
        CashFxForward = 14,

        /// <summary>
        /// Enum UnsettledCashTypes for value: UnsettledCashTypes
        /// </summary>
        [EnumMember(Value = "UnsettledCashTypes")]
        UnsettledCashTypes = 15,

        /// <summary>
        /// Enum Carry for value: Carry
        /// </summary>
        [EnumMember(Value = "Carry")]
        Carry = 16,

        /// <summary>
        /// Enum CarryAsPnl for value: CarryAsPnl
        /// </summary>
        [EnumMember(Value = "CarryAsPnl")]
        CarryAsPnl = 17

    }

}
