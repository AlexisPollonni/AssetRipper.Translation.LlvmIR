using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(11)]
public partial struct InlineArray11_Fputil_ExceptValues_float_6_Mapping : IEquatable<InlineArray11_Fputil_ExceptValues_float_6_Mapping>, IEqualityOperators<InlineArray11_Fputil_ExceptValues_float_6_Mapping, InlineArray11_Fputil_ExceptValues_float_6_Mapping, bool>, IEnumerable, IInlineArray<InlineArray11_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>
{
	private Fputil_ExceptValues_float_6_Mapping __element0;

	public static int Length => 11;

	public static bool operator ==(InlineArray11_Fputil_ExceptValues_float_6_Mapping x, InlineArray11_Fputil_ExceptValues_float_6_Mapping y)
	{
		return InlineArrayHelper.Equals<InlineArray11_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>(x, y);
	}

	public static bool operator !=(InlineArray11_Fputil_ExceptValues_float_6_Mapping x, InlineArray11_Fputil_ExceptValues_float_6_Mapping y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray11_Fputil_ExceptValues_float_6_Mapping other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray11_Fputil_ExceptValues_float_6_Mapping)
		{
			return Equals((InlineArray11_Fputil_ExceptValues_float_6_Mapping)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray11_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Fputil_ExceptValues_float_6_Mapping>)this).GetEnumerator();
	}
}
