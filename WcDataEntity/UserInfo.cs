using System;
using System.Collections.Generic;

namespace Wc.DataEntity;

public partial class UserInfo
{
    public int Userid { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Password { get; set; }

    public string? PasswordSalt { get; set; }

    public int? RoleId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public int? CityId { get; set; }

    public string? Zipcode { get; set; }

    public string? Email { get; set; }

    public virtual Rolemaster? Role { get; set; }
}
