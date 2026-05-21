using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_nextafter_float_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIffTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::nextafter<float, float, 0>(float, float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([NativeType("float")] float from, [NativeType("float")] float to)
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
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, from);
			float result;
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
			{
				result = from;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, to);
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs3))
				{
					result = fputil_cast_float_float.Invoke(to);
				}
				else if (fputil_cast_float_float.Invoke(from) == to)
				{
					result = fputil_cast_float_float.Invoke(to);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(from, 0f))
					{
						if (fputil_cast_float_float.Invoke(from) < to == from > 0f)
						{
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs4, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) + 1);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) - 1);
							llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						}
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						anon_izyfb8.val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs3);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
					}
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&fputil_FPBits_5nkvcs2))
					{
						fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2))
					{
						fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
