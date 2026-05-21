using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_dEET_T0_S3_S3_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, double>(double, double, double)")]
	[return: NativeType("_Float16")]
	public static Half Invoke([NativeType("double")] double x, [NativeType("double")] double y, [NativeType("double")] double z)
	{
		return generic_fma_Float16_double.Invoke(x, y, z);
	}
}
