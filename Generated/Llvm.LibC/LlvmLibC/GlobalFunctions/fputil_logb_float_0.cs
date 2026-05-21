using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_logb_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4logbIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::logb<float, 0>(float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_DyadicFloat_cs3nhs fputil_DyadicFloat_cs3nhs2 = default(fputil_DyadicFloat_cs3nhs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			float result;
			if (details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2)) ? FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) : true, expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = x;
				}
				else
				{
					fputil_raise_except_if_required.Invoke(4);
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&fputil_FPBits_5nkvcs2))
					{
						fputil_set_errno_if_required.Invoke(34);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb9.val);
						fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					}
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
				*(sbyte*)(&fputil_DyadicFloat_cs3nhs2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_cs3nhs2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_cs3nhs2))[1] = -1431655766;
				((int*)(&fputil_DyadicFloat_cs3nhs2))[2] = -1431655766;
				DyadicFloat_32ul_DyadicFloat_float_0.Invoke(&fputil_DyadicFloat_cs3nhs2, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2));
				result = DyadicFloat_32ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_cs3nhs2);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_cs3nhs2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
