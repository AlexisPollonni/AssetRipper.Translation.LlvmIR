using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_DF16_EENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<_Float16> && sizeof (_Float16) <= sizeof (_Float16), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, _Float16>(_Float16)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_Float16_sizeof_Float16_sizeof_Float16_Float16_type_fputil_sqrt_Float16_Float16_Float16
{
	public unsafe static Half Invoke(Half x)
	{
		short num = 0;
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh10 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_internal_FPRepImpl_7z3gh9 fputil_internal_FPRepImpl_7z3gh11 = default(fputil_internal_FPRepImpl_7z3gh9);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		short num5 = 0;
		short num6 = 0;
		short num7 = 0;
		short num8 = 0;
		fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm2 = default(fputil_DyadicFloat_jvghxm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_ys7s55 bigInt_ys7s = default(BigInt_ys7s55);
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = 1024;
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh10, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb8.val);
			fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_7z3gh11, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
			int num9 = (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16.Invoke(fputil_internal_FPRepImpl_7z3gh10.FPRepSem.FPStorage.field_0, fputil_internal_FPRepImpl_7z3gh11.FPRepSem.FPStorage.field_0) ? (-1) : ((!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2))) ? (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)) ? 1 : 0) : (-1)));
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			Half result;
			if (num9 != 0)
			{
				result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_Float16_Float16_type_fputil_cast_Float16_Float16_Float16.Invoke(x);
			}
			else if (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)))
			{
				result = default(Half);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
				llvm_lifetime_start_p0.Invoke(2L, &num3);
				num3 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
				if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
				{
					num2 = checked(num2 + 1);
					void_fputil_internal_normalize_Float16_int_fputil_FPBits_Float16_StorageType.Invoke(&num2, &num3);
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
				llvm_lifetime_start_p0.Invoke(2L, &num4);
				num4 = 1024;
				llvm_lifetime_start_p0.Invoke(2L, &num5);
				num5 = (short)checked(unchecked((ushort)num3) - 1024);
				llvm_lifetime_start_p0.Invoke(2L, &num6);
				for (num6 = 512; num6 != 0; num6 = (short)((ushort)num6 >> 1))
				{
					num5 = (short)((ushort)num5 << 1);
					llvm_lifetime_start_p0.Invoke(2L, &num7);
					num7 = (short)checked((unchecked((ushort)num4) << 1) + unchecked((ushort)num6));
					if ((ushort)num5 >= (ushort)num7)
					{
						num5 = (short)checked(unchecked((ushort)num5) - unchecked((ushort)num7));
						num4 = (short)checked(unchecked((ushort)num4) + unchecked((ushort)num6));
					}
					llvm_lifetime_end_p0.Invoke(2L, &num7);
				}
				llvm_lifetime_end_p0.Invoke(2L, &num6);
				num5 = (short)((ushort)num5 << 2);
				num4 = (short)((ushort)num4 << 2);
				llvm_lifetime_start_p0.Invoke(2L, &num8);
				num8 = (short)checked(unchecked((ushort)num4) + 1);
				if ((ushort)num5 >= (ushort)num8)
				{
					num5 = (short)checked(unchecked((ushort)num5) - unchecked((ushort)num8));
					num4 = (short)((ushort)num4 | 2);
				}
				num4 = (short)((int)(ushort)num4 | (((ushort)num5 != 0) ? 1 : 0));
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
				*(sbyte*)(&fputil_DyadicFloat_jvghxm2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_jvghxm2))[1] = -1431655766;
				((short*)(&fputil_DyadicFloat_jvghxm2))[4] = -21846;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 10;
				*ptr2 = -86;
				ptr2[1] = -86;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num2 >> 1) - 2 - 10);
				BigInt_16ul_false_unsigned_short_BigInt_unsigned_short_void_unsigned_short.Invoke(&bigInt_ys7s, num4);
				fputil_DyadicFloat_16ul_DyadicFloat_Sign_int_BigInt_16ul_false_unsigned_short.Invoke(&fputil_DyadicFloat_jvghxm2, anon_izyfb9.val, e, *(short*)(&bigInt_ys7s.val.Data));
				result = Float16_fputil_DyadicFloat_16ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_jvghxm2);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
				llvm_lifetime_end_p0.Invoke(2L, &num8);
				llvm_lifetime_end_p0.Invoke(2L, &num5);
				llvm_lifetime_end_p0.Invoke(2L, &num4);
				llvm_lifetime_end_p0.Invoke(2L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_lifetime_end_p0.Invoke(2L, &half);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			return result;
		}
	}
}
