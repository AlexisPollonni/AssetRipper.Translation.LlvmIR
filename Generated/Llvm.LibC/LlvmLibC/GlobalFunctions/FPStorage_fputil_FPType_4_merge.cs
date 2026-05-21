using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_4_merge
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE4EE5mergeEooo")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)4>::merge(unsigned __int128, unsigned __int128, unsigned __int128)")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long A, [MangledName("a.coerce1")] long B, [MangledName("b.coerce0")] long Mask, [MangledName("b.coerce1")] long B_coerce1, [MangledName("mask.coerce0")] long Mask_coerce0, [MangledName("mask.coerce1")] long Mask_coerce1)
	{
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		unchecked
		{
			*(long*)(&@int) = A;
			((long*)(&@int))[1] = B;
			Int128 int4 = @int;
			*(long*)(&int2) = Mask;
			((long*)(&int2))[1] = B_coerce1;
			Int128 y = int2;
			*(long*)(&int3) = Mask_coerce0;
			((long*)(&int3))[1] = Mask_coerce1;
			Int128 y2 = int3;
			Int128 x = int4;
			Int128 int5 = NumericHelper.BitwiseXor(x, NumericHelper.BitwiseAnd(NumericHelper.BitwiseXor(x, y), y2));
			return *(Struct_fiz2nb*)(&int5);
		}
	}
}
