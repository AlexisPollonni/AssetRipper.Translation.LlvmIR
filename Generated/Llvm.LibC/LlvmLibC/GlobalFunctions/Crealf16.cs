using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Crealf16
{
	[MangledName("crealf16")]
	[DemangledName("crealf16")]
	public unsafe static Half Invoke([MangledName("x.coerce")] InlineArray2_Half X)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Llvm_libc_20_1_2_Complex_mify6x llvm_libc_20_1_2_Complex_mify6x = default(Llvm_libc_20_1_2_Complex_mify6x);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg) = X;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_Complex_mify6x);
			*(Half*)(&llvm_libc_20_1_2_Complex_mify6x) = default(Half);
			*(Half*)((byte*)(&llvm_libc_20_1_2_Complex_mify6x) + 2) = default(Half);
			*(InlineArray2_Half*)(&llvm_libc_20_1_2_Complex_mify6x) = Cpp_bit_cast_Complex_Float16_Float16_complex.Invoke(&struct_zwcg);
			Half real = llvm_libc_20_1_2_Complex_mify6x.Real;
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_Complex_mify6x);
			return real;
		}
	}
}
