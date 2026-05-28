using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(3)]
public partial struct InlineArray3_Byte : IEquatable<InlineArray3_Byte>, IEqualityOperators<InlineArray3_Byte, InlineArray3_Byte, bool>, IEnumerable, IInlineArray<InlineArray3_Byte, byte>, IInlineArray<InlineArray3_Byte, sbyte>
{
	private byte __element0;

	public static int Length => 3;

	public static bool operator ==(InlineArray3_Byte x, InlineArray3_Byte y)
	{
		return InlineArrayHelper.Equals<InlineArray3_Byte, byte>(x, y);
	}

	public static bool operator !=(InlineArray3_Byte x, InlineArray3_Byte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray3_Byte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray3_Byte)
		{
			return Equals((InlineArray3_Byte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray3_Byte, byte>();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<byte>)this).GetEnumerator();
	}
}
