using System;
using System.Collections.Generic;

namespace opendataws.data.Models
{
    public partial class IncidentSource
    {
        public uint Id { get; set; }
        public string Title { get; set; } = null!;
        public string Icon { get; set; } = null!;
        public bool CanBeReturned { get; set; }
        public bool? CanBeDeleted { get; set; }
        public bool? CanBeReopened { get; set; }
        public bool? StaffOnly { get; set; }
        public bool IsWebForm { get; set; }
        public uint? DeletedAt { get; set; }
        public string? HomeIcon { get; set; }
        public string HomePanel { get; set; } = null!;
        public uint AllowReopenInDays { get; set; }
        public bool CanBeCommented { get; set; }
        public string HomePanelCustomColor { get; set; } = null!;
        public string HomePanelCustomTextColor { get; set; } = null!;
        public bool ExactlyResponsibleUserOnly { get; set; }
        public string? Custom { get; set; }
        public bool? AllowFileUpload { get; set; }
        public bool CanBeDivided { get; set; }
        public string DivideOptions { get; set; } = null!;
        public bool? ConnectWithUlakbel { get; set; }
        public string? UlakbelAddress { get; set; }
        public string? UlakbelApiToken { get; set; }
        public string? IncidentActionInfos { get; set; }
        public ushort OrderPriority { get; set; }
        public string? ActionsCanBeViewedPublic { get; set; }
        public bool? ForceSendCriticalNotifications { get; set; }
        public bool? HideIncidentActionsFromCreator { get; set; }
        public string? IncidentInfoFieldsCanBeViewedPublic { get; set; }
        public string? AnswerOptions { get; set; }
        public bool? AutoCompleteIfWaitingForApproval { get; set; }
        public int? AutoCompleteDays { get; set; }
        public bool? PublicIncidentShowSmsVerification { get; set; }
        public byte? NumbersOfReopen { get; set; }
    }
}
