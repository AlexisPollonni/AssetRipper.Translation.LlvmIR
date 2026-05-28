using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fromfpx_false_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb0EfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::fromfpx<false, float>(float, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("rnd")][NativeType("int")] int Rnd, [MangledName("width")][NativeType("unsigned int")] int Width)
	{
		float num = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = Fputil_fromfp_false_float.Invoke(X, Rnd, Width);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		*unchecked((int*)(&fputil_FPBits_5nkvcs)) = -1431655766;
		FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, num);
		if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs) && NumericHelper.IsUnorderedOrNotEquals(num, X))
		{
			Fputil_raise_except_if_required.Invoke(32);
		}
		float result = num;
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
