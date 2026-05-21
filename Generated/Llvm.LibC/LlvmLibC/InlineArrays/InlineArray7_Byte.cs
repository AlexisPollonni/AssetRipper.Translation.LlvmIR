using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.InlineArrays;

[InlineArray(7)]
public partial struct InlineArray7_Byte : IEquatable<InlineArray7_Byte>, IEqualityOperators<InlineArray7_Byte, InlineArray7_Byte, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray7_Byte, byte>, IInlineArray<InlineArray7_Byte, sbyte>
{
	private byte __element0;

	public static int Length => 7;

	public static bool operator ==(InlineArray7_Byte x, InlineArray7_Byte y)
	{
		return InlineArrayHelper.Equals<InlineArray7_Byte, byte>(x, y);
	}

	public static bool operator !=(InlineArray7_Byte x, InlineArray7_Byte y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray7_Byte other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray7_Byte)
		{
			return Equals((InlineArray7_Byte)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray7_Byte, byte>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<byte>)this).GetEnumerator();
	}
}
