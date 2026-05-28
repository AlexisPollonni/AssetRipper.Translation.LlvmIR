using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Log2f16
{
	[MangledName("log2f16")]
	[DemangledName("log2f16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		int num2 = 0;
		float num3 = 0f;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(Fputil_FPBits_2fahva);
		short num4 = 0;
		int num5 = 0;
		float x = 0f;
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			if (Details_expects_bool_condition_bool.Invoke((ushort)num == 0 || (ushort)num == 15360 || (uint)(ushort)num >= 31744u, Expected: false))
			{
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
					{
						Fputil_raise_except_if_required.Invoke(1);
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
						short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
						fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					}
					else
					{
						result = X;
					}
				}
				else if (((ushort)num & 0x7FFF) == 0)
				{
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_NEG.Pointer, 1L, isVolatile: false);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb2.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else if ((ushort)num == 15360)
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb3.Val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else if ((uint)(ushort)num > 32768u)
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb4.Val, 0);
					fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb5.Val);
					fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = ExceptValues_Float16_9ul_lookup.Invoke(X_bits: num, This: LOG2F16_EXCEPTS.Pointer);
				*(int*)(&cpp_optional_aq7wey.Storage) = storage;
				int num9;
				if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey), Expected: false))
				{
					result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey);
					num9 = 1;
				}
				else
				{
					num9 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey);
				switch (num9)
				{
				case 0:
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = -15;
					if (((ushort)num & 0x7C00) == 0)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = 1024f;
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva7, (Half)((float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva) * (float)Fputil_cast_Float16_float.Invoke(1024f)));
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva7, 2L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
						num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
						num2 = checked(num2 - 10);
						Llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
					Llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = (ushort)num4 >> 5;
					checked
					{
						num2 += unchecked((ushort)num) >> 10;
					}
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva), 15);
					Llvm_lifetime_start_p0.Invoke(4L, &x);
					x = (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = Fputil_multiply_add_float.Invoke(x, *(float*)Array_float_32ul_Index.Invoke(Index: num5, This: ONE_OVER_F_F_9.Pointer), -1f);
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = num6 * Fputil_polyeval_float_float_float.Invoke(num6, 1.442695f, -0.7216118f, 0.4811537f);
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = *(float*)Array_float_32ul_Index.Invoke(Index: num5, This: LOG2F_F.Pointer) + num7;
					result = Fputil_cast_Float16_float.Invoke((float)num2 + num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(4L, &x);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					Llvm_lifetime_end_p0.Invoke(2L, &num4);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
					break;
				}
			}
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
