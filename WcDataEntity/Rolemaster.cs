using System;
using System.Collections.Generic;

namespace Wc.DataEntity;

public partial class Rolemaster
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<UserInfo> UserInfos { get; set; } = new List<UserInfo>();
}
