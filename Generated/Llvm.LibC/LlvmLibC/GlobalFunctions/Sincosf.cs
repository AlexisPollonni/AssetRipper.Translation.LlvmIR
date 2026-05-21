using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sincosf
{
	[MangledName("sincosf")]
	[DemangledName("sincosf")]
	public unsafe static void Invoke([MangledName("x")] float X, [MangledName("sinp")] void* Sinp, [MangledName("cosp")] void* Cosp)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		double num2 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		sbyte b = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		double num6 = 0.0;
		double num7 = 0.0;
		double x = 0.0;
		double x2 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = X;
			int num8;
			if (Details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke(num == 0, Expected: false))
				{
					*(float*)Sinp = X;
					*(float*)Cosp = 1f;
					num8 = 1;
				}
				else
				{
					*(float*)Sinp = (float)Fputil_multiply_add_double.Invoke(num2, -2.980232238769531E-08, num2);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, num);
					*(float*)Cosp = (float)Fputil_multiply_add_double.Invoke(FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2), -2.980232238769531E-08, 1.0);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					num8 = 1;
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, Expected: false))
			{
				if (num == 2139095040)
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				*(float*)Sinp = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				*(float*)Cosp = *(float*)Sinp;
				num8 = 1;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 0;
				while (true)
				{
					if (num3 >= 6)
					{
						num8 = 2;
						break;
					}
					int num9 = num;
					long num10 = num3;
					if (Details_expects_bool_condition_bool.Invoke(num9 == ((int*)Llvm_libc_20_1_2_EXCEPT_INPUTS.Pointer)[num10], Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						long num11 = num3;
						num4 = *(int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_SIN.Pointer + (nint)num11 * sizeof(InlineArray4_Int32));
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						long num12 = num3;
						num5 = *(int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_COS.Pointer + (nint)num12 * sizeof(InlineArray4_Int32));
						Llvm_lifetime_start_p0.Invoke(1L, &b);
						b = ((X < 0f) ? ((sbyte)1) : ((sbyte)0));
						switch (Fputil_quick_get_round.Invoke())
						{
						case 2048:
						{
							int num23;
							if ((b & 1) == 1)
							{
								long num22 = num3;
								num23 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_SIN.Pointer + (nint)num22 * sizeof(InlineArray4_Int32)))[2];
							}
							else
							{
								long num24 = num3;
								num23 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_SIN.Pointer + (nint)num24 * sizeof(InlineArray4_Int32)))[1];
							}
							num4 += num23;
							long num25 = num3;
							int num26 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_COS.Pointer + (nint)num25 * sizeof(InlineArray4_Int32)))[1];
							num5 += num26;
							break;
						}
						case 1024:
						{
							int num18;
							if ((b & 1) == 1)
							{
								long num17 = num3;
								num18 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_SIN.Pointer + (nint)num17 * sizeof(InlineArray4_Int32)))[1];
							}
							else
							{
								long num19 = num3;
								num18 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_SIN.Pointer + (nint)num19 * sizeof(InlineArray4_Int32)))[2];
							}
							num4 += num18;
							long num20 = num3;
							int num21 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_COS.Pointer + (nint)num20 * sizeof(InlineArray4_Int32)))[2];
							num5 += num21;
							break;
						}
						case 0:
						{
							long num13 = num3;
							int num14 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_SIN.Pointer + (nint)num13 * sizeof(InlineArray4_Int32)))[3];
							num4 += num14;
							long num15 = num3;
							int num16 = ((int*)((byte*)Llvm_libc_20_1_2_EXCEPT_OUTPUTS_COS.Pointer + (nint)num15 * sizeof(InlineArray4_Int32)))[3];
							num5 += num16;
							break;
						}
						}
						bool num27 = (b & 1) == 1;
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
						float num28;
						if (num27)
						{
							FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, num4);
							num28 = 0f - FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
						}
						else
						{
							FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, num4);
							num28 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
						}
						*(float*)Sinp = num28;
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
						FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6, num5);
						*(float*)Cosp = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
						num8 = 1;
						Llvm_lifetime_end_p0.Invoke(1L, &b);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						Llvm_lifetime_end_p0.Invoke(4L, &num4);
						break;
					}
					num3 = checked(num3 + 1);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				if (num8 == 2)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = double.NaN;
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = double.NaN;
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = double.NaN;
					Llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = double.NaN;
					Llvm_libc_20_1_2_sincosf_eval.Invoke(num2, num, &num6, &num7, &x, &x2);
					*(float*)Sinp = (float)Fputil_multiply_add_double.Invoke(x, num7, Fputil_multiply_add_double.Invoke(x2, num6, num6));
					*(float*)Cosp = (float)Fputil_multiply_add_double.Invoke(x, 0.0 - num6, Fputil_multiply_add_double.Invoke(x2, num7, num7));
					Llvm_lifetime_end_p0.Invoke(8L, &x2);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
					num8 = 0;
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			switch (num8)
			{
			case 0:
			case 1:
				return;
			}
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
