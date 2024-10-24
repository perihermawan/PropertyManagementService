﻿using System;

namespace propertymanagement.service.Models.ViewModel
{
    public class RevenueSharingChargeViewModel
    {
        public Guid? RentId { get; set; }
        public string KsmNumber { get; set; }
        public string PsmNumber { get; set; }
        public string LocationMap { get; set; }
        public decimal Square { get; set; }
        public string OutletName { get; set; }
        public string UnitOwner { get; set; }
        public string TenantOwner { get; set; }
        public DateTime? ChargeDateFrom { get; set; }
        public DateTime? ChargeDateTo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ChargeType { get; set; }
        public string Status { get; set; }
        public bool IsPullOut { get; set; }
        public bool IsClosing { get; set; }
        public DateTime? ClosingDate { get; set; }
        public DateTime? PullOutDate { get; set; }
        public DateTime? StatusDate { get; set; }
        public int Editable { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }

    #region Flat RS
    public class RsChargeFlatItemViewModel
    {
        public Guid? RentId { get; set; }
        public string KsmNumber { get; set; }
        public string PsmNumber { get; set; }
        public string LocationMap { get; set; }
        public decimal Square { get; set; }
        public decimal RentAmount { get; set; }
        public decimal OutstandingAmount { get; set; }
        public int Installments { get; set; }
        public string OutletName { get; set; }
        public string UnitOwner { get; set; }
        public string TenantOwner { get; set; }
        public DateTime? ChargeDateFrom { get; set; }
        public DateTime? ChargeDateTo { get; set; }
        public bool IsPullOut { get; set; }
        public bool IsClosing { get; set; }
        public bool IsFoodCourt { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Editable { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string RemarksRentCharge { get; set; }
    }


    public class RsChargeFlatFormViewModel
    {
        public Guid? FormId { get; set; }
        public Guid? RentId { get; set; }
        public int Installments { get; set; }
        public decimal Square { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal RentAmount { get; set; }
        public string RemarksRentCharge { get; set; }
        public bool Approve { get; set; }
        public bool IsDeleted { get; set; }
        public string LocationMap { get; set; }
        public string ChargeType { get; set; }
        public string KsmNumber { get; set; }
        public string PsmNumber { get; set; }
        public string TenantOwner { get; set; }
        public string OutletName { get; set; }
        public string UnitOwner { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsFoodCourt { get; set; }
        public int Editable { get; set; }
        public DateTime? ChargeDateFrom { get; set; }
        public DateTime? ChargeDateTo { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public string Description { get; set; }
        public decimal MAGPortion { get; set; }
        public decimal MinimumAmount { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string DeleteUser { get; set; }
    }
    #endregion

    #region Progressive RS
    public class RsChargeProgressiveItemViewModel
    {
        public Guid? RentId { get; set; }
        public string KsmNumber { get; set; }
        public string PsmNumber { get; set; }
        public string LocationMap { get; set; }
        public decimal Square { get; set; }
        public decimal RentAmount { get; set; }
        public decimal OutstandingAmount { get; set; }
        public int Installments { get; set; }
        public string OutletName { get; set; }
        public string UnitOwner { get; set; }
        public string TenantOwner { get; set; }
        public DateTime? ChargeDateFrom { get; set; }
        public DateTime? ChargeDateTo { get; set; }
        public decimal MinimumAmount { get; set; }
        public bool IsPullOut { get; set; }
        public bool IsClosing { get; set; }
        public bool IsFoodCourt { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int Editable { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string RemarksRentCharge { get; set; }
    }

    public class RsChargeProgressiveFormViewModel
    {
        public Guid? FormId { get; set; }
        public Guid? RentId { get; set; }
        public int Installments { get; set; }
        public decimal Square { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal RentAmount { get; set; }
        public string RemarksRentCharge { get; set; }
        public bool Approve { get; set; }
        public bool IsDeleted { get; set; }
        public string LocationMap { get; set; }
        public string ChargeType { get; set; }
        public string KsmNumber { get; set; }
        public string PsmNumber { get; set; }
        public string TenantOwner { get; set; }
        public string OutletName { get; set; }
        public string UnitOwner { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsFoodCourt { get; set; }
        public int Editable { get; set; }
        public DateTime? ChargeDateFrom { get; set; }
        public DateTime? ChargeDateTo { get; set; }
        public decimal OmsetFrom { get; set; }
        public decimal OmsetTo { get; set; }
        public string Description { get; set; }
        public decimal MAGPortion { get; set; }
        public decimal MinimumAmount { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string DeleteUser { get; set; }
    }
    #endregion
}
