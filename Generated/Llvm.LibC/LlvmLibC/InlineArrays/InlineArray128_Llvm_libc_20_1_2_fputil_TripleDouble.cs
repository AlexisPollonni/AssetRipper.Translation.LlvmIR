using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(128)]
public partial struct InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble : IEquatable<InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble>, IEqualityOperators<InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble, InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>
{
	private Llvm_libc_20_1_2_fputil_TripleDouble __element0;

	public static int Length => 128;

	public static bool operator ==(InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble x, InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble y)
	{
		return InlineArrayHelper.Equals<InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>(x, y);
	}

	public static bool operator !=(InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble x, InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble other)
	{
		return this == other;
	}

	public override bool Equals(object other)
	{
		if (other is InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble)
		{
			return Equals((InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray128_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_TripleDouble>)this).GetEnumerator();
	}
}
