using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_getpayload_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10getpayloadIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::getpayload<float>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			float result;
			if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
			{
				result = -1f;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) & 0x3FFFFF;
				result = num;
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
