using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(1)]
public partial struct InlineArray1_va_list_tag : IEquatable<InlineArray1_va_list_tag>, IEqualityOperators<InlineArray1_va_list_tag, InlineArray1_va_list_tag, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray1_va_list_tag, va_list_tag>
{
	private va_list_tag __element0;

	public static int Length => 1;

	public static bool operator ==(InlineArray1_va_list_tag x, InlineArray1_va_list_tag y)
	{
		return InlineArrayHelper.Equals<InlineArray1_va_list_tag, va_list_tag>(x, y);
	}

	public static bool operator !=(InlineArray1_va_list_tag x, InlineArray1_va_list_tag y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray1_va_list_tag other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray1_va_list_tag)
		{
			return Equals((InlineArray1_va_list_tag)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray1_va_list_tag, va_list_tag>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<va_list_tag>)this).GetEnumerator();
	}
}
