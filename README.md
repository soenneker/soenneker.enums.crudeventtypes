[![](https://img.shields.io/nuget/v/soenneker.enums.crudeventtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.crudeventtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.crudeventtypes/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.enums.crudeventtypes/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.enums.crudeventtypes.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.enums.crudeventtypes/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.enums.crudeventtypes/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.enums.crudeventtypes/actions/workflows/codeql.yml)

# Soenneker.Enums.CrudEventTypes

A string-backed enum-value type for identifying the create, read, update, or delete operation represented by an event.

## Install

```bash
dotnet add package Soenneker.Enums.CrudEventTypes
```

## Usage

```csharp
using Soenneker.Enums.CrudEventTypes;

CrudEventType eventType = CrudEventType.Update;
string wireValue = eventType.Value; // "Update"

if (CrudEventType.TryFromValue(input, out CrudEventType? parsed))
{
    // parsed is one of the shared static instances
}
```

Available values:

- `Create`
- `Read`
- `Update`
- `Delete`

`System.Text.Json` serializes the type as its string value and restores known values to the corresponding static instance. `FromValue` throws for an unknown value; use `TryFromValue` when handling external input. `FromName` and `TryFromName` are also generated for member-name lookup.

The type only labels an operation. It does not perform CRUD work or describe when an operation occurred, whether it succeeded, or whether an event represents a request or a completed change; define that meaning in the surrounding event contract.
