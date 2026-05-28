using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fromfp_true_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6fromfpILb1EfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::fromfp<true, float>(float, int, unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("rnd")][NativeType("int")] int Rnd, [MangledName("width")][NativeType("unsigned int")] int Width)
	{
		int num = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		float num2 = 0f;
		int num3 = 0;
		float num4 = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		float num5 = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		unchecked
		{
			float result;
			if (Width == 0)
			{
				Fputil_raise_except_if_required.Invoke(1);
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
				fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, X);
				if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb2.Val, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = Fputil_round_using_specific_rounding_mode_float.Invoke(X, Rnd);
					if ((uint)(Width - 1) > 127u)
					{
						result = num2;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = Width - 1 + 127;
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_NEG.Pointer, 1L, isVolatile: false);
						int field_3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: num3, Sign: anon_izyfb3.Val, Mantissa: 0);
						fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
						float num6 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
						Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						num4 = num6;
						if (num2 < num4)
						{
							Fputil_raise_except_if_required.Invoke(1);
							Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb4.Val, 0);
							fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
							result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
							Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(4L, &num5);
							Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_5 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_create_value.Invoke(Biased_exp: num3, Sign: anon_izyfb5.Val, Mantissa: 0);
							fputil_FPBits_5nkvcs6.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
							float num7 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6) - 1f;
							Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
							num5 = num7;
							if (num2 > num5)
							{
								Fputil_raise_except_if_required.Invoke(1);
								Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Sign_POS.Pointer, 1L, isVolatile: false);
								int field_6 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb6.Val, 0);
								fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
								result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
								Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
							}
							else
							{
								result = num2;
							}
							Llvm_lifetime_end_p0.Invoke(4L, &num5);
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num4);
						Llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
