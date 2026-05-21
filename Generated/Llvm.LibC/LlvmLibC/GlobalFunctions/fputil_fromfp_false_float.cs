using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fromfp_false_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6fromfpILb0EfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::fromfp<false, float>(float, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type")]
	public unsafe static float Invoke([NativeType("float")] float x, [NativeType("int")] int rnd, [NativeType("unsigned int")] int width)
	{
		int num = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		float num2 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		int num3 = 0;
		float num4 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			float result;
			if (width == 0)
			{
				fputil_raise_except_if_required.Invoke(1);
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, x);
				if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)))
				{
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb9.val, 0);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = fputil_round_using_specific_rounding_mode_float.Invoke(x, rnd);
					if (num2 < 0f)
					{
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb10.val, 0);
						fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
						result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					}
					else if ((uint)width > 127u)
					{
						result = num2;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = width + 127;
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(biased_exp: num3, sign: anon_izyfb11.val, mantissa: 0);
						fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
						float num5 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6) - 1f;
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						num4 = num5;
						if (num2 > num4)
						{
							fputil_raise_except_if_required.Invoke(1);
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_5 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb12.val, 0);
							fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
							result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
						}
						else
						{
							result = num2;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num4);
						llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
