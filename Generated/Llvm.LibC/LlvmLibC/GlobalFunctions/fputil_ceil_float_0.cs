using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_ceil_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4ceilIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::ceil<float, 0>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		float num5 = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			float result;
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				if (num >= 23)
				{
					result = x;
				}
				else if (num <= -1)
				{
					result = (((b & 1) != 1) ? 1f : 0f);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(23 - num);
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = num3 >>> num2 << num2;
					if (num4 == num3)
					{
						result = x;
					}
					else
					{
						FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2), num4);
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
						result = (((b & 1) != 1) ? (num5 + 1f) : num5);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
