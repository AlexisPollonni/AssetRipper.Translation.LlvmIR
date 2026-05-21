using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_Float16_unsigned_int_fputil_generic_FModDivisionSimpleHelper_unsigned_int_eval_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIDF16_jNS1_24FModDivisionSimpleHelperIjEEE13eval_internalENS0_6FPBitsIDF16_EES7_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<_Float16, unsigned int, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned int>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<_Float16>, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>)")]
	public unsafe static short Invoke([MangledName("sx.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>")] short Sx, [MangledName("sy.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<_Float16>")] short Sy)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva3 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int sides_zeroes_count = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = Sx;
		llvm_libc_20_1_2_fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = Sy;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)) <= (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3)), Expected: true))
			{
				if ((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)) < (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3)))
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, &llvm_libc_20_1_2_fputil_FPBits_2fahva2, 2L, isVolatile: false);
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2));
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3));
				if (Details_expects_bool_condition_bool.Invoke(num2 > 10 && checked(num - num2) <= 5, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &num3);
					num3 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2));
					Llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3));
					Llvm_lifetime_start_p0.Invoke(2L, &num5);
					num5 = (short)((num != num2) ? ((ushort)(short)((ushort)num3 << checked(num - num2)) % (ushort)num4) : checked(unchecked((ushort)num3) - unchecked((ushort)num4)));
					if ((ushort)num5 == 0)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						short field_2 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb2.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_2;
					}
					else
					{
						short field_3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value.Invoke(num5, checked(num2 - 1));
						llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_3;
					}
					Llvm_lifetime_end_p0.Invoke(2L, &num5);
					Llvm_lifetime_end_p0.Invoke(2L, &num4);
					Llvm_lifetime_end_p0.Invoke(2L, &num3);
				}
				else if (Details_expects_bool_condition_bool.Invoke(num == 0 && num2 == 0, Expected: false))
				{
					*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
					FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva), (short)((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)) % (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3))));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = (ushort)FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2));
					num = checked(num + -1);
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = (ushort)FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3));
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = 21;
					Llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = 21;
					if (Details_expects_bool_condition_bool.Invoke(num2 > 0, Expected: true))
					{
						num2 = checked(num2 + -1);
					}
					else
					{
						num7 = (ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva3));
						num9 = Cpp_countl_zero_unsigned_int.Invoke(num7);
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = Cpp_countr_zero_unsigned_int.Invoke(num7);
					Llvm_lifetime_start_p0.Invoke(4L, &sides_zeroes_count);
					checked
					{
						sides_zeroes_count = num9 + num10;
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						num11 = num - num2;
						Llvm_lifetime_start_p0.Invoke(4L, &num12);
						num12 = ((num11 >= num10) ? num10 : num11);
						num7 >>>= num12;
						num11 -= num12;
						num2 += num12;
						Llvm_lifetime_end_p0.Invoke(4L, &num12);
						Llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = ((num11 >= 21) ? 21 : num11);
						num6 <<= num13;
						num11 -= num13;
						Llvm_lifetime_end_p0.Invoke(4L, &num13);
					}
					num6 = (int)((uint)num6 % (uint)num7);
					if (Details_expects_bool_condition_bool.Invoke(num6 == 0, Expected: false))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						short field_4 = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_zero.Invoke(anon_izyfb3.Val);
						llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_4;
					}
					else if (num11 == 0)
					{
						short field_5 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value.Invoke((short)num6, num2);
						llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_5;
					}
					else
					{
						num6 = FModDivisionSimpleHelper_unsigned_int_execute.Invoke(num11, sides_zeroes_count, num6, num7);
						short field_6 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_make_value.Invoke((short)num6, num2);
						llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_6;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					Llvm_lifetime_end_p0.Invoke(4L, &sides_zeroes_count);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(4L, &num9);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0;
		}
	}
}
