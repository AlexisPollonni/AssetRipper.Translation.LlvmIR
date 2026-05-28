using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fminimum_num_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fminimum_numIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fminimum_num<float, 0>(float, float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, Y);
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs2))
			{
				Fputil_raise_except_if_required.Invoke(1);
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs) && FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					goto IL_0143;
				}
			}
			result = ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs)) ? ((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2)) ? Internal_min_float.Invoke(X, Y) : X) : Y);
			goto IL_0143;
		}
		IL_0143:
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		return result;
	}
}
