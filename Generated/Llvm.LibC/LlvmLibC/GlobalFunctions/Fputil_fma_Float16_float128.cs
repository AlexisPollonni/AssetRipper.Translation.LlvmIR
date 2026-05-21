using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_Float16_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_gEET_T0_S3_S3_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, __float128>(__float128, __float128, __float128)")]
	[return: NativeType("_Float16")]
	public static Half Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y, [MangledName("z")][NativeType("__float128")] double Z)
	{
		return Generic_fma_Float16_float128.Invoke(X, Y, Z);
	}
}
