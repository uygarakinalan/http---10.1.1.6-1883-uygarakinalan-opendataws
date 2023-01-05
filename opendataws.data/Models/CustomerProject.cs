using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class CustomerProject
    {
        public uint Id { get; set; }
        public uint CustomerId { get; set; }
        public ulong DeliveryMonth { get; set; }
        public int TotalMonth { get; set; }
        public decimal? ProjectFee { get; set; }
        public decimal? SystemAmount { get; set; }
        public decimal? FrontPayment { get; set; }
        public string FeeType { get; set; } = null!;
        public string PaymentType { get; set; } = null!;
        public ulong CreatedAt { get; set; }
        public ulong UpdatedAt { get; set; }
        public uint PlanId { get; set; }
        public string? TotalInitialPayment { get; set; }
        public decimal? ProjectTotalPayment { get; set; }
        public decimal? MonthlyPayment { get; set; }
        public decimal? MonthlyPaymentAfterDelivery { get; set; }
        public uint SalesUserId { get; set; }
        public string ServiceCostType { get; set; } = null!;
        public sbyte? ServiceCostInstallment { get; set; }
        public uint SalesDepartmentId { get; set; }
        public string? Status { get; set; }
        public decimal? SystemAmountWithCampaign { get; set; }
        public string? DeprecatedReason { get; set; }
        public string CurrencyUnit { get; set; } = null!;
        public ulong? DeliveryDate { get; set; }
        public decimal? AmountOfPayment { get; set; }
        public ulong? DeletedAt { get; set; }
        public string? ProjectType { get; set; }
        public decimal? RemainingFeeAmount { get; set; }
        public decimal? AmountForCustomer { get; set; }
        public string? PlanDetails { get; set; }
        public string? Number { get; set; }
        public decimal? FeeRate { get; set; }
        public uint? GroupId { get; set; }
        public bool? IsLeft { get; set; }
        public ulong? EarlyDeliveryMonth { get; set; }
        public ulong? AbsoluteDeliveryMonth { get; set; }
        public bool? IsActive { get; set; }
        public string? PartOfFeeOnly { get; set; }
        public decimal? DeliveryPercentage { get; set; }
        public uint? ApprovedUserId { get; set; }
        public ulong? ApprovedDate { get; set; }
        public sbyte? DeliveryDay { get; set; }
        public bool? RevisionedBefore { get; set; }
        public ulong? RevisionDate { get; set; }
        public string? ContractType { get; set; }
        public sbyte? OriginalServiceCostInstallment { get; set; }
        public decimal? PercentageOfWithoutCampaignServiceAmount { get; set; }
        public decimal? SystemAmountWithoutCampaign { get; set; }
        public bool? IsTheRefundPaid { get; set; }
        public decimal? ServiceCostAdvancePayment { get; set; }
    }
}
