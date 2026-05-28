using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_min_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal3minIfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES5_E4typeES5_S5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::internal::min<float>(float, float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, Y);
			anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
			anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
			float result = ((!NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? ((!(X < Y)) ? Y : X) : ((!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs))) ? Y : X));
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
