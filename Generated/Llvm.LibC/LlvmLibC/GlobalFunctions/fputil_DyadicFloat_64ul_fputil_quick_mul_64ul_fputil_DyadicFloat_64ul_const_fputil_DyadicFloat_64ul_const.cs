using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil9quick_mulILm64EEENS0_11DyadicFloatIXT_EEERKS3_S5_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> __llvm_libc_20_1_2_::fputil::quick_mul<64ul>(__llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<64ul> const&)")]
internal static partial class fputil_DyadicFloat_64ul_fputil_quick_mul_64ul_fputil_DyadicFloat_64ul_const_fputil_DyadicFloat_64ul_const
{
	public unsafe static Struct_fiz2nb Invoke(fputil_DyadicFloat_syracv* a, fputil_DyadicFloat_syracv* b)
	{
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		BigInt_555ggs bigInt_555ggs2 = default(BigInt_555ggs);
		unchecked
		{
			*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
			sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
			((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
			fputil_DyadicFloat_64ul_DyadicFloat.Invoke(&fputil_DyadicFloat_syracv2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &a->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &b->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(source: (!operator_Sign_Sign_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? Sign_POS.Pointer : Sign_NEG.Pointer, destination: &fputil_DyadicFloat_syracv2.sign, length: 1L, isVolatile: false);
			fputil_DyadicFloat_syracv2.exponent = checked(a->exponent + b->exponent + 64);
			if (!BigInt_64ul_false_unsigned_long_is_zero_const.Invoke(&a->mantissa) && !BigInt_64ul_false_unsigned_long_is_zero_const.Invoke(&b->mantissa))
			{
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs);
				long data = BigInt_64ul_false_unsigned_long_quick_mul_hi_BigInt_64ul_false_unsigned_long_const_const.Invoke(&a->mantissa, &b->mantissa);
				*(long*)(&bigInt_555ggs.val.Data) = data;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_syracv2.mantissa, &bigInt_555ggs, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs);
				if (*(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long.Invoke(&fputil_DyadicFloat_syracv2.mantissa.val, 0L) >>> 63 == 0L)
				{
					fputil_DyadicFloat_64ul_shift_left_unsigned_int.Invoke(&fputil_DyadicFloat_syracv2, 1);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &bigInt_555ggs2);
				BigInt_64ul_false_unsigned_long_BigInt_int_void_int.Invoke(&bigInt_555ggs2, 0);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_DyadicFloat_syracv2.mantissa, &bigInt_555ggs2, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &bigInt_555ggs2);
			}
			return *(Struct_fiz2nb*)(&fputil_DyadicFloat_syracv2);
		}
	}
}
