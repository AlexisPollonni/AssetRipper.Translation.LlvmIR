using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_sqrt_Float16_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, float>(float)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("float")] float X)
	{
		int num = 0;
		Half half = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs = default(Llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_vtm4cw llvm_libc_20_1_2_BigInt_vtm4cw = default(Llvm_libc_20_1_2_BigInt_vtm4cw);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 8388608;
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs, 4L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm2, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
			bool num9 = Internal_Equals_wuhucm.Invoke(llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm.FPRepSem.field_0.field_0, llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) || FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Half result;
			if (num9)
			{
				result = Fputil_cast_Float16_float.Invoke(X);
			}
			else if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)))
			{
				result = default(Half);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
				checked
				{
					if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
					{
						num2++;
						Internal_normalize_float.Invoke(&num2, &num3);
					}
					else
					{
						num3 |= 0x800000;
					}
					if ((num2 & 1) != 0)
					{
						num2 += -1;
						num3 <<= 1;
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 8388608;
					Llvm_lifetime_start_p0.Invoke(4L, &num5);
				}
				num5 = num3 - 8388608;
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				for (num6 = 4194304; num6 != 0; num6 >>>= 1)
				{
					num5 <<= 1;
					Llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = (num4 << 1) + num6;
					if ((uint)num5 >= (uint)num7)
					{
						num5 -= num7;
						num4 += num6;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num7);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				num5 <<= 2;
				num4 <<= 2;
				Llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = num4 + 1;
				if ((uint)num5 >= (uint)num8)
				{
					num5 -= num8;
					num4 |= 2;
				}
				num4 |= ((num5 != 0) ? 1 : 0);
				Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs) = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs))[1] = -1431655766;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs))[2] = -1431655766;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num2 >> 1) - 2 - 23);
				BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void.Invoke(&llvm_libc_20_1_2_BigInt_vtm4cw, num4);
				DyadicFloat_32ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs, anon_izyfb2.Val, e, *(int*)(&llvm_libc_20_1_2_BigInt_vtm4cw.Val.Data));
				result = DyadicFloat_32ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
				Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_cs3nhs);
				Llvm_lifetime_end_p0.Invoke(4L, &num8);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
				Llvm_lifetime_end_p0.Invoke(4L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(2L, &half);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
