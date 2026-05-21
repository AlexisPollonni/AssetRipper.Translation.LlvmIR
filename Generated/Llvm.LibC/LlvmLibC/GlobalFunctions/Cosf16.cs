using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cosf16
{
	[MangledName("cosf16")]
	[DemangledName("cosf16")]
	public unsafe static Half Invoke([MangledName("x")] Half X)
	{
		Half result = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		short num = 0;
		short num2 = 0;
		float xf = 0f;
		Llvm_libc_20_1_2_cpp_optional_aq7wey llvm_libc_20_1_2_cpp_optional_aq7wey = default(Llvm_libc_20_1_2_cpp_optional_aq7wey);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		float num3 = 0f;
		float num4 = 0f;
		float y = 0f;
		float y2 = 0f;
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = (short)((ushort)num & 0x7FFF);
			Llvm_lifetime_start_p0.Invoke(4L, &xf);
			xf = (float)X;
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_cpp_optional_aq7wey);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_aq7wey);
			*(Half*)ptr = default(Half);
			ptr[2] = -86;
			ptr[3] = -86;
			int storage = ExceptValues_Float16_4ul_lookup.Invoke(X_bits: num2, This: Llvm_libc_20_1_2_COSF16_EXCEPTS.Pointer);
			*(int*)(&llvm_libc_20_1_2_cpp_optional_aq7wey.Storage) = storage;
			int num5;
			if (Details_expects_bool_condition_bool.Invoke(Optional_Float16_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_aq7wey), Expected: false))
			{
				result = *(Half*)Optional_Float16_value.Invoke(&llvm_libc_20_1_2_cpp_optional_aq7wey);
				num5 = 1;
			}
			else
			{
				num5 = 0;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_cpp_optional_aq7wey);
			switch (num5)
			{
			case 0:
				if (Details_expects_bool_condition_bool.Invoke((ushort)num2 == 0, Expected: false))
				{
					result = Fputil_cast_Float16_float.Invoke(1f);
				}
				else if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
				{
					if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					float num6 = (float)X;
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(anon_izyfb.Val, 0);
					llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
					result = (Half)(num6 + (float)FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2));
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &y);
					y = float.NaN;
					Llvm_lifetime_start_p0.Invoke(4L, &y2);
					y2 = float.NaN;
					Llvm_libc_20_1_2_sincosf16_eval.Invoke(xf, &num3, &num4, &y, &y2);
					result = Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(num4, y2, Fputil_multiply_add_float.Invoke(0f - num3, y, num4)));
					Llvm_lifetime_end_p0.Invoke(4L, &y2);
					Llvm_lifetime_end_p0.Invoke(4L, &y);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
				}
				break;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &xf);
			Llvm_lifetime_end_p0.Invoke(2L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			return result;
		}
	}
}
