﻿using System;

namespace propertymanagement.service.Models.ViewModel
{
    public class ChargeTypeListModel
    {
        public Guid? ParamId { get; set; }
        public string ParamValue { get; set; }
        public string ParamCode { get; set;}
        public string ParamSort { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        public string CreateUser { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
    }
}
