using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_dEET_T0_S3_S3_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, double>(double, double, double)")]
	[return: NativeType("_Float16")]
	public static Half Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y, [MangledName("z")][NativeType("double")] double Z)
	{
		return Generic_fma_Float16_double.Invoke(X, Y, Z);
	}
}
