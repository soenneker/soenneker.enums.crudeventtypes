using Soenneker.Gen.EnumValues;

namespace Soenneker.Enums.CrudEventTypes;

/// <summary>
/// An enumeration for Create, Read, Update, Delete events.
/// </summary>
[EnumValue<string>]
public sealed partial class CrudEventType
{
    /// <summary>
    /// The create.
    /// </summary>
    public static readonly CrudEventType Create = new(nameof(Create));

    /// <summary>
    /// The read.
    /// </summary>
    public static readonly CrudEventType Read = new(nameof(Read));

    /// <summary>
    /// The update.
    /// </summary>
    public static readonly CrudEventType Update = new(nameof(Update));

    /// <summary>
    /// The delete.
    /// </summary>
    public static readonly CrudEventType Delete = new(nameof(Delete));
}
