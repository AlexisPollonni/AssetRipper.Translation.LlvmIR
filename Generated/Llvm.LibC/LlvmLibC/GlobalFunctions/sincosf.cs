using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sincosf
{
	public unsafe static void Invoke(float x, void* sinp, void* cosp)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		double num2 = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		sbyte b = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		double num6 = 0.0;
		double num7 = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = x;
			int num8;
			if (details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke(num == 0, expected: false))
				{
					*(float*)sinp = x;
					*(float*)cosp = 1f;
					num8 = 1;
				}
				else
				{
					*(float*)sinp = (float)fputil_multiply_add_double.Invoke(num2, -2.980232238769531E-08, num2);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, num);
					*(float*)cosp = (float)fputil_multiply_add_double.Invoke(FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3), -2.980232238769531E-08, 1.0);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					num8 = 1;
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, expected: false))
			{
				if (num == 2139095040)
				{
					fputil_set_errno_if_required.Invoke(33);
					fputil_raise_except_if_required.Invoke(1);
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				*(float*)sinp = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				*(float*)cosp = *(float*)sinp;
				num8 = 1;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
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
					if (details_expects_bool_condition_bool.Invoke(num9 == ((int*)EXCEPT_INPUTS.Pointer)[num10], expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						long num11 = num3;
						num4 = *(int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num11 * sizeof(InlineArray4_Int32));
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						long num12 = num3;
						num5 = *(int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num12 * sizeof(InlineArray4_Int32));
						llvm_lifetime_start_p0.Invoke(1L, &b);
						b = ((x < 0f) ? ((sbyte)1) : ((sbyte)0));
						switch (fputil_quick_get_round.Invoke())
						{
						case 2048:
						{
							int num23;
							if ((b & 1) == 1)
							{
								long num22 = num3;
								num23 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num22 * sizeof(InlineArray4_Int32)))[2];
							}
							else
							{
								long num24 = num3;
								num23 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num24 * sizeof(InlineArray4_Int32)))[1];
							}
							num4 += num23;
							long num25 = num3;
							int num26 = ((int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num25 * sizeof(InlineArray4_Int32)))[1];
							num5 += num26;
							break;
						}
						case 1024:
						{
							int num18;
							if ((b & 1) == 1)
							{
								long num17 = num3;
								num18 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num17 * sizeof(InlineArray4_Int32)))[1];
							}
							else
							{
								long num19 = num3;
								num18 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num19 * sizeof(InlineArray4_Int32)))[2];
							}
							num4 += num18;
							long num20 = num3;
							int num21 = ((int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num20 * sizeof(InlineArray4_Int32)))[2];
							num5 += num21;
							break;
						}
						case 0:
						{
							long num13 = num3;
							int num14 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num13 * sizeof(InlineArray4_Int32)))[3];
							num4 += num14;
							long num15 = num3;
							int num16 = ((int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num15 * sizeof(InlineArray4_Int32)))[3];
							num5 += num16;
							break;
						}
						}
						bool num27 = (b & 1) == 1;
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						float num28;
						if (num27)
						{
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, num4);
							num28 = 0f - FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs5);
						}
						else
						{
							FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs6, num4);
							num28 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
						}
						*(float*)sinp = num28;
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
						FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs7, num5);
						*(float*)cosp = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
						num8 = 1;
						llvm_lifetime_end_p0.Invoke(1L, &b);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
						llvm_lifetime_end_p0.Invoke(4L, &num4);
						break;
					}
					num3 = checked(num3 + 1);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				if (num8 == 2)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = double.NaN;
					llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = double.NaN;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = double.NaN;
					llvm_lifetime_start_p0.Invoke(8L, &x3);
					x3 = double.NaN;
					sincosf_eval.Invoke(num2, num, &num6, &num7, &x2, &x3);
					*(float*)sinp = (float)fputil_multiply_add_double.Invoke(x2, num7, fputil_multiply_add_double.Invoke(x3, num6, num6));
					*(float*)cosp = (float)fputil_multiply_add_double.Invoke(x2, 0.0 - num6, fputil_multiply_add_double.Invoke(x3, num7, num7));
					llvm_lifetime_end_p0.Invoke(8L, &x3);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &num7);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
					num8 = 0;
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
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
