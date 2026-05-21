using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIDF16_fEET_T0_S3_S3_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fma<_Float16, float>(float, float, float)")]
	[return: NativeType("_Float16")]
	public static Half Invoke([NativeType("float")] float x, [NativeType("float")] float y, [NativeType("float")] float z)
	{
		return generic_fma_Float16_float.Invoke(x, y, z);
	}
}
