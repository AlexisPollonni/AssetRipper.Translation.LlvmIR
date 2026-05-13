using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIffTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
[DemangledName("float __llvm_libc_20_1_2_::fputil::nextafter<float, float, 0>(float, float)")]
internal static partial class float_fputil_nextafter_float_float_0_float_float
{
	public unsafe static float Invoke(float from, float to)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, from);
			float result;
			if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				result = from;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
				fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, to);
				if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs3))
				{
					result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_float_type_fputil_cast_float_float_float.Invoke(to);
				}
				else if (cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_float_type_fputil_cast_float_float_float.Invoke(from) == to)
				{
					result = cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_float_type_fputil_cast_float_float_float.Invoke(to);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(from, 0f))
					{
						if (cpp_enable_if_cpp_is_floating_point_v_float_cpp_is_floating_point_v_float_float_type_fputil_cast_float_float_float.Invoke(from) < to == from > 0f)
						{
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
							fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs4, fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) + 1);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
							fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) - 1);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs3);
						int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal_Sign.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					}
					if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						fputil_raise_except_if_required_int.Invoke(48);
					}
					else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						fputil_raise_except_if_required_int.Invoke(40);
					}
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
