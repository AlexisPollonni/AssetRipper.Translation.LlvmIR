using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_frexp_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5frexpIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_Ri")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::frexp<float, 0>(float, int&)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("exp")][NativeType("int&")] void* Exp)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_NormalFloat_phu2qv fputil_NormalFloat_phu2qv = default(Fputil_NormalFloat_phu2qv);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			float result;
			if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)))
			{
				result = X;
			}
			else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs))
			{
				*(int*)Exp = 0;
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(12L, &fputil_NormalFloat_phu2qv);
				*(int*)(&fputil_NormalFloat_phu2qv) = -1431655766;
				((int*)(&fputil_NormalFloat_phu2qv))[1] = -1431655766;
				((sbyte*)(&fputil_NormalFloat_phu2qv))[8] = -86;
				sbyte* ptr = (sbyte*)(&fputil_NormalFloat_phu2qv) + 9;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs, 4L, isVolatile: false);
				NormalFloat_float_Constructor.Invoke(&fputil_NormalFloat_phu2qv, fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0);
				*(int*)Exp = checked(fputil_NormalFloat_phu2qv.Exponent + 1);
				fputil_NormalFloat_phu2qv.Exponent = -1;
				result = NormalFloat_float_ToSingle.Invoke(&fputil_NormalFloat_phu2qv);
				Llvm_lifetime_end_p0.Invoke(12L, &fputil_NormalFloat_phu2qv);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
