using System;

namespace TodosApp.Extensions;

public static class ConversionExtensions
{
  public static bool ToBool(this object? value) => value is not null && (bool)value;
}
