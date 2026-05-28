using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(61)]
public partial struct InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry : IEquatable<InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry>, IEqualityOperators<InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry, InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry, bool>, IEnumerable, IInlineArray<InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry, Llvm_libc_20_1_2_internal_LShiftTableEntry>
{
	private Llvm_libc_20_1_2_internal_LShiftTableEntry __element0;

	public static int Length => 61;

	public static bool operator ==(InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry x, InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry y)
	{
		return InlineArrayHelper.Equals<InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry, Llvm_libc_20_1_2_internal_LShiftTableEntry>(x, y);
	}

	public static bool operator !=(InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry x, InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry)
		{
			return Equals((InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray61_Llvm_libc_20_1_2_internal_LShiftTableEntry, Llvm_libc_20_1_2_internal_LShiftTableEntry>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_internal_LShiftTableEntry>)this).GetEnumerator();
	}
}
