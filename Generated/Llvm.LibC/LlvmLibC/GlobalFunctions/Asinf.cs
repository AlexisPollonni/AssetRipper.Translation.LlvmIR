using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Asinf
{
	[MangledName("asinf")]
	[DemangledName("asinf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		int num3 = 0;
		double num4 = 0.0;
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		double num5 = 0.0;
		double num6 = 0.0;
		double x = 0.0;
		double y = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi2 = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num7 = 0.0;
		double y2 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double z = 0.0;
		double x2 = 0.0;
		double y3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)) & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
			*(double*)(&inlineArray2_Double) = 1.0;
			((double*)(&inlineArray2_Double))[1] = -1.0;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num >>> 31;
			if ((uint)num2 < 1057244957u)
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num2 < 971544424u, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = X;
					result = (float)Fputil_multiply_add_double.Invoke(num4, 2.980232238769531E-08, num4);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
					*(float*)ptr = float.NaN;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = ExceptValues_float_2ul_lookup_odd.Invoke(X_abs: num2, Sign: num3 != 0, This: Llvm_libc_20_1_2_ASINF_EXCEPTS_LO.Pointer);
					*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi.Storage) = storage;
					int num10;
					if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi), Expected: false))
					{
						result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
						num10 = 1;
					}
					else
					{
						num10 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi);
					switch (num10)
					{
					case 0:
						Llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = X;
						Llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = num5 * num5;
						Llvm_lifetime_start_p0.Invoke(8L, &x);
						x = num5 * num6;
						Llvm_lifetime_start_p0.Invoke(8L, &y);
						y = Llvm_libc_20_1_2_asin_eval_bsihag.Invoke(num6);
						result = (float)Fputil_multiply_add_double.Invoke(x, y, num5);
						Llvm_lifetime_end_p0.Invoke(8L, &y);
						Llvm_lifetime_end_p0.Invoke(8L, &x);
						Llvm_lifetime_end_p0.Invoke(8L, &num6);
						Llvm_lifetime_end_p0.Invoke(8L, &num5);
						break;
					}
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num2 > 1065353216u, Expected: false))
			{
				if ((uint)num2 <= 2139095040u)
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				*(float*)ptr3 = float.NaN;
				ptr3[4] = -86;
				sbyte* ptr4 = ptr3 + 5;
				*ptr4 = -86;
				ptr4[1] = -86;
				ptr4[2] = -86;
				long storage2 = ExceptValues_float_2ul_lookup_odd.Invoke(X_abs: num2, Sign: num3 != 0, This: Llvm_libc_20_1_2_ASINF_EXCEPTS_HI.Pointer);
				*(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi2.Storage) = storage2;
				int num10;
				if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi2), Expected: false))
				{
					result = *(float*)Optional_float_value.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi2);
					num10 = 1;
				}
				else
				{
					num10 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_xmxtsi2);
				switch (num10)
				{
				case 0:
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					FPStorage_fputil_FPType_1_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, anon_izyfb2.Val);
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (nint)(uint)num3 * (nint)sizeof(double)));
					Llvm_lifetime_start_p0.Invoke(8L, &y2);
					y2 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					Llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = Fputil_multiply_add_double.Invoke(-0.5, y2, 0.5);
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = num7 * (-2.0 * Fputil_sqrt_double_double.Invoke(num8));
					Llvm_lifetime_start_p0.Invoke(8L, &z);
					z = Fputil_multiply_add_double.Invoke(num7, Math.PI / 2.0, num9);
					Llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num9 * num8;
					Llvm_lifetime_start_p0.Invoke(8L, &y3);
					y3 = Llvm_libc_20_1_2_asin_eval_bsihag.Invoke(num8);
					result = (float)Fputil_multiply_add_double.Invoke(x2, y3, z);
					Llvm_lifetime_end_p0.Invoke(8L, &y3);
					Llvm_lifetime_end_p0.Invoke(8L, &x2);
					Llvm_lifetime_end_p0.Invoke(8L, &z);
					Llvm_lifetime_end_p0.Invoke(8L, &num9);
					Llvm_lifetime_end_p0.Invoke(8L, &num8);
					Llvm_lifetime_end_p0.Invoke(8L, &y2);
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
					break;
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
