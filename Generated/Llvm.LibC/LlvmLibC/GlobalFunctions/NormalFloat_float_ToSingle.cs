using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_ToSingle
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfEcvfEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::operator float() const")]
	public unsafe static float Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv* This)
	{
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = This->Exponent + 127;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 254;
		unchecked
		{
			float result;
			if (num > 254)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) = -1431655766;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, 0f);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, anon_izyfb2.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -126;
				if (This->Exponent < -126)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-126 - This->Exponent);
					if ((uint)num4 <= 24u)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = (1 << num4) - 1;
						Llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = This->Mantissa & num5;
						Llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = 1 << num4 - 1;
						FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), 0);
						FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), This->Mantissa >>> num4);
						Llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
						if ((uint)num6 > (uint)num7)
						{
							num8++;
						}
						else if (num6 == num7 && (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) & 1) != 0)
						{
							num8++;
						}
						FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), num8);
						if (num8 == 8388608)
						{
							FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), 1);
						}
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &num8);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
						Llvm_lifetime_end_p0.Invoke(4L, &num6);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
					else
					{
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), checked(This->Exponent + 127));
					FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), This->Mantissa);
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
