using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextafter_float_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9nextafterIffTnNS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_EiE4typeELi0EEES4_S4_S5_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::nextafter<float, float, 0>(float, float)")]
	[return: NativeType("float")]
	public unsafe static float Invoke([MangledName("from")][NativeType("float")] float From, [MangledName("to")][NativeType("float")] float To)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, From);
			float result;
			if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
			{
				result = From;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, To);
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs2))
				{
					result = Fputil_cast_float_float.Invoke(To);
				}
				else if (Fputil_cast_float_float.Invoke(From) == To)
				{
					result = Fputil_cast_float_float.Invoke(To);
				}
				else
				{
					if (NumericHelper.IsUnorderedOrNotEquals(From, 0f))
					{
						if (Fputil_cast_float_float.Invoke(From) < To == From > 0f)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) + 1);
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs4, FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) - 1);
							Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
							Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						}
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs2);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb.Val);
						fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					}
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&fputil_FPBits_5nkvcs))
					{
						Fputil_raise_except_if_required.Invoke(48);
					}
					else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs))
					{
						Fputil_raise_except_if_required.Invoke(40);
					}
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
