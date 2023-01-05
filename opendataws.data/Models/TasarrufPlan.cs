using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TasarrufPlan
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public decimal RequestedPercentage { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? IsActive { get; set; }
        public ulong? ValidUntil { get; set; }
        public int? GroupSize { get; set; }
        public string? PlanType { get; set; }
        public sbyte FirstXCustomer { get; set; }
        public string PaymentPlan { get; set; } = null!;
        public decimal? IncreaseRateAfterDelivery { get; set; }
        public decimal? PeriodicIncreaseRate { get; set; }
        public string? IncreasePeriod { get; set; }
        public ulong? HowManyUsed { get; set; }
        public string? ServiceAmountReference { get; set; }
        public string? PeriodicIncrementReference { get; set; }
        public bool? PeriodicIncreaseAfterDelivery { get; set; }
        public int? MinDeliveryMonth { get; set; }
        public int? DeliveryMonth { get; set; }
        public string? RequestedAmountReference { get; set; }
        public string DeliveryIncrementReference { get; set; } = null!;
        public string DeliveryMonthConstantOrVariable { get; set; } = null!;
        public int? ConstantRateAmount { get; set; }
        public int? ConstantRateCoefficient { get; set; }
        public sbyte? DeliveryDelay { get; set; }
        public bool? MonthlyGtFee { get; set; }
        public bool? InstallmentFeeFrontPayment { get; set; }
        public int? DeliveryOverride { get; set; }
        public decimal? InstallmentFeeFrontPaymentPercentage { get; set; }
        public bool? FeeCanBeInstallment { get; set; }
        public decimal? XPercentageFeeOnly { get; set; }
        public decimal? PercentageOfWithoutCampaignServiceAmount { get; set; }
    }
}
