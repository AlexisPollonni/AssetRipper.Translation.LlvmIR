using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tanhf16
{
	public unsafe static Half Invoke(Half x)
	{
		Half result = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		float num3 = 0f;
		float x2 = 0f;
		fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num4 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		float num5 = 0f;
		float num6 = 0f;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		float x3 = 0f;
		int x4 = 0;
		float num10 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		float num11 = 0f;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (details_expects_bool_condition_bool.Invoke(((uint)(ushort)num2 > 12104u) ? ((uint)(ushort)num2 >= 17449u) : true, expected: false))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
					{
						fputil_raise_except_if_required.Invoke(1);
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb8.val, 0);
						fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
					else
					{
						result = x;
					}
				}
				else if ((uint)(ushort)num >= 33792u && (uint)(ushort)num <= 38912u)
				{
					int num12 = fputil_quick_get_round.Invoke();
					if (num12 == 0 || num12 == 1024)
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva4, (short)((ushort)num - 1));
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
				}
				else if ((uint)(ushort)num2 <= 12104u)
				{
					if (details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, expected: false))
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = (float)x;
						llvm_lifetime_start_p0.Invoke(4L, &x2);
						x2 = num3 * num3;
						result = fputil_cast_Float16_float.Invoke(num3 * fputil_polyeval_float_float_float_float.Invoke(x2, 1f, -1f / 3f, 2f / 15f, -0.053968254f));
						llvm_lifetime_end_p0.Invoke(4L, &x2);
						llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
				}
				else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					anon_izyfb9.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb9.val);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				}
				else
				{
					fputil_raise_except_if_required.Invoke(32);
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = fputil_quick_get_round.Invoke();
					if ((num4 == 0 && (uint)(ushort)num2 >= 17538u) || (num4 == 2048 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) || (num4 == 1024 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))))
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						anon_izyfb10.val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva2);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb10.val);
						fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					}
					else
					{
						result = ((!FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2))) ? fputil_cast_Float16_double.Invoke(-0.99951171875) : fputil_cast_Float16_double.Invoke(0.99951171875));
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey2);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = ExceptValues_Float16_2ul_lookup.Invoke(x_bits: num, @this: TANHF16_EXCEPTS.Pointer);
				*(int*)(&cpp_optional_aq7wey2.storage) = storage;
				int num13;
				if (details_expects_bool_condition_bool.Invoke(optional_Float16_has_value.Invoke(&cpp_optional_aq7wey2), expected: false))
				{
					result = *(Half*)optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
					num13 = 1;
				}
				else
				{
					num13 = 0;
				}
				llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
				switch (num13)
				{
				case 0:
				{
					llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = (float)x;
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = fputil_nearest_integer.Invoke(num5 * 92.33248f);
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					checked
					{
						num7 = -unchecked((int)num6);
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = num7 >>> 5;
						llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = num7 & 0x1F;
						llvm_lifetime_start_p0.Invoke(4L, &x3);
						x3 = fputil_multiply_add_float.Invoke(num6, -0.010830425f, num5);
						llvm_lifetime_start_p0.Invoke(4L, &x4);
					}
					x4 = *(int*)array_unsigned_int_32ul_Index.Invoke(Index: (uint)num9, @this: EXP2_MID_5_BITS.Pointer) + (num8 << 23);
					llvm_lifetime_start_p0.Invoke(4L, &num10);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x4);
					float num14 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					num10 = num14;
					llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = fputil_polyeval_float_float_float_float.Invoke(x3, 1f, 2f, 2.0004883f, 1.3334635f);
					result = fputil_cast_Float16_float.Invoke((num11 - num10) / (num11 + num10));
					llvm_lifetime_end_p0.Invoke(4L, &num11);
					llvm_lifetime_end_p0.Invoke(4L, &num10);
					llvm_lifetime_end_p0.Invoke(4L, &x4);
					llvm_lifetime_end_p0.Invoke(4L, &x3);
					llvm_lifetime_end_p0.Invoke(4L, &num9);
					llvm_lifetime_end_p0.Invoke(4L, &num8);
					llvm_lifetime_end_p0.Invoke(4L, &num7);
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					llvm_lifetime_end_p0.Invoke(4L, &num5);
					break;
				}
				}
			}
			llvm_lifetime_end_p0.Invoke(2L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
