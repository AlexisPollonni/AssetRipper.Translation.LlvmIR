using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.Structures;

namespace LlvmLibC.InlineArrays;

[InlineArray(64)]
public partial struct InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble : IEquatable<InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble>, IEqualityOperators<InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble, InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble, bool>, System.Collections.IEnumerable, IInlineArray<InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>
{
	private Llvm_libc_20_1_2_fputil_TripleDouble __element0;

	public static int Length => 64;

	public static bool operator ==(InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble x, InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble y)
	{
		return InlineArrayHelper.Equals<InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>(x, y);
	}

	public static bool operator !=(InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble x, InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble y)
	{
		return !(x == y);
	}

	public bool Equals(InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble other)
	{
		return this == other;
	}

	public override bool Equals(object? other)
	{
		if (other is InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble)
		{
			return Equals((InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return this.GetHashCode<InlineArray64_Llvm_libc_20_1_2_fputil_TripleDouble, Llvm_libc_20_1_2_fputil_TripleDouble>();
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<Llvm_libc_20_1_2_fputil_TripleDouble>)this).GetEnumerator();
	}
}
