using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sinhf16
{
	[MangledName("sinhf16")]
	[DemangledName("sinhf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		int num3 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva5 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva6 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva7 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva8 = default(Fputil_FPBits_2fahva);
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		Cpp_optional_aq7wey cpp_optional_aq7wey2 = default(Cpp_optional_aq7wey);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0 || ((uint)(ushort)num >= 33792u && (uint)(ushort)num <= 41984u) || (uint)(ushort)num2 >= 18917u, Expected: false))
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
				else if ((ushort)num2 == 0)
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
					short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb2.Val);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else if ((uint)(ushort)num2 >= 18917u)
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						anon_izyfb3.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
						short field_3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb3.Val);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = Fputil_quick_get_round.Invoke();
						if (num3 == 0 || (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) && num3 == 2048) || (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)) && num3 == 1024))
						{
							Fputil_set_errno_if_required.Invoke(34);
							Fputil_raise_except_if_required.Invoke(40);
							Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva5);
							anon_izyfb4.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
							short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb4.Val);
							fputil_FPBits_2fahva5.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
							result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva5);
							Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva5);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva6);
							anon_izyfb5.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
							short field_5 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_max_normal.Invoke(anon_izyfb5.Val);
							fputil_FPBits_2fahva6.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
							result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva6);
							Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva6);
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num3);
					}
				}
				else if (Fputil_fenv_is_round_down.Invoke())
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva7);
					FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva7, (short)checked(unchecked((ushort)num) + 1));
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva7);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva7);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva8);
					FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva8, num);
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva8);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva8);
				}
			}
			else
			{
				if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey);
					sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey);
					*(Half*)ptr = default(Half);
					ptr[2] = -86;
					ptr[3] = -86;
					int storage = ExceptValues_Float16_16ul_lookup.Invoke(X_bits: num, This: SINHF16_EXCEPTS_POS.Pointer);
					*(int*)(&cpp_optional_aq7wey.Storage) = storage;
					int num4;
					if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey), Expected: false))
					{
						result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey);
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey);
					switch (num4)
					{
					case 0:
						break;
					default:
						goto IL_05d9;
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey2);
					sbyte* ptr2 = (sbyte*)(&cpp_optional_aq7wey2);
					*(Half*)ptr2 = default(Half);
					ptr2[2] = -86;
					ptr2[3] = -86;
					int storage2 = ExceptValues_Float16_12ul_lookup.Invoke(X_bits: num, This: SINHF16_EXCEPTS_NEG.Pointer);
					*(int*)(&cpp_optional_aq7wey2.Storage) = storage2;
					int num4;
					if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey2), Expected: false))
					{
						result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey2);
						num4 = 1;
					}
					else
					{
						num4 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey2);
					switch (num4)
					{
					case 0:
						break;
					default:
						goto IL_05d9;
					}
				}
				result = Eval_sinh_or_cosh_true.Invoke(X);
			}
			goto IL_05d9;
		}
		IL_05d9:
		Llvm_lifetime_end_p0.Invoke(2L, &num2);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
		return result;
	}
}
