using System;
using System.Collections.Generic;

namespace opendataws.data.CbsModel
{
    public partial class ViewCbsItfaiyeYanginRaporuEng
    {
        public int Id { get; set; }
        public DateTime? EventDate { get; set; }
        public int? RegistrationNumber { get; set; }
        public DateTime? ReportRegistrationDate { get; set; }
        public string? NoticeSerialNo { get; set; }
        public DateTime? NoticeDate { get; set; }
        public string? NotifierName { get; set; }
        public string? NotifierPhone { get; set; }
        public int? CommissionedOfficerId { get; set; }
        public string? CommissionedOfficer { get; set; }
        public string? Address { get; set; }
        public int? FireTypeId { get; set; }
        public string? FireType { get; set; }
        public int? BuildingSystemId { get; set; }
        public string? BuildingSystem { get; set; }
        public string? Host { get; set; }
        public string? Hirer { get; set; }
        public int? FireCrewChiefId { get; set; }
        public string? FireCrewChief { get; set; }
        public string? CertifyingOfficer { get; set; }
        public int? TeamVehiclePopulation { get; set; }
        public DateTime? TeamRunDate { get; set; }
        public DateTime? TeamArrivalDate { get; set; }
        public DateTime? WorkCompletionDate { get; set; }
        public DateTime? TeamDateOfReturn { get; set; }
        public DateTime? DateOfElectricalBreakdown { get; set; }
        public DateTime? AmbulanceDateOfArrival { get; set; }
        public DateTime? TeamOfNaturalGasArrivalDate { get; set; }
        public string? YEkipPersonel { get; set; }
        public int? YEkipAmiri { get; set; }
        public int? QuenchingType { get; set; }
        public int? QuenchingWaterAmount { get; set; }
        public int? FireSuppressantAmount { get; set; }
        public int? FireExtinguisherAmount { get; set; }
        public string? DamageControl { get; set; }
        public string? CauseOfFire { get; set; }
        public string? CauseOfFireDescription { get; set; }
        public string? InsuranceCompany { get; set; }
        public string? LossOfEquipment { get; set; }
        public string? FirePlaceDelivered { get; set; }
        public int? NumberOfDeadFireFighters { get; set; }
        public int? NumberOfInjuredFireFighters { get; set; }
        public int? NumberOfDeadPeoples { get; set; }
        public int? NumberOfInjuredPeoples { get; set; }
        public int? NumberOfDeadAnimals { get; set; }
        public int? NumberOfInjuredAnimals { get; set; }
        public int? OutgoingDepartmentId { get; set; }
        public string? OutgoingDepartmentDescription { get; set; }
        public string? ResponsibleQuard { get; set; }
        public string? RegistrarId { get; set; }
        public string? Registrar { get; set; }
        public DateTime? DateOfRecord { get; set; }
        public int? UpdatedPersonId { get; set; }
        public DateTime? DateOfUpdate { get; set; }
        public int? TypeId { get; set; }
        public string Type { get; set; } = null!;
        public string? DenunciationDescriotion { get; set; }
        public int? Statu { get; set; }
        public int? BuildingNumber { get; set; }
        public string? SavingType { get; set; }
        public string DenunciationType { get; set; } = null!;
        public string? Neighbourhood { get; set; }
        public string? StreetName { get; set; }
        public string? CountyName { get; set; }
        public int? NoticeTypeId { get; set; }
        public string? NoticeTypeName { get; set; }
        public int? NumberOfDeadMan { get; set; }
        public int? NumberOfDeadChildren { get; set; }
        public int? NumberOfInjuredWoman { get; set; }
        public int? NumberOfInjuredMan { get; set; }
        public int? NumberOfInjuredChildren { get; set; }
        public string? NeighbourhoodId { get; set; }
        public string? CountyId { get; set; }
        public string? CsbmId { get; set; }
        public int? NaturalDisasterTypeId { get; set; }
        public string? NaturalDisasterType { get; set; }
        public string? SavingTypes { get; set; }
        public string? Latitude { get; set; }
        public string? Longtitude { get; set; }
    }
}
