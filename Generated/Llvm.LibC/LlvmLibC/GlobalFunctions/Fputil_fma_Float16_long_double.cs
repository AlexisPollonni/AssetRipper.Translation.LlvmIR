using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_Float16_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_eEET_T0_S3_S3_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, long double>(long double, long double, long double)")]
	[return: NativeType("_Float16")]
	public static Half Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y, [MangledName("z")][NativeType("long double")] double Z)
	{
		return Generic_fma_Float16_long_double.Invoke(X, Y, Z);
	}
}
