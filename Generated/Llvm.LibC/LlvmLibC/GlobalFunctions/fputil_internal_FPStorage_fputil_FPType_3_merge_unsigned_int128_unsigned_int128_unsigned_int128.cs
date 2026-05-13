using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE3EE5mergeEooo")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)3>::merge(unsigned __int128, unsigned __int128, unsigned __int128)")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_3_merge_unsigned_int128_unsigned_int128_unsigned_int128
{
	public unsafe static Struct_fiz2nb Invoke([MangledName("a.coerce0")] long a, [MangledName("a.coerce1")] long b, [MangledName("b.coerce0")] long mask, [MangledName("b.coerce1")] long b_coerce1, [MangledName("mask.coerce0")] long mask_coerce0, [MangledName("mask.coerce1")] long mask_coerce1)
	{
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		unchecked
		{
			*(long*)(&@int) = a;
			((long*)(&@int))[1] = b;
			Int128 int4 = @int;
			*(long*)(&int2) = mask;
			((long*)(&int2))[1] = b_coerce1;
			Int128 y = int2;
			*(long*)(&int3) = mask_coerce0;
			((long*)(&int3))[1] = mask_coerce1;
			Int128 y2 = int3;
			Int128 x = int4;
			Int128 int5 = NumericHelper.BitwiseXor(x, NumericHelper.BitwiseAnd(NumericHelper.BitwiseXor(x, y), y2));
			return *(Struct_fiz2nb*)(&int5);
		}
	}
}
