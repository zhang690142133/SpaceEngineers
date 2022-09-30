← [API索引](Api-Index) ← [命名空间索引](Namespace-Index)

#### MyIniValue Struct

```csharp
public struct MyIniValue
```

Represents the value of a single configuration item.

**命名空间:** [VRage.Game.ModAPI.Ingame.Utilities](VRage.Game.ModAPI.Ingame.Utilities)  
**Assembly:** VRage.Game.dll

#### Fields

[static MyIniValue EMPTY](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.EMPTY)

> Represents an empty [MyIniValue](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue) 

[MyIniKey Key](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.Key)

> Gets the [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) this value was retrieved from

#### Properties

[bool IsEmpty { get; }](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.IsEmpty)

> Determines whether this value is empty. Be aware that an empty string is not considered to be an empty value.

#### Constructors

[MyIniValue(MyIniKey key, string value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue..ctor)

> 

#### 方法

[void GetLines(List&lt;string&gt; lines)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.GetLines)

> Retrieves each individual line of this value into the provided list.

[bool ToBoolean(bool defaultValue = default)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToBoolean)

> Attempts to get this value as a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[byte ToByte(byte defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToByte)

> Attempts to get this value as a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[char ToChar(char defaultValue = default)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToChar)

> Attempts to get this value as a [System.Char](https://docs.microsoft.com/en-us/dotnet/api/system.char?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[decimal ToDecimal(decimal defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToDecimal)

> Attempts to get this value as a [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[double ToDouble(double defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToDouble)

> Attempts to get this value as a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[short ToInt16(short defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToInt16)

> Attempts to get this value as a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/system.int16?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[int ToInt32(int defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToInt32)

> Attempts to get this value as a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[long ToInt64(long defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToInt64)

> Attempts to get this value as a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[sbyte ToSByte(sbyte defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToSByte)

> Attempts to get this value as a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[float ToSingle(float defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToSingle)

> Attempts to get this value as a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[string ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToString)

> Attempts to get this value as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, an empty string will be returned instead.

[string ToString(string defaultValue)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToString)

> Attempts to get this value as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[ushort ToUInt16(ushort defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToUInt16)

> Attempts to get this value as a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/system.uint16?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[uint ToUInt32(uint defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToUInt32)

> Attempts to get this value as a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[ulong ToUInt64(ulong defaultValue = 0)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.ToUInt64)

> Attempts to get this value as a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.

[bool TryGetBoolean(out bool value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetBoolean)

> Attempts to get this value as a [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetByte(out byte value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetByte)

> Attempts to get this value as a [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetChar(out char value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetChar)

> Attempts to get this value as a [System.Char](https://docs.microsoft.com/en-us/dotnet/api/system.char?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetDecimal(out decimal value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetDecimal)

> Attempts to get this value as a [System.Decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetDouble(out double value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetDouble)

> Attempts to get this value as a [System.Double](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetInt16(out short value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetInt16)

> Attempts to get this value as a [System.Int16](https://docs.microsoft.com/en-us/dotnet/api/system.int16?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetInt32(out int value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetInt32)

> Attempts to get this value as a [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetInt64(out long value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetInt64)

> Attempts to get this value as a [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/system.int64?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetSByte(out sbyte value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetSByte)

> Attempts to get this value as a [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetSingle(out float value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetSingle)

> Attempts to get this value as a [System.Single](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetString(out string value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetString)

> Attempts to get this value as a [System.String](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetUInt16(out ushort value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetUInt16)

> Attempts to get this value as a [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/system.uint16?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetUInt32(out uint value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetUInt32)

> Attempts to get this value as a [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/system.uint32?view=netframework-4.6) . Fills the`value`on success.

[bool TryGetUInt64(out ulong value)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.TryGetUInt64)

> Attempts to get this value as a [System.UInt64](https://docs.microsoft.com/en-us/dotnet/api/system.uint64?view=netframework-4.6) . Fills the`value`on success.

[void Write(StringBuilder stringBuilder)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue.Write)

> Writes this value as a string to the given string builder.

