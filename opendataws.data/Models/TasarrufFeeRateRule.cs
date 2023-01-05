using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class TasarrufFeeRateRule
    {
        public uint Id { get; set; }
        public uint PlanId { get; set; }
        public decimal? FrontPaymentMinPercentage { get; set; }
        public decimal? FrontPaymentMaxPercentage { get; set; }
        public decimal? FirstCustomersInAdvancedPercentage { get; set; }
        public decimal? FirstCustomersInstallmentPercentage { get; set; }
        public decimal? NormalCustomersInAdvancedPercentage { get; set; }
        public decimal? NormalCustomersInstallmentPercentage { get; set; }
        public decimal? FirstCustomersDeliveryPercentage { get; set; }
        public decimal? NormalCustomersDeliveryPercentage { get; set; }
        public uint? FrontPaymentMinInstallment { get; set; }
        public uint? FrontPaymentMaxInstallment { get; set; }
        public uint? DeliveryMonth { get; set; }
        public decimal? FirstCustomersInstallmentCreditCardPercentage { get; set; }
        public decimal? NormalCustomersInstallmentCreditCardPercentage { get; set; }
        public decimal? FirstCustomersDeliveryPercentageInstallment { get; set; }
        public decimal? NormalCustomersDeliveryPercentageInstallment { get; set; }
    }
}
