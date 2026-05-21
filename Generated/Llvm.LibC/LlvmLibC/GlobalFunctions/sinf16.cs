using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class sinf16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		sbyte b = 0;
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		int num3 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		float num4 = 0f;
		float y = 0f;
		float num5 = 0f;
		float x2 = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)x;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((ushort)num >> 15 != 0) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
			sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
			*(Half*)ptr = default(Half);
			ptr[2] = -86;
			ptr[3] = -86;
			int storage = ExceptValues_Float16_4ul_lookup_odd.Invoke(x_abs: num2, sign: (b & 1) == 1, @this: SINF16_EXCEPTS.Pointer);
			*(int*)(&cpp_optional_aq7wey2.storage) = storage;
			int num6;
			if (details_expects_bool_condition_bool.Invoke(optional_Float16_has_value.Invoke(&cpp_optional_aq7wey2), expected: false))
			{
				result = *(Half*)optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
				num6 = 1;
			}
			else
			{
				num6 = 0;
			}
			llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
			switch (num6)
			{
			case 0:
				{
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = fputil_quick_get_round.Invoke();
					if (!details_expects_bool_condition_bool.Invoke((ushort)num2 <= 5072, expected: false))
					{
						goto IL_028a;
					}
					if (details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, expected: false))
					{
						result = x;
					}
					else if ((num3 == 2048 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) || (num3 == 1024 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))))
					{
						result = x;
					}
					else
					{
						if (num3 != 2048 || !FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)))
						{
							goto IL_028a;
						}
						num += -1;
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva3, num);
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
					goto IL_0486;
				}
				IL_028a:
				if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)))
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
					}
					float num7 = (float)x;
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb8.val, 0);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num7 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4));
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &y);
					y = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = float.NaN;
					llvm_lifetime_start_p0.Invoke(4L, &x2);
					x2 = float.NaN;
					sincosf16_eval.Invoke(xf, &num4, &y, &num5, &x2);
					if (details_expects_bool_condition_bool.Invoke(num5 == 0f && num4 == 0f, expected: false))
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						anon_izyfb9.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
						short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb9.val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						result = fputil_cast_Float16_float.Invoke(fputil_multiply_add_float.Invoke(num5, y, fputil_multiply_add_float.Invoke(x2, num4, num4)));
					}
					llvm_lifetime_end_p0.Invoke(4L, &x2);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					llvm_lifetime_end_p0.Invoke(4L, &y);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				goto IL_0486;
				IL_0486:
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				break;
			}
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &xf);
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
