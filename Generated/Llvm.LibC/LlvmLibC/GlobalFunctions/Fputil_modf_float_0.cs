using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_modf_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4modfIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_RS4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::modf<float, 0>(float, float&)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("iptr")][NativeType("float&")] void* Iptr)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			float result;
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
			{
				*(float*)Iptr = X;
				result = X;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs))
			{
				*(float*)Iptr = X;
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb.Val);
				fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			else
			{
				*(float*)Iptr = Fputil_trunc_float_0.Invoke(X);
				if (X == *(float*)Iptr)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb2.Val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					result = X - *(float*)Iptr;
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
