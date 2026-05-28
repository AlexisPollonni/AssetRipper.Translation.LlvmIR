using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tanhf16
{
	[MangledName("tanhf16")]
	[DemangledName("tanhf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		float num3 = 0f;
		float x = 0f;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num4 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		float num5 = 0f;
		float num6 = 0f;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		float x2 = 0f;
		int x3 = 0;
		float num10 = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		float num11 = 0f;
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (Details_expects_bool_condition_bool.Invoke((uint)(ushort)num2 <= 12104u || (uint)(ushort)num2 >= 17449u, Expected: false))
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
				else if ((uint)(ushort)num >= 33792u && (uint)(ushort)num <= 38912u)
				{
					int num12 = Fputil_quick_get_round.Invoke();
					if (num12 == 0 || num12 == 1024)
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva3, (short)((ushort)num - 1));
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
				}
				else if ((uint)(ushort)num2 <= 12104u)
				{
					if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = (float)X;
						Llvm_lifetime_start_p0.Invoke(4L, &x);
						x = num3 * num3;
						result = Fputil_cast_Float16_float.Invoke(num3 * Fputil_polyeval_float_float_float_float.Invoke(x, 1f, -1f / 3f, 2f / 15f, -0.053968254f));
						Llvm_lifetime_end_p0.Invoke(4L, &x);
						Llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
				}
				else if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					anon_izyfb2.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb2.Val);
					fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				}
				else
				{
					Fputil_raise_except_if_required.Invoke(32);
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = Fputil_quick_get_round.Invoke();
					if ((num4 == 0 && (uint)(ushort)num2 >= 17538u) || (num4 == 2048 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) || (num4 == 1024 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))))
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						anon_izyfb3.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_one.Invoke(anon_izyfb3.Val);
						fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
					}
					else
					{
						result = ((!FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) ? Fputil_cast_Float16_double.Invoke(-0.99951171875) : Fputil_cast_Float16_double.Invoke(0.99951171875));
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey);
				sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey);
				*(Half*)ptr = default(Half);
				ptr[2] = -86;
				ptr[3] = -86;
				int storage = ExceptValues_Float16_2ul_lookup.Invoke(X_bits: num, This: TANHF16_EXCEPTS.Pointer);
				*(int*)(&cpp_optional_aq7wey.Storage) = storage;
				int num13;
				if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey), Expected: false))
				{
					result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey);
					num13 = 1;
				}
				else
				{
					num13 = 0;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey);
				switch (num13)
				{
				case 0:
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = (float)X;
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = Fputil_nearest_integer.Invoke(num5 * 92.33248f);
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					checked
					{
						num7 = -unchecked((int)num6);
						Llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = num7 >>> 5;
						Llvm_lifetime_start_p0.Invoke(4L, &num9);
						num9 = num7 & 0x1F;
						Llvm_lifetime_start_p0.Invoke(4L, &x2);
						x2 = Fputil_multiply_add_float.Invoke(num6, -0.010830425f, num5);
						Llvm_lifetime_start_p0.Invoke(4L, &x3);
					}
					x3 = *(int*)Array_unsigned_int_32ul_Index.Invoke(Index: (uint)num9, This: EXP2_MID_5_BITS.Pointer) + (num8 << 23);
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
					FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs, x3);
					float num14 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
					num10 = num14;
					Llvm_lifetime_start_p0.Invoke(4L, &num11);
					num11 = Fputil_polyeval_float_float_float_float.Invoke(x2, 1f, 2f, 2.0004883f, 1.3334635f);
					result = Fputil_cast_Float16_float.Invoke((num11 - num10) / (num11 + num10));
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(4L, &x3);
					Llvm_lifetime_end_p0.Invoke(4L, &x2);
					Llvm_lifetime_end_p0.Invoke(4L, &num9);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					break;
				}
				}
			}
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
