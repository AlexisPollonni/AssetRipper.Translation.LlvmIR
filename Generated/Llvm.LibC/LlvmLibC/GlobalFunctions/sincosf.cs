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
		double xd = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		sbyte b = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		double num5 = 0.0;
		double num6 = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(8L, &xd);
			xd = x;
			int num7;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num < 964689920u, expected: false))
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == 0, expected: false))
				{
					*(float*)sinp = x;
					*(float*)cosp = 1f;
					num7 = 1;
				}
				else
				{
					*(float*)sinp = fputil_multiply_add_float_float_float.Invoke(x, -2.9802322E-08f, x);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, num);
					*(float*)cosp = fputil_multiply_add_float_float_float.Invoke(fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3), -2.9802322E-08f, 1f);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					num7 = 1;
				}
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 2139095040u, expected: false))
			{
				if (num == 2139095040)
				{
					fputil_set_errno_if_required_int.Invoke(33);
					fputil_raise_except_if_required_int.Invoke(1);
				}
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb8.val, 0);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				*(float*)sinp = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				*(float*)cosp = *(float*)sinp;
				num7 = 1;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				while (true)
				{
					if (num2 >= 6)
					{
						num7 = 2;
						break;
					}
					int num8 = num;
					long num9 = num2;
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num8 == ((int*)EXCEPT_INPUTS.Pointer)[num9], expected: false))
					{
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						long num10 = num2;
						num3 = *(int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num10 * sizeof(InlineArray4_Int32));
						llvm_lifetime_start_p0.Invoke(4L, &num4);
						long num11 = num2;
						num4 = *(int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num11 * sizeof(InlineArray4_Int32));
						llvm_lifetime_start_p0.Invoke(1L, &b);
						b = ((x < 0f) ? ((sbyte)1) : ((sbyte)0));
						switch (fputil_quick_get_round.Invoke())
						{
						case 2048:
						{
							int num22;
							if ((b & 1) == 1)
							{
								long num21 = num2;
								num22 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num21 * sizeof(InlineArray4_Int32)))[2];
							}
							else
							{
								long num23 = num2;
								num22 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num23 * sizeof(InlineArray4_Int32)))[1];
							}
							num3 += num22;
							long num24 = num2;
							int num25 = ((int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num24 * sizeof(InlineArray4_Int32)))[1];
							num4 += num25;
							break;
						}
						case 1024:
						{
							int num17;
							if ((b & 1) == 1)
							{
								long num16 = num2;
								num17 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num16 * sizeof(InlineArray4_Int32)))[1];
							}
							else
							{
								long num18 = num2;
								num17 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num18 * sizeof(InlineArray4_Int32)))[2];
							}
							num3 += num17;
							long num19 = num2;
							int num20 = ((int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num19 * sizeof(InlineArray4_Int32)))[2];
							num4 += num20;
							break;
						}
						case 0:
						{
							long num12 = num2;
							int num13 = ((int*)((byte*)EXCEPT_OUTPUTS_SIN.Pointer + (nint)num12 * sizeof(InlineArray4_Int32)))[3];
							num3 += num13;
							long num14 = num2;
							int num15 = ((int*)((byte*)EXCEPT_OUTPUTS_COS.Pointer + (nint)num14 * sizeof(InlineArray4_Int32)))[3];
							num4 += num15;
							break;
						}
						}
						bool num26 = (b & 1) == 1;
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						float num27;
						if (num26)
						{
							fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs5, num3);
							num27 = 0f - fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
						}
						else
						{
							fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs6, num3);
							num27 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6);
						}
						*(float*)sinp = num27;
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
						fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs7, num4);
						*(float*)cosp = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs7);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
						num7 = 1;
						llvm_lifetime_end_p0.Invoke(1L, &b);
						llvm_lifetime_end_p0.Invoke(4L, &num4);
						llvm_lifetime_end_p0.Invoke(4L, &num3);
						break;
					}
					num2 = checked(num2 + 1);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num2);
				if (num7 == 2)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = double.NaN;
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = double.NaN;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = double.NaN;
					llvm_lifetime_start_p0.Invoke(8L, &x3);
					x3 = double.NaN;
					sincosf_eval_double_unsigned_int_double_double_double_double.Invoke(xd, num, &num5, &num6, &x2, &x3);
					*(float*)sinp = (float)fputil_multiply_add_double_double_double.Invoke(x2, num6, fputil_multiply_add_double_double_double.Invoke(x3, num5, num5));
					*(float*)cosp = (float)fputil_multiply_add_double_double_double.Invoke(x2, 0.0 - num5, fputil_multiply_add_double_double_double.Invoke(x3, num6, num6));
					llvm_lifetime_end_p0.Invoke(8L, &x3);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
					num7 = 0;
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &xd);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			switch (num7)
			{
			case 0:
			case 1:
				return;
			}
			throw new NotImplementedException("Reached LLVM unreachable instruction.");
		}
	}
}
