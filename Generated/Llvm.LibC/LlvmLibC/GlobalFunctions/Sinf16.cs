using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sinf16
{
	[MangledName("sinf16")]
	[DemangledName("sinf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		sbyte b = 0;
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		int num3 = 0;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		float num4 = 0f;
		float y = 0f;
		float num5 = 0f;
		float x = 0f;
		Fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			Llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)X;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((ushort)num >> 15 != 0) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(4L, &cpp_optional_aq7wey);
			sbyte* ptr = (sbyte*)(&cpp_optional_aq7wey);
			*(Half*)ptr = default(Half);
			ptr[2] = -86;
			ptr[3] = -86;
			int storage = ExceptValues_Float16_4ul_lookup_odd.Invoke(X_abs: num2, Sign: (b & 1) == 1, This: SINF16_EXCEPTS.Pointer);
			*(int*)(&cpp_optional_aq7wey.Storage) = storage;
			int num6;
			if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&cpp_optional_aq7wey), Expected: false))
			{
				result = *(Half*)Optional_Float16_value.Invoke(&cpp_optional_aq7wey);
				num6 = 1;
			}
			else
			{
				num6 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &cpp_optional_aq7wey);
			switch (num6)
			{
			case 0:
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = Fputil_quick_get_round.Invoke();
					if (!Details_expects_bool_condition_bool.Invoke((ushort)num2 <= 5072, Expected: false))
					{
						goto IL_028a;
					}
					if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
					{
						result = X;
					}
					else if ((num3 == 2048 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))) || (num3 == 1024 && FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva))))
					{
						result = X;
					}
					else
					{
						if (num3 != 2048 || !FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)))
						{
							goto IL_028a;
						}
						num += -1;
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
						FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva2, num);
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					}
					goto IL_0486;
				}
				IL_028a:
				if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva)))
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva)))
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					float num7 = (float)X;
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num7 + (float)FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3));
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &y);
					y = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &x);
					x = float.NaN;
					Sincosf16_eval.Invoke(xf, &num4, &y, &num5, &x);
					if (Details_expects_bool_condition_bool.Invoke(num5 == 0f && num4 == 0f, Expected: false))
					{
						Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
						anon_izyfb2.Val = FPStorage_fputil_FPType_0_sign.Invoke(&fputil_FPBits_2fahva);
						short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb2.Val);
						fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
						Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
					}
					else
					{
						result = Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(num5, y, Fputil_multiply_add_float.Invoke(x, num4, num4)));
					}
					Llvm_lifetime_end_p0.Invoke(4L, &x);
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					Llvm_lifetime_end_p0.Invoke(4L, &y);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				goto IL_0486;
				IL_0486:
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				break;
			}
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &xf);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
