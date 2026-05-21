using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expf
{
	[MangledName("expf")]
	[DemangledName("expf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		float num4 = 0f;
		double x = 0.0;
		int num5 = 0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (Details_expects_bool_condition_bool.Invoke(num == -1036599924, Expected: false))
			{
				result = Llvm_fmuladd_f32.Invoke(0f - X, 2.524355E-29f, 1.4428169E-20f);
			}
			else
			{
				if (!Details_expects_bool_condition_bool.Invoke(((uint)num2 < 1118961664u) ? ((uint)num2 <= 847249408u) : true, Expected: false))
				{
					goto IL_03ab;
				}
				if ((ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) <= 101)
				{
					result = 1f + X;
				}
				else if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) >= 3268407733u)
				{
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
					{
						result = 0f;
					}
					else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
					{
						result = X;
					}
					else if (Fputil_fenv_is_round_up.Invoke())
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal.Invoke(anon_izyfb.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					}
					else
					{
						Fputil_set_errno_if_required.Invoke(34);
						Fputil_raise_except_if_required.Invoke(16);
						result = 0f;
					}
				}
				else
				{
					if (!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) || (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) < 1118961664u)
					{
						goto IL_03ab;
					}
					if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) < 2139095040u)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = Fputil_quick_get_round.Invoke();
						int num9;
						if (num3 == 1024 || num3 == 3072)
						{
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb2.Val);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
							result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
							num9 = 1;
						}
						else
						{
							Fputil_set_errno_if_required.Invoke(34);
							Fputil_raise_except_if_required.Invoke(8);
							num9 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num3);
						switch (num9)
						{
						case 0:
							break;
						default:
							goto IL_0518;
						}
					}
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
				}
			}
			goto IL_0518;
		}
		IL_03ab:
		Llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = Fputil_nearest_integer.Invoke(X * 128f);
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = Fputil_multiply_add_float.Invoke(num4, -1f / 128f, X);
		Llvm_lifetime_start_p0.Invoke(4L, &num5);
		num5 = unchecked((int)num4);
		num5 += 13312;
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		long num10 = num5 >> 7;
		unchecked
		{
			num6 = ((double*)Llvm_libc_20_1_2_EXP_M1.Pointer)[num10];
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			long num11 = num5 & 0x7F;
			num7 = ((double*)Llvm_libc_20_1_2_EXP_M2.Pointer)[num11];
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = Fputil_polyeval_double_double_double_double_double.Invoke(x, 1.0, 0.9999999999997574, 0.5000000000002021, 0.16666679382778612, 0.041666666671038154);
			result = (float)(num6 * num7 * num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			goto IL_0518;
		}
		IL_0518:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
	}
}
