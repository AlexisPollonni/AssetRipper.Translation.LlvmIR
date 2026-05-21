using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_modf_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4modfIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_RS4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::modf<float, 0>(float, float&)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x, [NativeType("float&")] void* iptr)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			float result;
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
			{
				*(float*)iptr = x;
				result = x;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2))
			{
				*(float*)iptr = x;
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb8.val);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			else
			{
				*(float*)iptr = fputil_trunc_float_0.Invoke(x);
				if (x == *(float*)iptr)
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					anon_izyfb9.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
				else
				{
					result = x - *(float*)iptr;
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
