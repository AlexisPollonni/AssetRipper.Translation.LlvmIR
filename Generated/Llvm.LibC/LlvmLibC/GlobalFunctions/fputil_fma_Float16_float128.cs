using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_Float16_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_gEET_T0_S3_S3_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, __float128>(__float128, __float128, __float128)")]
	[return: NativeType("_Float16")]
	public static Half Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y, [NativeType("__float128")] double z)
	{
		return generic_fma_Float16_float128.Invoke(x, y, z);
	}
}
