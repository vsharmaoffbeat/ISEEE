//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISEEDataModel.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientParamMode
    {
        public int Mode { get; set; }
        public string ModeDesc { get; set; }
        public int DataSendInterval { get; set; }
        public int SampleRate { get; set; }
        public int GpsSigLossSleep { get; set; }
        public int StandingGpsSleep { get; set; }
        public int MinimalAccuracyReq { get; set; }
        public int GpsLossTimeOutWithRecep { get; set; }
        public int GpsLossTimeOutNoRecep { get; set; }
        public int SamplesToDetermineStand { get; set; }
        public int StandingAvgDistance { get; set; }
    }
}