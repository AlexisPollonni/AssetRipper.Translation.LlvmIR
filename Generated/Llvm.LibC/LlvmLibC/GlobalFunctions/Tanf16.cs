using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tanf16
{
	[MangledName("tanf16")]
	[DemangledName("tanf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		sbyte b = 0;
		float num3 = 0f;
		Llvm_libc_20_1_2_cpp_optional_aq7wey llvm_libc_20_1_2_cpp_optional_aq7wey = default(Llvm_libc_20_1_2_cpp_optional_aq7wey);
		int num4 = 0;
		float x = 0f;
		float num5 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		float num6 = 0f;
		float num7 = 0f;
		float x2 = 0f;
		float x3 = 0f;
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((ushort)num >> 15 != 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (float)X;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_cpp_optional_aq7wey);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_aq7wey);
			*(Half*)ptr = default(Half);
			ptr[2] = -86;
			ptr[3] = -86;
			int storage = ExceptValues_Float16_9ul_lookup_odd.Invoke(X_abs: num2, Sign: (b & 1) == 1, This: Llvm_libc_20_1_2_TANF16_EXCEPTS.Pointer);
			*(int*)(&llvm_libc_20_1_2_cpp_optional_aq7wey.Storage) = storage;
			int num8;
			if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_aq7wey), Expected: false))
			{
				result = *(Half*)Optional_Float16_value.Invoke(&llvm_libc_20_1_2_cpp_optional_aq7wey);
				num8 = 1;
			}
			else
			{
				num8 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_cpp_optional_aq7wey);
			switch (num8)
			{
			case 0:
				if (Details_expects_bool_condition_bool.Invoke((ushort)num2 <= 11076, Expected: false))
				{
					if (Details_expects_bool_condition_bool.Invoke((ushort)num2 <= 4326, Expected: false))
					{
						if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
						{
							result = X;
							break;
						}
						Llvm_lifetime_start_p0.Invoke(4L, &num4);
						num4 = Fputil_quick_get_round.Invoke();
						result = (((!FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) || num4 != 2048) && (!FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) || num4 != 1024)) ? X : Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(num3, 0.00048828125f, num3)));
						Llvm_lifetime_end_p0.Invoke(4L, &num4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &x);
						x = num3 * num3;
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = Fputil_polyeval_float_float_float_float.Invoke(x, 1f, 1f / 3f, 0.13332918f, 0.054504853f);
						result = Fputil_cast_Float16_float.Invoke(num3 * num5);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						Llvm_lifetime_end_p0.Invoke(4L, &x);
					}
				}
				else if (Details_expects_bool_condition_bool.Invoke((ushort)num2 >= 31744, Expected: false))
				{
					if ((ushort)num2 == 31744)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					float num9 = (float)X;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num9 + (float)FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2));
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &x2);
					x2 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &x3);
					x3 = float.NaN;
					Llvm_libc_20_1_2_sincosf16_eval.Invoke(num3, &num6, &num7, &x2, &x3);
					result = Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(x2, num7, Fputil_multiply_add_float.Invoke(x3, num6, num6)) / Fputil_multiply_add_float.Invoke(x2, 0f - num6, Fputil_multiply_add_float.Invoke(x3, num7, num7)));
					Llvm_lifetime_end_p0.Invoke(4L, &x3);
					Llvm_lifetime_end_p0.Invoke(4L, &x2);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			return result;
		}
	}
}
