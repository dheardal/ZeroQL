using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ZeroQL.Json;

public static class ZeroQLEnumJsonSerializersStore
{
    public static Dictionary<Type, JsonConverter> Converters { get; } = new();
}