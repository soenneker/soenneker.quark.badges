using Intellenum;

namespace Soenneker.Quark.Badges.Enums;

/// <summary>
/// Badge type enumeration.
/// </summary>
[Intellenum<string>]
public sealed partial class BadgeType
{
    public static readonly BadgeType Badge = new("badge");
    public static readonly BadgeType Pill = new("pill");
    public static readonly BadgeType Dot = new("dot");
}
