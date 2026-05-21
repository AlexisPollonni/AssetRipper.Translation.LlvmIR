using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class hypotf
{
	public unsafe static float Invoke(float x, float y)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num8 = 0L;
		double num9 = 0.0;
		NumberPair numberPair = default(NumberPair);
		double num10 = 0.0;
		double num11 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, x);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
			fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			*(int*)(&fputil_FPBits_5nkvcs4) = -1431655766;
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs5, y);
			int field_2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs5));
			fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) >= (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs4))) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
			*(int*)(&fputil_FPBits_5nkvcs6) = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs6, Unsafe.AsPointer(ref (b & 1) != 1 ? ref fputil_FPBits_5nkvcs4 : ref fputil_FPBits_5nkvcs2), 4L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
			*(int*)(&fputil_FPBits_5nkvcs7) = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs7, Unsafe.AsPointer(ref (b & 1) != 1 ? ref fputil_FPBits_5nkvcs2 : ref fputil_FPBits_5nkvcs4), 4L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs6));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs7));
			float result;
			if (details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs6) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs7))
				{
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs8);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs6) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs7))
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb9.val);
					fputil_FPBits_5nkvcs9.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs9);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
				}
				else
				{
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)(num - num2) >= 209715200u, expected: false))
			{
				result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2) + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs6);
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs7);
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = num3 * num3;
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = num4 * num4;
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = num5 + num6;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, fputil_sqrt_double_double.Invoke(num7));
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				if (details_expects_bool_condition_bool.Invoke(((num8 + 1L) & 0xFFFFFFEL) == 0L, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_start_p0.Invoke(16L, &numberPair);
					*(double*)(&numberPair) = double.NaN;
					((double*)(&numberPair))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja = fputil_exact_mult_27ul.Invoke(num9, num9);
					NumberPair* num12 = &numberPair;
					Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
					*(double*)num12 = struct_4ydhja2.field_0;
					byte* num13 = (byte*)(&numberPair) + 8u;
					Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
					*(double*)num13 = struct_4ydhja3.field_1;
					llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = num6 - (num7 - num5);
					llvm_lifetime_start_p0.Invoke(8L, &num11);
					num11 = num7 - numberPair.hi + (num10 - numberPair.lo);
					if (num11 > 0.0)
					{
						num8 |= 1L;
					}
					else if (num11 < 0.0 && (num8 & 1L) == 0L)
					{
						num8--;
					}
					else if ((num8 & 0x1FFFFFFFL) == 0L)
					{
						fputil_clear_except_if_required.Invoke(32);
					}
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, num8);
					result = (float)FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &num11);
					llvm_lifetime_end_p0.Invoke(8L, &num10);
					llvm_lifetime_end_p0.Invoke(16L, &numberPair);
					llvm_lifetime_end_p0.Invoke(8L, &num9);
				}
				else
				{
					result = (float)FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
