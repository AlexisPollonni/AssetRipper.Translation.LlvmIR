using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cimagf16
{
	public unsafe static Half Invoke([MangledName("x.coerce")] InlineArray2_Half x)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Complex_mify6x complex_mify6x = default(Complex_mify6x);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg) = x;
			llvm_lifetime_start_p0.Invoke(4L, &complex_mify6x);
			*(Half*)(&complex_mify6x) = default(Half);
			*(Half*)((byte*)(&complex_mify6x) + 2) = default(Half);
			*(InlineArray2_Half*)(&complex_mify6x) = cpp_bit_cast_Complex_Float16_Float16_complex.Invoke(&struct_zwcg);
			Half imag = complex_mify6x.imag;
			llvm_lifetime_end_p0.Invoke(4L, &complex_mify6x);
			return imag;
		}
	}
}
