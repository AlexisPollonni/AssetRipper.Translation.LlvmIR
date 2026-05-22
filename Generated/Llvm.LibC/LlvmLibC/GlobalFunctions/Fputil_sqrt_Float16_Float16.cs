using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_sqrt_Float16_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_DF16_EENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<_Float16> && sizeof (_Float16) <= sizeof (_Float16), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, _Float16>(_Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<_Float16> && sizeof (_Float16) <= sizeof (_Float16), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		short num = 0;
		Half half = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9 llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		short num6 = 0;
		short num7 = 0;
		short num8 = 0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm = default(Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_ys7s55 llvm_libc_20_1_2_BigInt_ys7s = default(Llvm_libc_20_1_2_BigInt_ys7s55);
		Llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 1024;
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh, &llvm_libc_20_1_2_fputil_FPBits_2fahva, 2L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh2, &llvm_libc_20_1_2_fputil_FPBits_2fahva2, 2L, isVolatile: false);
			bool num9 = Internal_Equals_9g7dhj.Invoke(llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh.FPRepSem.FPStorage.field_0, llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh2.FPRepSem.FPStorage.field_0) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) || FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			Half result;
			if (num9)
			{
				result = Fputil_cast_Float16_Float16.Invoke(X);
			}
			else if (FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
			{
				result = default(Half);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
				Llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
				if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)))
				{
					num2 = checked(num2 + 1);
					Internal_normalize_Float16.Invoke(&num2, &num3);
				}
				else
				{
					num3 = (short)((ushort)num3 | 0x400);
				}
				if ((num2 & 1) != 0)
				{
					num2 = checked(num2 + -1);
					num3 = (short)((ushort)num3 << 1);
				}
				Llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = 1024;
				Llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)checked(unchecked((ushort)num3) - 1024);
				Llvm_lifetime_start_p0.Invoke(2L, &num6);
				for (num6 = 512; num6 != 0; num6 = (short)((ushort)num6 >> 1))
				{
					num5 = (short)((ushort)num5 << 1);
					Llvm_lifetime_start_p0.Invoke(2L, &num7);
					num7 = (short)checked((unchecked((ushort)num4) << 1) + unchecked((ushort)num6));
					if ((ushort)num5 >= (ushort)num7)
					{
						num5 = (short)checked(unchecked((ushort)num5) - unchecked((ushort)num7));
						num4 = (short)checked(unchecked((ushort)num4) + unchecked((ushort)num6));
					}
					Llvm_lifetime_end_p0.Invoke(2L, &num7);
				}
				Llvm_lifetime_end_p0.Invoke(2L, &num6);
				num5 = (short)((ushort)num5 << 2);
				num4 = (short)((ushort)num4 << 2);
				Llvm_lifetime_start_p0.Invoke(2L, &num8);
				num8 = (short)checked(unchecked((ushort)num4) + 1);
				if ((ushort)num5 >= (ushort)num8)
				{
					num5 = (short)checked(unchecked((ushort)num5) - unchecked((ushort)num8));
					num4 = (short)((ushort)num4 | 2);
				}
				num4 = (short)((int)(ushort)num4 | (((ushort)num5 != 0) ? 1 : 0));
				Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm))[1] = -1431655766;
				((short*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm))[4] = -21846;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) + 10;
				*ptr2 = -86;
				ptr2[1] = -86;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num2 >> 1) - 2 - 10);
				BigInt_16ul_false_unsigned_short_BigInt_unsigned_short_void.Invoke(&llvm_libc_20_1_2_BigInt_ys7s, num4);
				DyadicFloat_16ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm, anon_izyfb2.Val, e, *(short*)(&llvm_libc_20_1_2_BigInt_ys7s.Val.Data));
				result = DyadicFloat_16ul_as_Float16_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
				Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
				Llvm_lifetime_end_p0.Invoke(2L, &num8);
				Llvm_lifetime_end_p0.Invoke(2L, &num5);
				Llvm_lifetime_end_p0.Invoke(2L, &num4);
				Llvm_lifetime_end_p0.Invoke(2L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			Llvm_lifetime_end_p0.Invoke(2L, &half);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
