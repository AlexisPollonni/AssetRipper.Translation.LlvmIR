using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIffEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, float>(float, float, float)")]
	[return: NativeType("float")]
	public static float Invoke([NativeType("float")] float x, [NativeType("float")] float y, [NativeType("float")] float z)
	{
		return generic_fma_float_float.Invoke(x, y, z);
	}
}
