using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(61)]
public partial struct InlineArray61_Internal_LShiftTableEntry : IEquatable<InlineArray61_Internal_LShiftTableEntry>, IEqualityOperators<InlineArray61_Internal_LShiftTableEntry, InlineArray61_Internal_LShiftTableEntry, bool>, IEnumerable, IInlineArray<InlineArray61_Internal_LShiftTableEntry, Internal_LShiftTableEntry>
{
	private Internal_LShiftTableEntry __element0;

	public static int Length => 61;

	public static bool operator ==(InlineArray61_Internal_LShiftTableEntry x, InlineArray61_Internal_LShiftTableEntry y)
	{
		return InlineArrayHelper.Equals<InlineArray61_Internal_LShiftTableEntry, Internal_LShiftTableEntry>(x, y);
	}

	public static bool operator !=(InlineArray61_Internal_LShiftTableEntry x, InlineArray61_Internal_LShiftTableEntry y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray61_Internal_LShiftTableEntry other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray61_Internal_LShiftTableEntry)
		{
			return Equals((InlineArray61_Internal_LShiftTableEntry)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray61_Internal_LShiftTableEntry, Internal_LShiftTableEntry>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Internal_LShiftTableEntry>)this).GetEnumerator();
	}
}
