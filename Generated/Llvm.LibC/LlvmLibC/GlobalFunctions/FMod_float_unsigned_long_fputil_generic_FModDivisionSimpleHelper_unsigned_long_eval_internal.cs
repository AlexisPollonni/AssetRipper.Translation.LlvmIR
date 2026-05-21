using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIfmNS1_24FModDivisionSimpleHelperImEEE13eval_internalENS0_6FPBitsIfEES7_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<float, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<float>, __llvm_libc_20_1_2_::fputil::FPBits<float>)")]
	public unsafe static int Invoke([MangledName("sx.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>")] int Sx, [MangledName("sy.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<float>")] int Sy)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		long num6 = 0L;
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int sides_zeroes_count = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = Sx;
		llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = Sy;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) <= (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3)), Expected: true))
			{
				if ((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) < (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3)))
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3));
				if (Details_expects_bool_condition_bool.Invoke(num2 > 23 && checked(num - num2) <= 8, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
					num5 = ((num != num2) ? ((int)((uint)(num3 << checked(num - num2)) % (uint)num4)) : (num3 - num4));
					if (num5 == 0)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb2.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					}
					else
					{
						int field_3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value.Invoke(num5, checked(num2 - 1));
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num5);
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
				}
				else if (Details_expects_bool_condition_bool.Invoke(num == 0 && num2 == 0, Expected: false))
				{
					*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs), (int)((uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2)) % (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3))));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = (uint)FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					num = checked(num + -1);
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = (uint)FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = 40;
					Llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = 40;
					if (Details_expects_bool_condition_bool.Invoke(num2 > 0, Expected: true))
					{
						num2 = checked(num2 + -1);
					}
					else
					{
						num7 = (uint)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3));
						num9 = Cpp_countl_zero_unsigned_long.Invoke(num7);
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = Cpp_countr_zero_unsigned_long.Invoke(num7);
					Llvm_lifetime_start_p0.Invoke(4L, &sides_zeroes_count);
					checked
					{
						sides_zeroes_count = num9 + num10;
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						num11 = num - num2;
						Llvm_lifetime_start_p0.Invoke(4L, &num12);
						num12 = ((num11 >= num10) ? num10 : num11);
						num7 >>>= unchecked((int)(uint)num12);
						num11 -= num12;
						num2 += num12;
						Llvm_lifetime_end_p0.Invoke(4L, &num12);
						Llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = ((num11 >= 40) ? 40 : num11);
						num6 <<= unchecked((int)(uint)num13);
						num11 -= num13;
						Llvm_lifetime_end_p0.Invoke(4L, &num13);
					}
					num6 = (long)((ulong)num6 % (ulong)num7);
					if (Details_expects_bool_condition_bool.Invoke(num6 == 0L, Expected: false))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb3.Val);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
					}
					else if (num11 == 0)
					{
						int field_5 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value.Invoke((int)num6, num2);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_5;
					}
					else
					{
						num6 = FModDivisionSimpleHelper_unsigned_long_execute.Invoke(num11, sides_zeroes_count, num6, num7);
						int field_6 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_make_value.Invoke((int)num6, num2);
						llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0 = field_6;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					Llvm_lifetime_end_p0.Invoke(4L, &sides_zeroes_count);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(4L, &num9);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return llvm_libc_20_1_2_fputil_FPBits_5nkvcs.FPRepImpl.FPRepSem.field_0.field_0;
		}
	}
}
