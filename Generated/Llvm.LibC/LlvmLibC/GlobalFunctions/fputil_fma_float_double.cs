using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfdEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, double>(double, double, double)")]
	[return: NativeType("float")]
	public static float Invoke([NativeType("double")] double x, [NativeType("double")] double y, [NativeType("double")] double z)
	{
		return generic_fma_float_double.Invoke(x, y, z);
	}
}
