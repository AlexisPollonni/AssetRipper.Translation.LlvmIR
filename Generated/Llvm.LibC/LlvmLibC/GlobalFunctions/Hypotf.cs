using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Hypotf
{
	[MangledName("hypotf")]
	[DemangledName("hypotf")]
	public unsafe static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		sbyte b = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs7 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs8 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num8 = 0L;
		double num9 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num10 = 0.0;
		double num11 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, X);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3) = -1431655766;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, Y);
			int field_2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) >= (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3))) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5) = -1431655766;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, Unsafe.AsPointer(ref (b & 1) != 1 ? ref llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 : ref llvm_libc_20_1_2_fputil_FPBits_5nkvcs), 4L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6) = -1431655766;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6, Unsafe.AsPointer(ref (b & 1) != 1 ? ref llvm_libc_20_1_2_fputil_FPBits_5nkvcs : ref llvm_libc_20_1_2_fputil_FPBits_5nkvcs3), 4L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6));
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, Expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs7.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs8.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
				}
				else
				{
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)(num - num2) >= 209715200u, Expected: false))
			{
				result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = num3 * num3;
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = num4 * num4;
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = num5 + num6;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, Fputil_sqrt_double_double.Invoke(num7));
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				if (Details_expects_bool_condition_bool.Invoke(((num8 + 1L) & 0xFFFFFFEL) == 0L, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
					*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
					((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
					Struct_4ydhja struct_4ydhja = Fputil_exact_mult_27ul.Invoke(num9, num9);
					Llvm_libc_20_1_2_NumberPair* num12 = &llvm_libc_20_1_2_NumberPair;
					Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
					*(double*)num12 = struct_4ydhja2.field_0;
					byte* num13 = (byte*)(&llvm_libc_20_1_2_NumberPair) + 8u;
					Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
					*(double*)num13 = struct_4ydhja3.field_1;
					Llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = num6 - (num7 - num5);
					Llvm_lifetime_start_p0.Invoke(8L, &num11);
					num11 = num7 - llvm_libc_20_1_2_NumberPair.Hi + (num10 - llvm_libc_20_1_2_NumberPair.Lo);
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
						Fputil_clear_except_if_required.Invoke(32);
					}
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, num8);
					result = (float)FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &num11);
					Llvm_lifetime_end_p0.Invoke(8L, &num10);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
				}
				else
				{
					result = (float)FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
