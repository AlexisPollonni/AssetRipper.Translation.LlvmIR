using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_trunc_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5truncIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::trunc<float, 0>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		int mantVal = 0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			float result;
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				if (num >= 23)
				{
					result = x;
				}
				else if (num <= -1)
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb8.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(23 - num);
					llvm_lifetime_start_p0.Invoke(4L, &mantVal);
					mantVal = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) >>> num2 << num2;
					FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2), mantVal);
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &mantVal);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
