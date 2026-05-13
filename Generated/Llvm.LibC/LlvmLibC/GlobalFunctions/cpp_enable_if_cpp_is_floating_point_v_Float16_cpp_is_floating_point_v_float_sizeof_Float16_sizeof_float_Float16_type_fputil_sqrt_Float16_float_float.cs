using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_fEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<float> && sizeof (_Float16) <= sizeof (float), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, float>(float)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_sizeof_Float16_sizeof_float_Float16_type_fputil_sqrt_Float16_float_float
{
	public unsafe static Half Invoke(float x)
	{
		int num = 0;
		Half half = default(Half);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm2 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_internal_FPRepImpl_vhj4tm fputil_internal_FPRepImpl_vhj4tm3 = default(fputil_internal_FPRepImpl_vhj4tm);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		fputil_DyadicFloat_c8qpxg fputil_DyadicFloat_c8qpxg2 = default(fputil_DyadicFloat_c8qpxg);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_fzjdu3 bigInt_fzjdu = default(BigInt_fzjdu3);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 8388608;
		llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm2, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb8.val);
			fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_vhj4tm3, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
			int num9 = (fputil_internal_operator_fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float.Invoke(fputil_internal_FPRepImpl_vhj4tm2.FPRepSem.field_0.field_0, fputil_internal_FPRepImpl_vhj4tm3.FPRepSem.field_0.field_0) ? (-1) : ((!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2)) ? (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2) ? 1 : 0) : (-1)));
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			Half result;
			if (num9 != 0)
			{
				result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(x);
			}
			else if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)))
			{
				result = default(Half);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
				checked
				{
					if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						num2++;
						void_fputil_internal_normalize_float_int_fputil_FPBits_float_StorageType.Invoke(&num2, &num3);
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
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 8388608;
					llvm_lifetime_start_p0.Invoke(4L, &num5);
				}
				num5 = num3 - 8388608;
				llvm_lifetime_start_p0.Invoke(4L, &num6);
				for (num6 = 4194304; num6 != 0; num6 >>>= 1)
				{
					num5 <<= 1;
					llvm_lifetime_start_p0.Invoke(4L, &num7);
					num7 = (num4 << 1) + num6;
					if ((uint)num5 >= (uint)num7)
					{
						num5 -= num7;
						num4 += num6;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num7);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num6);
				num5 <<= 2;
				num4 <<= 2;
				llvm_lifetime_start_p0.Invoke(4L, &num8);
				num8 = num4 + 1;
				if ((uint)num5 >= (uint)num8)
				{
					num5 -= num8;
					num4 |= 2;
				}
				num4 |= ((num5 != 0) ? 1 : 0);
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg2);
				*(sbyte*)(&fputil_DyadicFloat_c8qpxg2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_c8qpxg2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_c8qpxg2))[1] = -1431655766;
				((int*)(&fputil_DyadicFloat_c8qpxg2))[2] = -1431655766;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num2 >> 1) - 2 - 23);
				BigInt_32ul_false_unsigned_int_BigInt_unsigned_int_void_unsigned_int.Invoke(&bigInt_fzjdu, num4);
				fputil_DyadicFloat_32ul_DyadicFloat_Sign_int_BigInt_32ul_false_unsigned_int.Invoke(&fputil_DyadicFloat_c8qpxg2, anon_izyfb9.val, e, *(int*)(&bigInt_fzjdu.val.Data));
				result = Float16_fputil_DyadicFloat_32ul_as_Float16_true_void_const.Invoke(&fputil_DyadicFloat_c8qpxg2);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg2);
				llvm_lifetime_end_p0.Invoke(4L, &num8);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(2L, &half);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
