using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class conjugate_Float16_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICDF16_EET_S2_")]
	[DemangledName("_Float16 complex __llvm_libc_20_1_2_::conjugate<_Float16 complex>(_Float16 complex)")]
	[return: NativeType("_Float16 complex")]
	public unsafe static InlineArray2_Half Invoke([MangledName("c.coerce")][NativeType("_Float16 complex")] InlineArray2_Half c)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg2 = default(Struct_zwcg27);
		Complex_mify6x complex_mify6x = default(Complex_mify6x);
		Struct_zwcg27 struct_zwcg3 = default(Struct_zwcg27);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg2) = c;
			llvm_lifetime_start_p0.Invoke(4L, &complex_mify6x);
			*(Half*)(&complex_mify6x) = default(Half);
			*(Half*)((byte*)(&complex_mify6x) + 2) = default(Half);
			*(InlineArray2_Half*)(&complex_mify6x) = cpp_bit_cast_Complex_Float16_Float16_complex.Invoke(&struct_zwcg2);
			complex_mify6x.imag = (Half)(0f - (float)complex_mify6x.imag);
			*(InlineArray2_Half*)(&struct_zwcg3) = cpp_bit_cast_Float16_complex_Complex_Float16.Invoke(&complex_mify6x);
			Half field_ = struct_zwcg3.field_0;
			Half field_2 = struct_zwcg3.field_1;
			Half* ptr = &struct_zwcg.field_1;
			struct_zwcg.field_0 = field_;
			*ptr = field_2;
			llvm_lifetime_end_p0.Invoke(4L, &complex_mify6x);
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
