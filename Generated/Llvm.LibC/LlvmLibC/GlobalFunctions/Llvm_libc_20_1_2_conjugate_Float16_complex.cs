using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_conjugate_Float16_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICDF16_EET_S2_")]
	[DemangledName("_Float16 complex __llvm_libc_20_1_2_::conjugate<_Float16 complex>(_Float16 complex)")]
	[return: NativeType("_Float16 complex")]
	public unsafe static InlineArray2_Half Invoke([MangledName("c.coerce")][NativeType("_Float16 complex")] InlineArray2_Half C)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg2 = default(Struct_zwcg27);
		Llvm_libc_20_1_2_Complex_mify6x llvm_libc_20_1_2_Complex_mify6x = default(Llvm_libc_20_1_2_Complex_mify6x);
		Struct_zwcg27 struct_zwcg3 = default(Struct_zwcg27);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg2) = C;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_Complex_mify6x);
			*(Half*)(&llvm_libc_20_1_2_Complex_mify6x) = default(Half);
			*(Half*)((byte*)(&llvm_libc_20_1_2_Complex_mify6x) + 2) = default(Half);
			*(InlineArray2_Half*)(&llvm_libc_20_1_2_Complex_mify6x) = Cpp_bit_cast_Complex_Float16_Float16_complex.Invoke(&struct_zwcg2);
			llvm_libc_20_1_2_Complex_mify6x.Imag = (Half)(0f - (float)llvm_libc_20_1_2_Complex_mify6x.Imag);
			*(InlineArray2_Half*)(&struct_zwcg3) = Cpp_bit_cast_Float16_complex_Complex_Float16.Invoke(&llvm_libc_20_1_2_Complex_mify6x);
			Half field_ = struct_zwcg3.field_0;
			Half field_2 = struct_zwcg3.field_1;
			Half* ptr = &struct_zwcg.field_1;
			struct_zwcg.field_0 = field_;
			*ptr = field_2;
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_Complex_mify6x);
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
