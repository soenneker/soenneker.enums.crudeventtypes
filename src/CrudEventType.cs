using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.CrudEventTypes;

/// <summary>
/// An enumeration for Create, Read, Update, Delete events.
/// </summary>
[EnumValue<string>]
public sealed partial class CrudEventType
{
    public static readonly CrudEventType Create = new(nameof(Create));

    public static readonly CrudEventType Read = new(nameof(Read));

    public static readonly CrudEventType Update = new(nameof(Update));

    public static readonly CrudEventType Delete = new(nameof(Delete));
}
