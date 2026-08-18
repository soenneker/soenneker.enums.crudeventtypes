using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.CrudEventTypes;

/// <summary>
/// Identifies the create, read, update, or delete action represented by a data event.
/// </summary>
[EnumValue<string>]
public sealed partial class CrudEventType
{
    /// <summary>
    /// A resource was or will be created.
    /// </summary>
    public static readonly CrudEventType Create = new(nameof(Create));

    /// <summary>
    /// A resource was or will be read.
    /// </summary>
    public static readonly CrudEventType Read = new(nameof(Read));

    /// <summary>
    /// A resource was or will be updated.
    /// </summary>
    public static readonly CrudEventType Update = new(nameof(Update));

    /// <summary>
    /// A resource was or will be deleted.
    /// </summary>
    public static readonly CrudEventType Delete = new(nameof(Delete));
}
