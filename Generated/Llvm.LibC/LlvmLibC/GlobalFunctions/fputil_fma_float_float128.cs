using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_float_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfgEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, __float128>(__float128, __float128, __float128)")]
	[return: NativeType("float")]
	public static float Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y, [NativeType("__float128")] double z)
	{
		return generic_fma_float_float128.Invoke(x, y, z);
	}
}
