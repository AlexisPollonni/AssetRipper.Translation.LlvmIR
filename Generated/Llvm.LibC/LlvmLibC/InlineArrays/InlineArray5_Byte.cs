using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(5)]
public partial struct InlineArray5_Byte : IEquatable<InlineArray5_Byte>, IEqualityOperators<InlineArray5_Byte, InlineArray5_Byte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray5_Byte, byte>, IInlineArray<InlineArray5_Byte, sbyte>
{
	private byte __element0;

	public static int Length => 5;

	public static bool operator ==(InlineArray5_Byte x, InlineArray5_Byte y)
	{
		return InlineArrayHelper.Equals<InlineArray5_Byte, byte>(x, y);
	}

	public static bool operator !=(InlineArray5_Byte x, InlineArray5_Byte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray5_Byte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray5_Byte)
		{
			return Equals((InlineArray5_Byte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray5_Byte, byte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<byte>)this).GetEnumerator();
	}
}
